﻿/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
 */

using System;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.Rest
{
    public static class BundleToEntryRequest
    {
        /// <inheritdoc cref="ToEntryRequestAsync(Bundle.EntryComponent, FhirClientSettings)" />
        [Obsolete("Use ToEntryRequestAsync(Bundle.EntryComponent, FhirClientSettings) instead.")]
        public static EntryRequest ToEntryRequest(this Bundle.EntryComponent entry, FhirClientSettings settings) 
            => TaskHelper.Await(() => ToEntryRequestAsync(entry, settings));

            public static async Task<EntryRequest> ToEntryRequestAsync(this Bundle.EntryComponent entry, FhirClientSettings settings)
        {
            var result = new EntryRequest
            {
                Agent = ModelInfo.Version,
                Method = bundleHttpVerbToRestHttpVerb(entry.Request.Method, entry.Annotation<InteractionType>()),
                Type = entry.Annotation<InteractionType>(),
                Url = entry.Request.Url,
                Headers = new EntryRequestHeaders
                {
                    IfMatch = entry.Request.IfMatch,
                    IfModifiedSince = entry.Request.IfModifiedSince,
                    IfNoneExist = entry.Request.IfNoneExist,
                    IfNoneMatch = entry.Request.IfNoneMatch
                }                
            };

            if (!settings.UseFormatParameter)
            {
                result.Headers.Accept = ContentType.BuildContentType(settings.PreferredFormat, ModelInfo.Version);
            }

            if (entry.Resource != null)
            {
                bool searchUsingPost =
                    result.Method == HTTPVerb.POST
                    && entry.Annotation<InteractionType>() == InteractionType.Search
                    && entry.Resource is Parameters;
                await setBodyAndContentTypeAsync(result, entry.Resource, settings.PreferredFormat, searchUsingPost);
            }

            return result;
        }

        private static HTTPVerb? bundleHttpVerbToRestHttpVerb(Bundle.HTTPVerb? bundleHttp, InteractionType type)
        {
            switch(bundleHttp)
            {
                case Bundle.HTTPVerb.POST:
                {
                    return HTTPVerb.POST;
                }
                case Bundle.HTTPVerb.GET:
                {
                    return HTTPVerb.GET;
                }
                case Bundle.HTTPVerb.DELETE:
                {
                    return HTTPVerb.DELETE;
                }
                case Bundle.HTTPVerb.PUT:
                {
                        //No PATCH in Bundle.HttpVerb in STU3, so this is corrected here. 
                        return type == InteractionType.Patch ? HTTPVerb.PATCH : HTTPVerb.PUT;
                }
                default:
                {
                    return null;
                }
            }
        }
        
        private static async Task setBodyAndContentTypeAsync(EntryRequest request, Resource data, ResourceFormat format, bool searchUsingPost)
        {
            if (data == null) throw Error.ArgumentNull(nameof(data));

            if (data is Binary bin)
            {

                //Binary.Content is available for STU3. This has changed for R4 as it is Binary.Data
                request.RequestBodyContent = bin.Content;

                // This is done by the caller after the OnBeforeRequest is called so that other properties
                // can be set before the content is committed
                // request.WriteBody(CompressRequestBody, bin.Content);
                request.ContentType = bin.ContentType;
            }
            else if (searchUsingPost)
            {
                List<KeyValuePair<string, string>> bodyParameters = new List<KeyValuePair<string, string>>();
                foreach (Parameters.ParameterComponent parameter in ((Parameters)data).Parameter)
                {
                    bodyParameters.Add(new KeyValuePair<string,string>(parameter.Name, parameter.Value.ToString()));
                }
                if (bodyParameters.Count > 0)
                {
                    FormUrlEncodedContent content = new FormUrlEncodedContent(bodyParameters);
                    request.RequestBodyContent = content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
                }
                else
                {
                    request.RequestBodyContent = null;
                }

                request.ContentType = "application/x-www-form-urlencoded";
            }
            else
            {
                request.RequestBodyContent = format == ResourceFormat.Xml ?
                    await new FhirXmlSerializer().SerializeToBytesAsync(data, summary: Fhir.Rest.SummaryType.False) :
                    await new FhirJsonSerializer().SerializeToBytesAsync(data, summary: Fhir.Rest.SummaryType.False);

                // This is done by the caller after the OnBeforeRequest is called so that other properties
                // can be set before the content is committed
                // request.WriteBody(CompressRequestBody, body);
                request.ContentType = ContentType.BuildContentType(format, ModelInfo.Version);
            }
        }
    }
}
