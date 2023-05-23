﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Specification.Terminology;
using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using T = System.Threading.Tasks;

namespace Hl7.Fhir.Conformance.Specification.Terminology
{
    internal class MimeTypeTerminologyService : ITerminologyService
    {
        private const string MIMETYPE_SYSTEM = "urn:ietf:bcp:13";
        private const string MIMETYPE_VALUESET = "http://hl7.org/fhir/ValueSet/mimetypes";


        public T.Task<Resource> Closure(Parameters parameters, bool useGet = false) => throw new NotImplementedException();
        public T.Task<Parameters> CodeSystemValidateCode(Parameters parameters, string id = null, bool useGet = false) => throw new NotImplementedException();
        public T.Task<Resource> Expand(Parameters parameters, string id = null, bool useGet = false) => throw new NotImplementedException();
        public T.Task<Parameters> Lookup(Parameters parameters, bool useGet = false) => throw new NotImplementedException();
        public T.Task<Parameters> Subsumes(Parameters parameters, string id = null, bool useGet = false) => throw new NotImplementedException();
        public T.Task<Parameters> Translate(Parameters parameters, string id = null, bool useGet = false) => throw new NotImplementedException();

        public async T.Task<Parameters> ValueSetValidateCode(Parameters parameters, string id = null, bool useGet = false)
        {

            parameters.checkForValidityOfValidateCodeParams();

            var validCodeParams = new ValidateCodeParameters(parameters);

            if (validCodeParams?.Url?.Value != MIMETYPE_VALUESET)
            {   // 404 not found
                throw new FhirOperationException($"Cannot validate mimetypes using valueset '{validCodeParams.Url.Value}'", HttpStatusCode.NotFound);
            }

            try
            {
                if (validCodeParams.CodeableConcept is { })
                    return await validateCodeVS(validCodeParams.CodeableConcept).ConfigureAwait(false);
                else if (validCodeParams.Coding is { })
                    return await validateCodeVS(validCodeParams.Coding).ConfigureAwait(false);
                else
                    return await validateCodeVS(validCodeParams.Code?.Value, validCodeParams.System?.Value).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                //500 internal server error
                throw new FhirOperationException(e.Message, (HttpStatusCode)500);
            }

        }

        private async Task<Parameters> validateCodeVS(Coding coding)
        {
            return await validateCodeVS(coding.Code, coding.System).ConfigureAwait(false);
        }

        private async Task<Parameters> validateCodeVS(CodeableConcept cc)
        {
            var result = new Parameters();

            // Maybe just a text, but if there are no codings, that's a positive result
            if (!cc.Coding.Any())
            {
                result.Add("result", new FhirBoolean(true));
                return result;
            }

            // If we have just 1 coding, we better handle this using the simpler version of ValidateBinding
            if (cc.Coding.Count == 1)
                return await validateCodeVS(cc.Coding.Single()).ConfigureAwait(false);


            // Else, look for one succesful match in any of the codes in the CodeableConcept
            var callResults = await Task.WhenAll(cc.Coding.Select(coding => validateCodeVS(coding))).ConfigureAwait(false);
            var anySuccesful = callResults.Any(p => p.GetSingleValue<FhirBoolean>("result")?.Value == true);

            if (anySuccesful == false)
            {
                var messages = new StringBuilder();
                messages.AppendLine("None of the Codings in the CodeableConcept were valid for the binding. Details follow.");

                // gathering the messages of all calls
                foreach (var msg in callResults.Select(cr => cr.GetSingleValue<FhirString>("message")?.Value).Where(m => m is { }))
                {
                    messages.AppendLine(msg);
                }

                result.Add("message", new FhirString(messages.ToString()));
                result.Add("result", new FhirBoolean(false));
            }
            else
            {
                result.Add("result", new FhirBoolean(true));
            }

            return result;
        }

        private static Task<Parameters> validateCodeVS(string code, string system)
        {
            var result = new Parameters();

            if (code is null)
            {
                result.Add("message", new FhirString("No code supplied."))
                      .Add("result", new FhirBoolean(false));

            }
            else if (system == MIMETYPE_SYSTEM || system == null)
            {
                var success = validateMimeType(code);

                if (success)
                {
                    result.Add("result", new FhirBoolean(true));
                }
                else
                {
                    result.Add("result", new FhirBoolean(false))
                          .Add("message", new FhirString("Invalid mimetype specified"));
                }
            }
            else
            {
                result.Add("result", new FhirBoolean(false))
                      .Add("message", new FhirString($"Unknown system {system} encountered, cannot validate mime-type"));
            }
            return Task.FromResult(result);
        }

        //mime-type format: type "/" [tree "."] subtype ["+" suffix]* [";" parameter];
        private static bool validateMimeType(string code)
        {
            var entries = code.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            return entries.Length == 2;
        }
    }
}

