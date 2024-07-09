// <auto-generated/>
// Contents of: hl7.fhir.r5.expansions#5.0.0, hl7.fhir.r5.core#5.0.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;
using SystemPrimitive = Hl7.Fhir.ElementModel.Types;

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
  /// The technical details of an endpoint that can be used for electronic services
  /// </summary>
  /// <remarks>
  /// The technical details of an endpoint that can be used for electronic services, such as for web services providing XDS.b, a REST endpoint for another FHIR server, or a s/Mime email address. This may include any security context information.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("Endpoint","http://hl7.org/fhir/StructureDefinition/Endpoint", IsResource=true)]
  public partial class Endpoint : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Endpoint"; } }

    /// <summary>
    /// The status of the endpoint.
    /// (url: http://hl7.org/fhir/ValueSet/endpoint-status)
    /// (system: http://hl7.org/fhir/endpoint-status)
    /// </summary>
    [FhirEnumeration("EndpointStatus", "http://hl7.org/fhir/ValueSet/endpoint-status", "http://hl7.org/fhir/endpoint-status")]
    public enum EndpointStatus
    {
      /// <summary>
      /// This endpoint is expected to be active and can be used.
      /// (system: http://hl7.org/fhir/endpoint-status)
      /// </summary>
      [EnumLiteral("active"), Description("Active")]
      Active,
      /// <summary>
      /// This endpoint is temporarily unavailable.
      /// (system: http://hl7.org/fhir/endpoint-status)
      /// </summary>
      [EnumLiteral("suspended"), Description("Suspended")]
      Suspended,
      /// <summary>
      /// This endpoint has exceeded connectivity thresholds and is considered in an error state and should no longer be attempted to connect to until corrective action is taken.
      /// (system: http://hl7.org/fhir/endpoint-status)
      /// </summary>
      [EnumLiteral("error"), Description("Error")]
      Error,
      /// <summary>
      /// This endpoint is no longer to be used.
      /// (system: http://hl7.org/fhir/endpoint-status)
      /// </summary>
      [EnumLiteral("off"), Description("Off")]
      Off,
      /// <summary>
      /// This instance should not have been part of this patient's medical record.
      /// (system: http://hl7.org/fhir/endpoint-status)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in error")]
      EnteredInError,
    }

    /// <summary>
    /// Set of payloads that are provided by this endpoint
    /// </summary>
    /// <remarks>
    /// The set of payloads that are provided/available at this endpoint.
    /// Note that not all mimetypes or types will be listed under the one endpoint resource, there may be multiple instances that information for cases where other header data such as the endpoint address, active status/period etc. is different.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("Endpoint#Payload", IsNestedType=true)]
    [BackboneType("Endpoint.payload")]
    public partial class PayloadComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Endpoint#Payload"; } }

      /// <summary>
      /// The type of content that may be used at this endpoint (e.g. XDS Discharge summaries)
      /// </summary>
      [FhirElement("type", InSummary=true, Order=40)]
      [Binding("PayloadType")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> Type
      {
        get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _Type;

      /// <summary>
      /// Mimetype to send. If not specified, the content could be anything (including no payload, if the connectionType defined this)
      /// </summary>
      [FhirElement("mimeType", InSummary=true, Order=50)]
      [Binding("MimeType")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.Code> MimeTypeElement
      {
        get { if(_MimeTypeElement==null) _MimeTypeElement = new List<Hl7.Fhir.Model.Code>(); return _MimeTypeElement; }
        set { _MimeTypeElement = value; OnPropertyChanged("MimeTypeElement"); }
      }

      private List<Hl7.Fhir.Model.Code> _MimeTypeElement;

      /// <summary>
      /// Mimetype to send. If not specified, the content could be anything (including no payload, if the connectionType defined this)
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public IEnumerable<string> MimeType
      {
        get { return MimeTypeElement != null ? MimeTypeElement.Select(elem => elem.Value) : null; }
        set
        {
          if (value == null)
            MimeTypeElement = null;
          else
            MimeTypeElement = new List<Hl7.Fhir.Model.Code>(value.Select(elem=>new Hl7.Fhir.Model.Code(elem)));
          OnPropertyChanged("MimeType");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as PayloadComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Type.Any()) dest.Type = new List<Hl7.Fhir.Model.CodeableConcept>(Type.DeepCopy());
        if(MimeTypeElement.Any()) dest.MimeTypeElement = new List<Hl7.Fhir.Model.Code>(MimeTypeElement.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new PayloadComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as PayloadComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;
        if( !DeepComparable.Matches(MimeTypeElement, otherT.MimeTypeElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as PayloadComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
        if( !DeepComparable.IsExactly(MimeTypeElement, otherT.MimeTypeElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          foreach (var elem in Type) { if (elem != null) yield return elem; }
          foreach (var elem in MimeTypeElement) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
          foreach (var elem in MimeTypeElement) { if (elem != null) yield return new ElementValue("mimeType", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "type":
            value = Type;
            return Type?.Any() == true;
          case "mimeType":
            value = MimeTypeElement;
            return MimeTypeElement?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Type?.Any() == true) yield return new KeyValuePair<string,object>("type",Type);
        if (MimeTypeElement?.Any() == true) yield return new KeyValuePair<string,object>("mimeType",MimeTypeElement);
      }

    }

    /// <summary>
    /// Identifies this endpoint across multiple systems
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// active | suspended | error | off | entered-in-error | test
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("EndpointStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.Endpoint.EndpointStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.Endpoint.EndpointStatus> _StatusElement;

    /// <summary>
    /// active | suspended | error | off | entered-in-error | test
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.Endpoint.EndpointStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Protocol/Profile/Standard to be used with this endpoint connection
    /// </summary>
    [FhirElement("connectionType", InSummary=true, Order=110, FiveWs="FiveWs.class")]
    [Binding("endpoint-contype")]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ConnectionType
    {
      get { if(_ConnectionType==null) _ConnectionType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ConnectionType; }
      set { _ConnectionType = value; OnPropertyChanged("ConnectionType"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ConnectionType;

    /// <summary>
    /// A name that this endpoint can be identified by
    /// </summary>
    [FhirElement("name", InSummary=true, Order=120, FiveWs="FiveWs.what[x]")]
    [DataMember]
    public Hl7.Fhir.Model.FhirString NameElement
    {
      get { return _NameElement; }
      set { _NameElement = value; OnPropertyChanged("NameElement"); }
    }

    private Hl7.Fhir.Model.FhirString _NameElement;

    /// <summary>
    /// A name that this endpoint can be identified by
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Name
    {
      get { return NameElement != null ? NameElement.Value : null; }
      set
      {
        if (value == null)
          NameElement = null;
        else
          NameElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Name");
      }
    }

    /// <summary>
    /// Additional details about the endpoint that could be displayed as further information to identify the description beyond its name
    /// </summary>
    [FhirElement("description", InSummary=true, Order=130)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DescriptionElement
    {
      get { return _DescriptionElement; }
      set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DescriptionElement;

    /// <summary>
    /// Additional details about the endpoint that could be displayed as further information to identify the description beyond its name
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Description
    {
      get { return DescriptionElement != null ? DescriptionElement.Value : null; }
      set
      {
        if (value == null)
          DescriptionElement = null;
        else
          DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Description");
      }
    }

    /// <summary>
    /// The type of environment(s) exposed at this endpoint
    /// </summary>
    [FhirElement("environmentType", InSummary=true, Order=140)]
    [Binding("endpoint-environment-type")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> EnvironmentType
    {
      get { if(_EnvironmentType==null) _EnvironmentType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _EnvironmentType; }
      set { _EnvironmentType = value; OnPropertyChanged("EnvironmentType"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _EnvironmentType;

    /// <summary>
    /// Organization that manages this endpoint (might not be the organization that exposes the endpoint)
    /// </summary>
    [FhirElement("managingOrganization", InSummary=true, Order=150)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference ManagingOrganization
    {
      get { return _ManagingOrganization; }
      set { _ManagingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
    }

    private Hl7.Fhir.Model.ResourceReference _ManagingOrganization;

    /// <summary>
    /// Contact details for source (e.g. troubleshooting)
    /// </summary>
    [FhirElement("contact", Order=160)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ContactPoint> Contact
    {
      get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ContactPoint>(); return _Contact; }
      set { _Contact = value; OnPropertyChanged("Contact"); }
    }

    private List<Hl7.Fhir.Model.ContactPoint> _Contact;

    /// <summary>
    /// Interval the endpoint is expected to be operational
    /// </summary>
    [FhirElement("period", InSummary=true, Order=170, FiveWs="FiveWs.done[x]")]
    [DataMember]
    public Hl7.Fhir.Model.Period Period
    {
      get { return _Period; }
      set { _Period = value; OnPropertyChanged("Period"); }
    }

    private Hl7.Fhir.Model.Period _Period;

    /// <summary>
    /// Set of payloads that are provided by this endpoint
    /// </summary>
    [FhirElement("payload", Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Endpoint.PayloadComponent> Payload
    {
      get { if(_Payload==null) _Payload = new List<Hl7.Fhir.Model.Endpoint.PayloadComponent>(); return _Payload; }
      set { _Payload = value; OnPropertyChanged("Payload"); }
    }

    private List<Hl7.Fhir.Model.Endpoint.PayloadComponent> _Payload;

    /// <summary>
    /// The technical base address for connecting to this endpoint
    /// </summary>
    [FhirElement("address", InSummary=true, Order=190)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.FhirUrl AddressElement
    {
      get { return _AddressElement; }
      set { _AddressElement = value; OnPropertyChanged("AddressElement"); }
    }

    private Hl7.Fhir.Model.FhirUrl _AddressElement;

    /// <summary>
    /// The technical base address for connecting to this endpoint
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Address
    {
      get { return AddressElement != null ? AddressElement.Value : null; }
      set
      {
        if (value == null)
          AddressElement = null;
        else
          AddressElement = new Hl7.Fhir.Model.FhirUrl(value);
        OnPropertyChanged("Address");
      }
    }

    /// <summary>
    /// Usage depends on the channel type
    /// </summary>
    [FhirElement("header", Order=200)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.FhirString> HeaderElement
    {
      get { if(_HeaderElement==null) _HeaderElement = new List<Hl7.Fhir.Model.FhirString>(); return _HeaderElement; }
      set { _HeaderElement = value; OnPropertyChanged("HeaderElement"); }
    }

    private List<Hl7.Fhir.Model.FhirString> _HeaderElement;

    /// <summary>
    /// Usage depends on the channel type
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public IEnumerable<string> Header
    {
      get { return HeaderElement != null ? HeaderElement.Select(elem => elem.Value) : null; }
      set
      {
        if (value == null)
          HeaderElement = null;
        else
          HeaderElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
        OnPropertyChanged("Header");
      }
    }

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Endpoint;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>)StatusElement.DeepCopy();
      if(ConnectionType.Any()) dest.ConnectionType = new List<Hl7.Fhir.Model.CodeableConcept>(ConnectionType.DeepCopy());
      if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
      if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
      if(EnvironmentType.Any()) dest.EnvironmentType = new List<Hl7.Fhir.Model.CodeableConcept>(EnvironmentType.DeepCopy());
      if(ManagingOrganization != null) dest.ManagingOrganization = (Hl7.Fhir.Model.ResourceReference)ManagingOrganization.DeepCopy();
      if(Contact.Any()) dest.Contact = new List<Hl7.Fhir.Model.ContactPoint>(Contact.DeepCopy());
      if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
      if(Payload.Any()) dest.Payload = new List<Hl7.Fhir.Model.Endpoint.PayloadComponent>(Payload.DeepCopy());
      if(AddressElement != null) dest.AddressElement = (Hl7.Fhir.Model.FhirUrl)AddressElement.DeepCopy();
      if(HeaderElement.Any()) dest.HeaderElement = new List<Hl7.Fhir.Model.FhirString>(HeaderElement.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Endpoint());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Endpoint;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(ConnectionType, otherT.ConnectionType)) return false;
      if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.Matches(EnvironmentType, otherT.EnvironmentType)) return false;
      if( !DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
      if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
      if( !DeepComparable.Matches(Period, otherT.Period)) return false;
      if( !DeepComparable.Matches(Payload, otherT.Payload)) return false;
      if( !DeepComparable.Matches(AddressElement, otherT.AddressElement)) return false;
      if( !DeepComparable.Matches(HeaderElement, otherT.HeaderElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Endpoint;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(ConnectionType, otherT.ConnectionType)) return false;
      if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.IsExactly(EnvironmentType, otherT.EnvironmentType)) return false;
      if( !DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
      if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
      if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
      if( !DeepComparable.IsExactly(Payload, otherT.Payload)) return false;
      if( !DeepComparable.IsExactly(AddressElement, otherT.AddressElement)) return false;
      if( !DeepComparable.IsExactly(HeaderElement, otherT.HeaderElement)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        foreach (var elem in ConnectionType) { if (elem != null) yield return elem; }
        if (NameElement != null) yield return NameElement;
        if (DescriptionElement != null) yield return DescriptionElement;
        foreach (var elem in EnvironmentType) { if (elem != null) yield return elem; }
        if (ManagingOrganization != null) yield return ManagingOrganization;
        foreach (var elem in Contact) { if (elem != null) yield return elem; }
        if (Period != null) yield return Period;
        foreach (var elem in Payload) { if (elem != null) yield return elem; }
        if (AddressElement != null) yield return AddressElement;
        foreach (var elem in HeaderElement) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        foreach (var elem in ConnectionType) { if (elem != null) yield return new ElementValue("connectionType", elem); }
        if (NameElement != null) yield return new ElementValue("name", NameElement);
        if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        foreach (var elem in EnvironmentType) { if (elem != null) yield return new ElementValue("environmentType", elem); }
        if (ManagingOrganization != null) yield return new ElementValue("managingOrganization", ManagingOrganization);
        foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
        if (Period != null) yield return new ElementValue("period", Period);
        foreach (var elem in Payload) { if (elem != null) yield return new ElementValue("payload", elem); }
        if (AddressElement != null) yield return new ElementValue("address", AddressElement);
        foreach (var elem in HeaderElement) { if (elem != null) yield return new ElementValue("header", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "connectionType":
          value = ConnectionType;
          return ConnectionType?.Any() == true;
        case "name":
          value = NameElement;
          return NameElement is not null;
        case "description":
          value = DescriptionElement;
          return DescriptionElement is not null;
        case "environmentType":
          value = EnvironmentType;
          return EnvironmentType?.Any() == true;
        case "managingOrganization":
          value = ManagingOrganization;
          return ManagingOrganization is not null;
        case "contact":
          value = Contact;
          return Contact?.Any() == true;
        case "period":
          value = Period;
          return Period is not null;
        case "payload":
          value = Payload;
          return Payload?.Any() == true;
        case "address":
          value = AddressElement;
          return AddressElement is not null;
        case "header":
          value = HeaderElement;
          return HeaderElement?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (ConnectionType?.Any() == true) yield return new KeyValuePair<string,object>("connectionType",ConnectionType);
      if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
      if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      if (EnvironmentType?.Any() == true) yield return new KeyValuePair<string,object>("environmentType",EnvironmentType);
      if (ManagingOrganization is not null) yield return new KeyValuePair<string,object>("managingOrganization",ManagingOrganization);
      if (Contact?.Any() == true) yield return new KeyValuePair<string,object>("contact",Contact);
      if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      if (Payload?.Any() == true) yield return new KeyValuePair<string,object>("payload",Payload);
      if (AddressElement is not null) yield return new KeyValuePair<string,object>("address",AddressElement);
      if (HeaderElement?.Any() == true) yield return new KeyValuePair<string,object>("header",HeaderElement);
    }

  }

}

// end of file
