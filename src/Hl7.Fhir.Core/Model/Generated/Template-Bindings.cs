// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0-snapshot1

using Hl7.Fhir.Utility;

/*
  Copyright (c) 2011+, HL7, Inc.
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

namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Indication of the degree of conformance expectations associated with a binding.
    /// (url: http://hl7.org/fhir/ValueSet/binding-strength)
    /// (system: http://hl7.org/fhir/binding-strength)
    /// </summary>
    [FhirEnumeration("BindingStrength")]
    public enum BindingStrength
    {
        /// <summary>
        /// To be conformant, the concept in this element SHALL be from the specified value set.
        /// (system: http://hl7.org/fhir/binding-strength)
        /// </summary>
        [EnumLiteral("required", "http://hl7.org/fhir/binding-strength"), Description("Required")]
        Required,
        /// <summary>
        /// To be conformant, the concept in this element SHALL be from the specified value set if any of the codes within the value set can apply to the concept being communicated.  If the value set does not cover the concept (based on human review), alternate codings (or, data type allowing, text) may be included instead.
        /// (system: http://hl7.org/fhir/binding-strength)
        /// </summary>
        [EnumLiteral("extensible", "http://hl7.org/fhir/binding-strength"), Description("Extensible")]
        Extensible,
        /// <summary>
        /// Instances are encouraged to draw from the specified codes for interoperability purposes but are not required to do so to be considered conformant.
        /// (system: http://hl7.org/fhir/binding-strength)
        /// </summary>
        [EnumLiteral("preferred", "http://hl7.org/fhir/binding-strength"), Description("Preferred")]
        Preferred,
        /// <summary>
        /// Instances are not expected or even encouraged to draw from the specified value set.  The value set merely provides examples of the types of concepts intended to be included.
        /// (system: http://hl7.org/fhir/binding-strength)
        /// </summary>
        [EnumLiteral("example", "http://hl7.org/fhir/binding-strength"), Description("Example")]
        Example,
    }

    /// <summary>
    /// How a capability statement is intended to be used.
    /// (url: http://hl7.org/fhir/ValueSet/capability-statement-kind)
    /// (system: http://hl7.org/fhir/capability-statement-kind)
    /// </summary>
    [FhirEnumeration("CapabilityStatementKind")]
    public enum CapabilityStatementKind
    {
        /// <summary>
        /// The CapabilityStatement instance represents the present capabilities of a specific system instance.  This is the kind returned by /metadata for a FHIR server end-point.
        /// (system: http://hl7.org/fhir/capability-statement-kind)
        /// </summary>
        [EnumLiteral("instance", "http://hl7.org/fhir/capability-statement-kind"), Description("Instance")]
        Instance,
        /// <summary>
        /// The CapabilityStatement instance represents the capabilities of a system or piece of software, independent of a particular installation.
        /// (system: http://hl7.org/fhir/capability-statement-kind)
        /// </summary>
        [EnumLiteral("capability", "http://hl7.org/fhir/capability-statement-kind"), Description("Capability")]
        Capability,
        /// <summary>
        /// The CapabilityStatement instance represents a set of requirements for other systems to meet; e.g. as part of an implementation guide or 'request for proposal'.
        /// (system: http://hl7.org/fhir/capability-statement-kind)
        /// </summary>
        [EnumLiteral("requirements", "http://hl7.org/fhir/capability-statement-kind"), Description("Requirements")]
        Requirements,
    }


    /// <summary>
    /// All published FHIR Versions.
    /// (url: http://hl7.org/fhir/ValueSet/FHIR-version)
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [FhirEnumeration("FHIRVersion")]
    public enum FHIRVersion
    {
        /// <summary>
        /// Oldest archived version of FHIR.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.01", "http://hl7.org/fhir/FHIR-version"), Description("0.01")]
        N0_01,
        /// <summary>
        /// 1st Draft for Comment (Sept 2012 Ballot).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.05", "http://hl7.org/fhir/FHIR-version"), Description("0.05")]
        N0_05,
        /// <summary>
        /// 2nd Draft for Comment (January 2013 Ballot).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.06", "http://hl7.org/fhir/FHIR-version"), Description("0.06")]
        N0_06,
        /// <summary>
        /// DSTU 1 Ballot version.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.11", "http://hl7.org/fhir/FHIR-version"), Description("0.11")]
        N0_11,
        /// <summary>
        /// DSTU 1 Official version.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.0.80", "http://hl7.org/fhir/FHIR-version"), Description("0.0.80")]
        N0_0_80,
        /// <summary>
        /// DSTU 1 Official version Technical Errata #1.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.0.81", "http://hl7.org/fhir/FHIR-version"), Description("0.0.81")]
        N0_0_81,
        /// <summary>
        /// DSTU 1 Official version Technical Errata #2.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.0.82", "http://hl7.org/fhir/FHIR-version"), Description("0.0.82")]
        N0_0_82,
        /// <summary>
        /// Draft For Comment (January 2015 Ballot).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.4.0", "http://hl7.org/fhir/FHIR-version"), Description("0.4.0")]
        N0_4_0,
        /// <summary>
        /// DSTU 2 Ballot version (May 2015 Ballot).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("0.5.0", "http://hl7.org/fhir/FHIR-version"), Description("0.5.0")]
        N0_5_0,
        /// <summary>
        /// DSTU 2 QA Preview + CQIF Ballot (Sep 2015).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("1.0.0", "http://hl7.org/fhir/FHIR-version"), Description("1.0.0")]
        N1_0_0,
        /// <summary>
        /// DSTU 2 (Official version).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("1.0.1", "http://hl7.org/fhir/FHIR-version"), Description("1.0.1")]
        N1_0_1,
        /// <summary>
        /// DSTU 2 (Official version) with 1 technical errata.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("1.0.2", "http://hl7.org/fhir/FHIR-version"), Description("1.0.2")]
        N1_0_2,
        /// <summary>
        /// GAO Ballot + draft changes to main FHIR standard.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("1.1.0", "http://hl7.org/fhir/FHIR-version"), Description("1.1.0")]
        N1_1_0,
        /// <summary>
        /// CQF on FHIR Ballot + Connectathon 12 (Montreal).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("1.4.0", "http://hl7.org/fhir/FHIR-version"), Description("1.4.0")]
        N1_4_0,
        /// <summary>
        /// FHIR STU3 Ballot + Connectathon 13 (Baltimore).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("1.6.0", "http://hl7.org/fhir/FHIR-version"), Description("1.6.0")]
        N1_6_0,
        /// <summary>
        /// FHIR STU3 Candidate + Connectathon 14 (San Antonio).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("1.8.0", "http://hl7.org/fhir/FHIR-version"), Description("1.8.0")]
        N1_8_0,
        /// <summary>
        /// FHIR Release 3 (STU).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("3.0.0", "http://hl7.org/fhir/FHIR-version"), Description("3.0.0")]
        N3_0_0,
        /// <summary>
        /// FHIR Release 3 (STU) with 1 technical errata.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("3.0.1", "http://hl7.org/fhir/FHIR-version"), Description("3.0.1")]
        N3_0_1,
        /// <summary>
        /// FHIR Release 3 (STU) with 2 technical errata.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("3.0.2", "http://hl7.org/fhir/FHIR-version"), Description("3.0.2")]
        N3_0_2,
        /// <summary>
        /// R4 Ballot #1.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("3.3.0", "http://hl7.org/fhir/FHIR-version"), Description("3.3.0")]
        N3_3_0,
        /// <summary>
        /// R4 Ballot #2.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("3.5.0", "http://hl7.org/fhir/FHIR-version"), Description("3.5.0")]
        N3_5_0,
        /// <summary>
        /// FHIR Release 4 (Normative + STU).
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.0.0", "http://hl7.org/fhir/FHIR-version"), Description("4.0.0")]
        N4_0_0,
        /// <summary>
        /// FHIR Release 4 (Normative + STU) with 1 technical errata.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.0.1", "http://hl7.org/fhir/FHIR-version"), Description("4.0.1")]
        N4_0_1,
        /// <summary>
        /// Interim Version.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.1.0", "http://hl7.org/fhir/FHIR-version"), Description("4.1.0")]
        N4_1_0,
        /// <summary>
        /// R5 Preview #1.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.2.0", "http://hl7.org/fhir/FHIR-version"), Description("4.2.0")]
        N4_2_0,
        /// <summary>
        /// R4B Snapshot #1.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.3.0-snapshot1", "http://hl7.org/fhir/FHIR-version"), Description("4.3.0-snapshot1")]
        N4_3_0Snapshot1,
        /// <summary>
        /// R4B Rolling CI-Build.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.3.0-cibuild", "http://hl7.org/fhir/FHIR-version"), Description("4.3.0-cibuild")]
        N4_3_0Cibuild,
        /// <summary>
        /// R5 Preview #2.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.4.0", "http://hl7.org/fhir/FHIR-version"), Description("4.4.0")]
        N4_4_0,
        /// <summary>
        /// R5 Preview #3.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.5.0", "http://hl7.org/fhir/FHIR-version"), Description("4.5.0")]
        N4_5_0,
        /// <summary>
        /// R5 Draft Ballot.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("4.6.0", "http://hl7.org/fhir/FHIR-version"), Description("4.6.0")]
        N4_6_0,
        /// <summary>
        /// R5 Snapshot #1.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("5.0.0-snapshot1", "http://hl7.org/fhir/FHIR-version"), Description("5.0.0-snapshot1")]
        N5_0_0Snapshot1,
        /// <summary>
        /// R5 Rolling CI-Build.
        /// (system: http://hl7.org/fhir/FHIR-version)
        /// </summary>
        [EnumLiteral("5.0.0-cibuild", "http://hl7.org/fhir/FHIR-version"), Description("5.0.0-cibuild")]
        N5_0_0Cibuild,
    }

    /// <summary>
    /// Data types allowed to be used for search parameters.
    /// (url: http://hl7.org/fhir/ValueSet/search-param-type)
    /// (system: http://hl7.org/fhir/search-param-type)
    /// </summary>
    [FhirEnumeration("SearchParamType")]
    public enum SearchParamType
    {
        /// <summary>
        /// Search parameter SHALL be a number (a whole number, or a decimal).
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("number", "http://hl7.org/fhir/search-param-type"), Description("Number")]
        Number,
        /// <summary>
        /// Search parameter is on a date/time. The date format is the standard XML format, though other formats may be supported.
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("date", "http://hl7.org/fhir/search-param-type"), Description("Date/DateTime")]
        Date,
        /// <summary>
        /// Search parameter is a simple string, like a name part. Search is case-insensitive and accent-insensitive. May match just the start of a string. String parameters may contain spaces.
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("string", "http://hl7.org/fhir/search-param-type"), Description("String")]
        String,
        /// <summary>
        /// Search parameter on a coded element or identifier. May be used to search through the text, display, code and code/codesystem (for codes) and label, system and key (for identifier). Its value is either a string or a pair of namespace and value, separated by a "|", depending on the modifier used.
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("token", "http://hl7.org/fhir/search-param-type"), Description("Token")]
        Token,
        /// <summary>
        /// A reference to another resource (Reference or canonical).
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("reference", "http://hl7.org/fhir/search-param-type"), Description("Reference")]
        Reference,
        /// <summary>
        /// A composite search parameter that combines a search on two values together.
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("composite", "http://hl7.org/fhir/search-param-type"), Description("Composite")]
        Composite,
        /// <summary>
        /// A search parameter that searches on a quantity.
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("quantity", "http://hl7.org/fhir/search-param-type"), Description("Quantity")]
        Quantity,
        /// <summary>
        /// A search parameter that searches on a URI (RFC 3986).
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("uri", "http://hl7.org/fhir/search-param-type"), Description("URI")]
        Uri,
        /// <summary>
        /// Special logic applies to this parameter per the description of the search parameter.
        /// (system: http://hl7.org/fhir/search-param-type)
        /// </summary>
        [EnumLiteral("special", "http://hl7.org/fhir/search-param-type"), Description("Special")]
        Special,
    }

    /// <summary>
    /// The mode of a RESTful capability statement.
    /// (url: http://hl7.org/fhir/ValueSet/restful-capability-mode)
    /// (system: http://hl7.org/fhir/restful-capability-mode)
    /// </summary>
    [FhirEnumeration("RestfulCapabilityMode")]
    public enum RestfulCapabilityMode
    {
        /// <summary>
        /// The application acts as a client for this resource.
        /// (system: http://hl7.org/fhir/restful-capability-mode)
        /// </summary>
        [EnumLiteral("client", "http://hl7.org/fhir/restful-capability-mode"), Description("Client")]
        Client,
        /// <summary>
        /// The application acts as a server for this resource.
        /// (system: http://hl7.org/fhir/restful-capability-mode)
        /// </summary>
        [EnumLiteral("server", "http://hl7.org/fhir/restful-capability-mode"), Description("Server")]
        Server,
    }

    /// <summary>
    /// Operations supported by REST at the type or instance level.
    /// (url: http://hl7.org/fhir/ValueSet/type-restful-interaction)
    /// (system: http://hl7.org/fhir/restful-interaction)
    /// </summary>
    [FhirEnumeration("TypeRestfulInteraction")]
    public enum TypeRestfulInteraction
    {
        /// <summary>
        /// Read the current state of the resource.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("read", "http://hl7.org/fhir/restful-interaction"), Description("read")]
        Read,
        /// <summary>
        /// Read the state of a specific version of the resource.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("vread", "http://hl7.org/fhir/restful-interaction"), Description("vread")]
        Vread,
        /// <summary>
        /// Update an existing resource by its id (or create it if it is new).
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("update", "http://hl7.org/fhir/restful-interaction"), Description("update")]
        Update,
        /// <summary>
        /// Update an existing resource by posting a set of changes to it.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("patch", "http://hl7.org/fhir/restful-interaction"), Description("patch")]
        Patch,
        /// <summary>
        /// Delete a resource.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("delete", "http://hl7.org/fhir/restful-interaction"), Description("delete")]
        Delete,
        /// <summary>
        /// Retrieve the change history for a particular resource.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("history-instance", "http://hl7.org/fhir/restful-interaction"), Description("history-instance")]
        HistoryInstance,
        /// <summary>
        /// Retrieve the change history for all resources of a particular type.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("history-type", "http://hl7.org/fhir/restful-interaction"), Description("history-type")]
        HistoryType,
        /// <summary>
        /// Create a new resource with a server assigned id.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("create", "http://hl7.org/fhir/restful-interaction"), Description("create")]
        Create,
        /// <summary>
        /// Search all resources of the specified type based on some filter criteria.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("search-type", "http://hl7.org/fhir/restful-interaction"), Description("search-type")]
        SearchType,
    }

    /// <summary>
    /// Operations supported by REST at the system level.
    /// (url: http://hl7.org/fhir/ValueSet/system-restful-interaction)
    /// (system: http://hl7.org/fhir/restful-interaction)
    /// </summary>
    [FhirEnumeration("SystemRestfulInteraction")]
    public enum SystemRestfulInteraction
    {
        /// <summary>
        /// Update, create or delete a set of resources as a single transaction.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("transaction", "http://hl7.org/fhir/restful-interaction"), Description("transaction")]
        Transaction,
        /// <summary>
        /// perform a set of a separate interactions in a single http operation
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("batch", "http://hl7.org/fhir/restful-interaction"), Description("batch")]
        Batch,
        /// <summary>
        /// Search all resources based on some filter criteria.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("search-system", "http://hl7.org/fhir/restful-interaction"), Description("search-system")]
        SearchSystem,
        /// <summary>
        /// Retrieve the change history for all resources on a system.
        /// (system: http://hl7.org/fhir/restful-interaction)
        /// </summary>
        [EnumLiteral("history-system", "http://hl7.org/fhir/restful-interaction"), Description("history-system")]
        HistorySystem,
    }
}

