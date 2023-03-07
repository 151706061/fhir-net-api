﻿#nullable enable

using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using System;

namespace Hl7.Fhir.Rest
{
    public class FhirClientSettings
    {
        /// <summary>
        /// Whether or not to ask the server for a CapabilityStatement and verify FHIR version compatibility before
        /// issuing requests to the server.
        /// </summary>
        public bool VerifyFhirVersion;

        /// <summary>
        /// Normally, the FhirClient will derive the FHIR version (e.g. 4.0.3) the client is communicating with
        /// from the metadata of the assembly containing the resource POCOs. Use this member to override this version.
        /// </summary>
        public string? ExplicitFhirVersion;

        /// <summary>
        /// The preferred format of the content to be used when communicating with the FHIR server (XML or JSON)
        /// </summary>
        public ResourceFormat PreferredFormat = ResourceFormat.Xml;

        /// <summary>
        /// When passing the content preference, use the _format parameter instead of the request header
        /// </summary>
        public bool UseFormatParameter;

        /// <summary>
        /// When <see langword="true"/> the MIME-type parameter fhirVersion will be added the Accept header. This is necessary 
        /// when the FHIR server supports multiple FHIR versions.
        /// </summary>
        public bool UseFhirVersionInAcceptHeader = false;

        /// <summary>
        /// The timeout (in milliseconds) to be used when making calls to the FHIR server
        /// </summary>
        public int Timeout = 100 * 1000;

        /// <inheritdoc cref="ReturnPreference"/>
        [Obsolete("Use ReturnPreference and/or set UseAsync instead.")]
        public Prefer? PreferredReturn
        {
            get => UseAsync ? Prefer.RespondAsync : (Prefer?)ReturnPreference;
            set
            {
                switch (value)
                {
                    case Prefer.RespondAsync:
                        UseAsync = true;
                        break;
                    case null:
                        UseAsync = false;
                        ReturnPreference = null;
                        break;
                    default:
                        ReturnPreference = (ReturnPreference)value;
                        break;
                }
            }
        }

        /// <summary>
        /// Should calls to Create, Update and transaction operations return the whole updated content, 
        /// minimal content or an OperationOutcome (see https://hl7.org/fhir/http.html#return).
        /// </summary>
        /// <remarks>When null, no Prefer header with a "return=" prefix will be sent.</remarks>
        public ReturnPreference? ReturnPreference = null;

        /// <summary>
        /// Request the server to use the asynchronous request pattern (https://hl7.org/fhir/async.html).
        /// </summary>
        public bool UseAsync = false;

        /// <summary>
        /// Should server return which search parameters were supported after executing a search?
        /// </summary>
        /// <remarks>If set to null, no Prefer header with a "handling=" prefix will be sent.</remarks>
        public SearchParameterHandling? PreferredParameterHandling = null;

        /// <summary>
        /// This will do 2 things:
        /// 1. Add the header Accept-Encoding: gzip, deflate
        /// 2. decompress any responses that have Content-Encoding: gzip (or deflate)
        /// </summary>
        public bool PreferCompressedResponses;

        /// <summary>
        /// Compress any Request bodies 
        /// (warning, if a server does not handle compressed requests you will get a 415 response)
        /// </summary>
        [Obsolete("Compressing bodies is no longer supported, and this setting is ignored.")]
        public bool CompressRequestBody;

        /// <summary>
        /// Can be used to specifically override the serialization behaviour of the FhirClient to turn
        /// POCO's into FHIR xml/json data and vice versa. If not set, the FhirClient will use the default
        /// behaviour which is compatible with the pre-5.0 SDK.
        /// </summary>
        public IFhirSerializationEngine? SerializationEngine = null;

        public ParserSettings? ParserSettings = ParserSettings.CreateDefault();

        public FhirClientSettings() { }

        /// <summary>Clone constructor. Generates a new <see cref="FhirClientSettings"/> instance initialized from the state of the specified instance.</summary>
        /// <exception cref="ArgumentNullException">The specified argument is <c>null</c>.</exception>
        public FhirClientSettings(FhirClientSettings other)
        {
            if (other == null) throw Error.ArgumentNull(nameof(other));
            other.CopyTo(this);
        }

        /// <summary>Copy all configuration settings to another instance.</summary>
        /// <param name="other">Another <see cref="FhirClientSettings"/> instance.</param>
        /// <exception cref="ArgumentNullException">The specified argument is <c>null</c>.</exception>
        public void CopyTo(FhirClientSettings other)
        {
            if (other == null) throw Error.ArgumentNull(nameof(other));

#pragma warning disable CS0618 // Type or member is obsolete
            other.CompressRequestBody = CompressRequestBody;
#pragma warning restore CS0618 // Type or member is obsolete
            other.ParserSettings = ParserSettings;
            other.PreferCompressedResponses = PreferCompressedResponses;
            other.PreferredFormat = PreferredFormat;
            other.ReturnPreference = ReturnPreference;
            other.UseAsync = UseAsync;
            other.Timeout = Timeout;
            other.UseFormatParameter = UseFormatParameter;
            other.UseFhirVersionInAcceptHeader = UseFhirVersionInAcceptHeader;
            other.VerifyFhirVersion = VerifyFhirVersion;
            other.ExplicitFhirVersion = ExplicitFhirVersion;
            other.PreferredParameterHandling = PreferredParameterHandling;
            other.SerializationEngine = SerializationEngine;
        }

        /// <summary>Creates a new <see cref="FhirClientSettings"/> object that is a copy of the current instance.</summary>
        public FhirClientSettings Clone() => new(this);

        /// <summary>Creates a new <see cref="FhirClientSettings"/> instance with default property values.</summary>
        public static FhirClientSettings CreateDefault() => new();
    }
}

#nullable restore