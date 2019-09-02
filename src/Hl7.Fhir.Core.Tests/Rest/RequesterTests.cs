﻿/*
 * Copyright(c) 2017, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hl7.Fhir.Test
{
    [TestClass]
    public class RequesterTests
    {
        private readonly Uri _endpoint = new Uri("http://myserver.org/fhir");
        private EntryRequest _Entry
        {
            get
            {
                return new EntryRequest
                {
                    Url = "test",
                    Method = HTTPVerb.GET,
                    Type = InteractionType.Create,
                    Headers = new EntryRequestHeaders()
                };
            }
        }
        private FhirClientSettings _Settings
        {
            get
            {
                return new FhirClientSettings
                {
                    PreferredParameterHandling = SearchParameterHandling.Lenient,
                    PreferredReturn = Prefer.ReturnMinimal,
                    PreferredFormat = ResourceFormat.Json,
                    UseFormatParameter = false
                };
            }
        }

        #region EntryRequest To Http

        [TestMethod]
        public void TestPreferSetting()
        {
            var entry = _Entry;

            var settings = _Settings;

            var request = entry.ToHttpRequest(_endpoint, settings);
            Assert.AreEqual("return=minimal", request.Headers["Prefer"]);

            settings.PreferredReturn = Prefer.RespondAsync;
            request = entry.ToHttpRequest(_endpoint, settings);
            Assert.AreEqual("respond-async", request.Headers["Prefer"]);
            
            settings.PreferredReturn = null;
            request = entry.ToHttpRequest(_endpoint, settings);
            Assert.IsNull(request.Headers["Prefer"]);

            entry.Type = InteractionType.Search;
            settings.PreferredReturn = Prefer.OperationOutcome;
            request = entry.ToHttpRequest(_endpoint, settings);
            Assert.AreEqual("handling=lenient", request.Headers["Prefer"]);
            
            settings.PreferredReturn = Prefer.RespondAsync;
            request = entry.ToHttpRequest(_endpoint, settings);
            Assert.AreEqual("handling=lenient, respond-async", request.Headers["Prefer"]);
            
            settings.PreferredReturn = Prefer.ReturnRepresentation;
            settings.PreferredParameterHandling = null;
            request = entry.ToHttpRequest(_endpoint, settings);
            Assert.IsNull(request.Headers["Prefer"]);
        }

        [TestMethod]
        public void TestRequestedBodyContent()
        {
            var entry = _Entry;
            entry.RequestBodyContent = Encoding.UTF8.GetBytes("Test body");
            var settings = _Settings;
            
            ExceptionAssert.Throws<InvalidOperationException>(() => entry.ToHttpRequest(_endpoint, settings));
            
            entry.Method = HTTPVerb.POST;
            var request = entry.ToHttpRequest(_endpoint, settings);
        }

        [TestMethod]
        public void TestFormatParameters()
        {
            var entry = _Entry;

            var settings = _Settings;

            var request = entry.ToHttpRequest(_endpoint, settings);
            Assert.AreEqual("application/fhir+json;charset=utf-8", request.Accept);

            settings.UseFormatParameter = true;
            request = entry.ToHttpRequest(_endpoint, settings);
            Assert.IsTrue(request.RequestUri.ToString().Contains("_format=json"));
        }

        [TestMethod]
        public void TestEntryRequestHeaders()
        {
            var entry = _Entry;
            entry.Headers = new EntryRequestHeaders
            {
                IfMatch = "Test-IfMatch",
                IfModifiedSince = new DateTimeOffset(new DateTime(2012, 01, 01), new TimeSpan()),
                IfNoneExist = "Test-IfNoneExists",
                IfNoneMatch = "Test-IfNoneMatch"
            };

            var settings = _Settings;

            var request = entry.ToHttpRequest(_endpoint, settings);
            Assert.AreEqual("Test-IfMatch", request.Headers["If-Match"]);
            Assert.AreEqual(entry.Headers.IfModifiedSince.Value.UtcDateTime.ToString("r"), request.Headers["If-Modified-Since"]);
            Assert.AreEqual("Test-IfNoneExists", request.Headers["If-None-Exist"]);
            Assert.AreEqual("Test-IfNoneMatch", request.Headers["If-None-Match"]);
        }

        [TestMethod]
        public void TestSetAgent()
        {
            var entry = _Entry;
            entry.Agent = "testAgent";
            var settings = _Settings;

            var request = entry.ToHttpRequest(_endpoint, settings);
            Assert.AreEqual(".NET FhirClient for FHIR testAgent", request.UserAgent);

            EntryToHttpExtensions.SetUserAgentUsingReflection = false;
            request = entry.ToHttpRequest(_endpoint, settings);
            Assert.AreEqual(".NET FhirClient for FHIR testAgent", request.UserAgent);

            EntryToHttpExtensions.SetUserAgentUsingReflection = true;
        }

        #endregion

        #region Bundle.EntryComponent To EntryRequest

        [TestMethod]
        public void TestBundleToEntryRequest()
        {
            var bundleComponent = new Bundle.EntryComponent
            {
                Request = new Bundle.RequestComponent
                {
                    Method = Bundle.HTTPVerb.GET,
                    Url = "test/Url",
                    IfMatch = "test-ifMatch",
                    IfNoneExist = "test-ifNoneExists",
                    IfNoneMatch = "test-ifNoneMatch",
                    IfModifiedSince = new DateTimeOffset(new DateTime(2012, 01, 01), new TimeSpan())
                }
            };
            bundleComponent.AddAnnotation(InteractionType.Search);

            var entryRequest = bundleComponent.ToEntryRequest(_Settings);

            Assert.IsNotNull(entryRequest);
            Assert.AreEqual(bundleComponent.Request.Url, entryRequest.Url);
            Assert.AreEqual(bundleComponent.Request.Method, (Bundle.HTTPVerb)entryRequest.Method);
            Assert.AreEqual(bundleComponent.Request.IfMatch, entryRequest.Headers.IfMatch);
            Assert.AreEqual(bundleComponent.Request.IfModifiedSince, entryRequest.Headers.IfModifiedSince);
            Assert.AreEqual(bundleComponent.Request.IfNoneExist, entryRequest.Headers.IfNoneExist);
            Assert.AreEqual(bundleComponent.Request.IfNoneMatch, entryRequest.Headers.IfNoneMatch);
            Assert.AreEqual(InteractionType.Search, entryRequest.Type);
            Assert.IsNull(entryRequest.RequestBodyContent);
        }

        [TestMethod]
        public void TestBundleToEntryRequestBody()
        {
            var bundleComponent = new Bundle.EntryComponent
            {
                Resource = new Binary
                {
                    Content = Encoding.UTF8.GetBytes("test body"),
                    ContentType = "test content type"
                },
                Request = new Bundle.RequestComponent
                {
                    //Method = Bundle.HTTPVerb.GET
                }
            };
            bundleComponent.AddAnnotation(InteractionType.Search);

            var entryRequest = bundleComponent.ToEntryRequest(_Settings);
            Assert.IsNotNull(entryRequest);
            Assert.IsNotNull(entryRequest.RequestBodyContent);
            Assert.AreEqual("test content type", entryRequest.ContentType);
            Assert.AreEqual("test body", Encoding.UTF8.GetString(entryRequest.RequestBodyContent));
        }

        #endregion

        #region EntryResponse To TypedEntryResponse

        [TestMethod]
        public void TestToTypedEntryResponse()
        {
            var xml = "<Patient xmlns=\"http://hl7.org/fhi\"><active value=\"true\" /></Patient>";
            var response = new EntryResponse
            {
                ContentType = "text/xml; charset=us-ascii",
                Etag = "Test-Etag",
                LastModified = new DateTimeOffset(new DateTime(2012, 01, 01), new TimeSpan()),
                Location = "Test-Location",
                ResponseUri = new Uri("http://www.myserver.com"),
                Status = "200",
                Headers = new Dictionary<string, string>() { { "Test-key", "Test-value" } },
                Body = Encoding.UTF8.GetBytes(xml),
            };

            var result = response.ToTypedEntryResponse(new Fhir.Serialization.ParserSettings(), new PocoStructureDefinitionSummaryProvider());

            var typedElementXml = result.TypedElement.ToXml();
            Assert.AreEqual(xml, typedElementXml);
            Assert.AreEqual(response.ContentType, result.ContentType);
            Assert.AreEqual(response.Etag, result.Etag);
            Assert.AreEqual(response.LastModified, result.LastModified);
            Assert.AreEqual(response.Location, result.Location);
            Assert.AreEqual(response.ResponseUri, result.ResponseUri);
            Assert.AreEqual(response.Status, result.Status);
            Assert.AreEqual(response.GetBodyAsText(), result.GetBodyAsText());
            Assert.AreEqual(response.Headers["Test-key"], result.Headers["Test-key"]);
        }

        #endregion
    }
}
 