/*
  Copyright (c) 2011-2012, HL7, Inc
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

#nullable enable

using Hl7.Fhir.Introspection;
using System;

namespace Hl7.Fhir.Model
{
    public partial class ModelInfoNEW
    {
        public static readonly Uri FhirCoreProfileBaseUri = new(@"http://hl7.org/fhir/StructureDefinition/");
        public static Canonical CanonicalUriForFhirCoreType(string typename) => new(FhirCoreProfileBaseUri.OriginalString + typename);

        #region TODO
        public static bool IsInstanceTypeFor(string superclass, string subclass) => true;
        public static bool IsInstanceTypeFor(FHIRAllTypes superclass, FHIRAllTypes subclass) => true;
        public static FHIRAllTypes? FhirTypeNameToFhirType(string typeName) => null;

        public static string? FhirTypeToFhirTypeName(FHIRAllTypes type) => null;


        public static ResourceType? FhirTypeNameToResourceType(string typeName) => null;

        public static bool IsDataType(string name) => true;

        public static bool IsPrimitive(string name) => true;

        public static bool IsCoreModelType(string name) => true;
        #endregion

        public static string? GetFhirTypeNameForType(Type type)
        {
            var inspector = ModelInspector.ForAssembly(type.Assembly);
            var mapping = inspector.FindClassMapping(type);
            return mapping?.Name;
        }

        public static bool IsPrimitive(Type type)
        {
            var inspector = ModelInspector.ForAssembly(type.Assembly);
            var mapping = inspector.FindClassMapping(type);
            return mapping?.IsPrimitive ?? false;
        }

        public static bool IsBindable(string type)
            => type switch
            {
                // This is the fixed list, for all FHIR versions
                "code" or "Coding" or "CodeableConcept" or "Quantity" or "string" or "uri" or "Extension" => true,
                _ => false,
            };

        // Used in ArtifactSummary. Do we still want to support that?
        public static bool IsConformanceResource(string name) => true;
        public static bool IsConformanceResource(ResourceType? type) => true;
    }
}
#nullable restore