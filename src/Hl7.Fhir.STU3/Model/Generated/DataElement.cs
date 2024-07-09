// <auto-generated/>
// Contents of: hl7.fhir.r3.expansions#3.0.2, hl7.fhir.r3.core#3.0.2

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
  /// Resource data element
  /// </summary>
  /// <remarks>
  /// The formal description of a single piece of information that can be gathered and reported.
  /// Often called a clinical template.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("DataElement","http://hl7.org/fhir/StructureDefinition/DataElement", IsResource=true)]
  public partial class DataElement : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "DataElement"; } }

    /// <summary>
    /// Indicates the degree of precision of the data element definition.
    /// (url: http://hl7.org/fhir/ValueSet/dataelement-stringency)
    /// (system: http://hl7.org/fhir/dataelement-stringency)
    /// </summary>
    [FhirEnumeration("DataElementStringency", "http://hl7.org/fhir/ValueSet/dataelement-stringency", "http://hl7.org/fhir/dataelement-stringency")]
    public enum DataElementStringency
    {
      /// <summary>
      /// The data element is sufficiently well-constrained that multiple pieces of data captured according to the constraints of the data element will be comparable (though in some cases, a degree of automated conversion/normalization may be required).
      /// (system: http://hl7.org/fhir/dataelement-stringency)
      /// </summary>
      [EnumLiteral("comparable"), Description("Comparable")]
      Comparable,
      /// <summary>
      /// The data element is fully specified down to a single value set, single unit of measure, single data type, etc.  Multiple pieces of data associated with this data element are fully comparable.
      /// (system: http://hl7.org/fhir/dataelement-stringency)
      /// </summary>
      [EnumLiteral("fully-specified"), Description("Fully Specified")]
      FullySpecified,
      /// <summary>
      /// The data element allows multiple units of measure having equivalent meaning; e.g. \"cc\" (cubic centimeter) and \"mL\" (milliliter).
      /// (system: http://hl7.org/fhir/dataelement-stringency)
      /// </summary>
      [EnumLiteral("equivalent"), Description("Equivalent")]
      Equivalent,
      /// <summary>
      /// The data element allows multiple units of measure that are convertable between each other (e.g. inches and centimeters) and/or allows data to be captured in multiple value sets for which a known mapping exists allowing conversion of meaning.
      /// (system: http://hl7.org/fhir/dataelement-stringency)
      /// </summary>
      [EnumLiteral("convertable"), Description("Convertable")]
      Convertable,
      /// <summary>
      /// A convertable data element where unit conversions are different only by a power of 10; e.g. g, mg, kg.
      /// (system: http://hl7.org/fhir/dataelement-stringency)
      /// </summary>
      [EnumLiteral("scaleable"), Description("Scaleable")]
      Scaleable,
      /// <summary>
      /// The data element is unconstrained in units, choice of data types and/or choice of vocabulary such that automated comparison of data captured using the data element is not possible.
      /// (system: http://hl7.org/fhir/dataelement-stringency)
      /// </summary>
      [EnumLiteral("flexible"), Description("Flexible")]
      Flexible,
    }

    /// <summary>
    /// External specification mapped to
    /// </summary>
    /// <remarks>
    /// Identifies a specification (other than a terminology) that the elements which make up the DataElement have some correspondence with.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("DataElement#Mapping", IsNestedType=true)]
    [BackboneType("DataElement.mapping")]
    public partial class MappingComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "DataElement#Mapping"; } }

      /// <summary>
      /// Internal id when this mapping is used
      /// </summary>
      [FhirElement("identity", Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.Id IdentityElement
      {
        get { return _IdentityElement; }
        set { _IdentityElement = value; OnPropertyChanged("IdentityElement"); }
      }

      private Hl7.Fhir.Model.Id _IdentityElement;

      /// <summary>
      /// Internal id when this mapping is used
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Identity
      {
        get { return IdentityElement != null ? IdentityElement.Value : null; }
        set
        {
          if (value == null)
            IdentityElement = null;
          else
            IdentityElement = new Hl7.Fhir.Model.Id(value);
          OnPropertyChanged("Identity");
        }
      }

      /// <summary>
      /// Identifies what this mapping refers to
      /// </summary>
      [FhirElement("uri", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.FhirUri UriElement
      {
        get { return _UriElement; }
        set { _UriElement = value; OnPropertyChanged("UriElement"); }
      }

      private Hl7.Fhir.Model.FhirUri _UriElement;

      /// <summary>
      /// Identifies what this mapping refers to
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Uri
      {
        get { return UriElement != null ? UriElement.Value : null; }
        set
        {
          if (value == null)
            UriElement = null;
          else
            UriElement = new Hl7.Fhir.Model.FhirUri(value);
          OnPropertyChanged("Uri");
        }
      }

      /// <summary>
      /// Names what this mapping refers to
      /// </summary>
      [FhirElement("name", Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString NameElement
      {
        get { return _NameElement; }
        set { _NameElement = value; OnPropertyChanged("NameElement"); }
      }

      private Hl7.Fhir.Model.FhirString _NameElement;

      /// <summary>
      /// Names what this mapping refers to
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
      /// Versions, issues, scope limitations, etc.
      /// </summary>
      [FhirElement("comment", Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString CommentElement
      {
        get { return _CommentElement; }
        set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
      }

      private Hl7.Fhir.Model.FhirString _CommentElement;

      /// <summary>
      /// Versions, issues, scope limitations, etc.
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Comment
      {
        get { return CommentElement != null ? CommentElement.Value : null; }
        set
        {
          if (value == null)
            CommentElement = null;
          else
            CommentElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Comment");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as MappingComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(IdentityElement != null) dest.IdentityElement = (Hl7.Fhir.Model.Id)IdentityElement.DeepCopy();
        if(UriElement != null) dest.UriElement = (Hl7.Fhir.Model.FhirUri)UriElement.DeepCopy();
        if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
        if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new MappingComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as MappingComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(IdentityElement, otherT.IdentityElement)) return false;
        if( !DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
        if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
        if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as MappingComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(IdentityElement, otherT.IdentityElement)) return false;
        if( !DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
        if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
        if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (IdentityElement != null) yield return IdentityElement;
          if (UriElement != null) yield return UriElement;
          if (NameElement != null) yield return NameElement;
          if (CommentElement != null) yield return CommentElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (IdentityElement != null) yield return new ElementValue("identity", IdentityElement);
          if (UriElement != null) yield return new ElementValue("uri", UriElement);
          if (NameElement != null) yield return new ElementValue("name", NameElement);
          if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "identity":
            value = IdentityElement;
            return IdentityElement is not null;
          case "uri":
            value = UriElement;
            return UriElement is not null;
          case "name":
            value = NameElement;
            return NameElement is not null;
          case "comment":
            value = CommentElement;
            return CommentElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (IdentityElement is not null) yield return new KeyValuePair<string,object>("identity",IdentityElement);
        if (UriElement is not null) yield return new KeyValuePair<string,object>("uri",UriElement);
        if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
        if (CommentElement is not null) yield return new KeyValuePair<string,object>("comment",CommentElement);
      }

    }

    /// <summary>
    /// Logical URI to reference this data element (globally unique)
    /// </summary>
    [FhirElement("url", InSummary=true, Order=90, FiveWs="id")]
    [DataMember]
    public Hl7.Fhir.Model.FhirUri UrlElement
    {
      get { return _UrlElement; }
      set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
    }

    private Hl7.Fhir.Model.FhirUri _UrlElement;

    /// <summary>
    /// Logical URI to reference this data element (globally unique)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Url
    {
      get { return UrlElement != null ? UrlElement.Value : null; }
      set
      {
        if (value == null)
          UrlElement = null;
        else
          UrlElement = new Hl7.Fhir.Model.FhirUri(value);
        OnPropertyChanged("Url");
      }
    }

    /// <summary>
    /// Additional identifier for the data element
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=100, FiveWs="id")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Business version of the data element
    /// </summary>
    [FhirElement("version", InSummary=true, Order=110, FiveWs="id.version")]
    [DataMember]
    public Hl7.Fhir.Model.FhirString VersionElement
    {
      get { return _VersionElement; }
      set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _VersionElement;

    /// <summary>
    /// Business version of the data element
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Version
    {
      get { return VersionElement != null ? VersionElement.Value : null; }
      set
      {
        if (value == null)
          VersionElement = null;
        else
          VersionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Version");
      }
    }

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=120, FiveWs="status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("PublicationStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.PublicationStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.PublicationStatus> _StatusElement;

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.PublicationStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// For testing purposes, not real usage
    /// </summary>
    [FhirElement("experimental", InSummary=true, IsModifier=true, Order=130, FiveWs="class")]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
    {
      get { return _ExperimentalElement; }
      set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;

    /// <summary>
    /// For testing purposes, not real usage
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Experimental
    {
      get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
      set
      {
        if (value == null)
          ExperimentalElement = null;
        else
          ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Experimental");
      }
    }

    /// <summary>
    /// Date this was last changed
    /// </summary>
    [FhirElement("date", InSummary=true, Order=140, FiveWs="when.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime DateElement
    {
      get { return _DateElement; }
      set { _DateElement = value; OnPropertyChanged("DateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _DateElement;

    /// <summary>
    /// Date this was last changed
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Date
    {
      get { return DateElement != null ? DateElement.Value : null; }
      set
      {
        if (value == null)
          DateElement = null;
        else
          DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Date");
      }
    }

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// </summary>
    [FhirElement("publisher", InSummary=true, Order=150, FiveWs="who.witness")]
    [DataMember]
    public Hl7.Fhir.Model.FhirString PublisherElement
    {
      get { return _PublisherElement; }
      set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
    }

    private Hl7.Fhir.Model.FhirString _PublisherElement;

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Publisher
    {
      get { return PublisherElement != null ? PublisherElement.Value : null; }
      set
      {
        if (value == null)
          PublisherElement = null;
        else
          PublisherElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Publisher");
      }
    }

    /// <summary>
    /// Name for this data element (computer friendly)
    /// </summary>
    [FhirElement("name", InSummary=true, Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString NameElement
    {
      get { return _NameElement; }
      set { _NameElement = value; OnPropertyChanged("NameElement"); }
    }

    private Hl7.Fhir.Model.FhirString _NameElement;

    /// <summary>
    /// Name for this data element (computer friendly)
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
    /// Name for this data element (human friendly)
    /// </summary>
    [FhirElement("title", InSummary=true, Order=170)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString TitleElement
    {
      get { return _TitleElement; }
      set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
    }

    private Hl7.Fhir.Model.FhirString _TitleElement;

    /// <summary>
    /// Name for this data element (human friendly)
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Title
    {
      get { return TitleElement != null ? TitleElement.Value : null; }
      set
      {
        if (value == null)
          TitleElement = null;
        else
          TitleElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Title");
      }
    }

    /// <summary>
    /// Contact details for the publisher
    /// </summary>
    [FhirElement("contact", InSummary=true, Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ContactDetail> Contact
    {
      get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ContactDetail>(); return _Contact; }
      set { _Contact = value; OnPropertyChanged("Contact"); }
    }

    private List<Hl7.Fhir.Model.ContactDetail> _Contact;

    /// <summary>
    /// Context the content is intended to support
    /// </summary>
    [FhirElement("useContext", InSummary=true, Order=190)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.UsageContext> UseContext
    {
      get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.UsageContext>(); return _UseContext; }
      set { _UseContext = value; OnPropertyChanged("UseContext"); }
    }

    private List<Hl7.Fhir.Model.UsageContext> _UseContext;

    /// <summary>
    /// Intended jurisdiction for data element (if applicable)
    /// </summary>
    [FhirElement("jurisdiction", InSummary=true, Order=200)]
    [Binding("Jurisdiction")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
    {
      get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
      set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    [FhirElement("copyright", Order=210)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown CopyrightElement
    {
      get { return _CopyrightElement; }
      set { _CopyrightElement = value; OnPropertyChanged("CopyrightElement"); }
    }

    private Hl7.Fhir.Model.Markdown _CopyrightElement;

    /// <summary>
    /// Use and/or publishing restrictions
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Copyright
    {
      get { return CopyrightElement != null ? CopyrightElement.Value : null; }
      set
      {
        if (value == null)
          CopyrightElement = null;
        else
          CopyrightElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Copyright");
      }
    }

    /// <summary>
    /// comparable | fully-specified | equivalent | convertable | scaleable | flexible
    /// </summary>
    [FhirElement("stringency", InSummary=true, Order=220)]
    [DeclaredType(Type = typeof(Code))]
    [Binding("DataElementStringency")]
    [DataMember]
    public Code<Hl7.Fhir.Model.DataElement.DataElementStringency> StringencyElement
    {
      get { return _StringencyElement; }
      set { _StringencyElement = value; OnPropertyChanged("StringencyElement"); }
    }

    private Code<Hl7.Fhir.Model.DataElement.DataElementStringency> _StringencyElement;

    /// <summary>
    /// comparable | fully-specified | equivalent | convertable | scaleable | flexible
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.DataElement.DataElementStringency? Stringency
    {
      get { return StringencyElement != null ? StringencyElement.Value : null; }
      set
      {
        if (value == null)
          StringencyElement = null;
        else
          StringencyElement = new Code<Hl7.Fhir.Model.DataElement.DataElementStringency>(value);
        OnPropertyChanged("Stringency");
      }
    }

    /// <summary>
    /// External specification mapped to
    /// </summary>
    [FhirElement("mapping", Order=230)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.DataElement.MappingComponent> Mapping
    {
      get { if(_Mapping==null) _Mapping = new List<Hl7.Fhir.Model.DataElement.MappingComponent>(); return _Mapping; }
      set { _Mapping = value; OnPropertyChanged("Mapping"); }
    }

    private List<Hl7.Fhir.Model.DataElement.MappingComponent> _Mapping;

    /// <summary>
    /// Definition of element
    /// </summary>
    [FhirElement("element", InSummary=true, Order=240)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ElementDefinition> Element
    {
      get { if(_Element==null) _Element = new List<Hl7.Fhir.Model.ElementDefinition>(); return _Element; }
      set { _Element = value; OnPropertyChanged("Element"); }
    }

    private List<Hl7.Fhir.Model.ElementDefinition> _Element;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as DataElement;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
      if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
      if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
      if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
      if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
      if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
      if(Contact.Any()) dest.Contact = new List<Hl7.Fhir.Model.ContactDetail>(Contact.DeepCopy());
      if(UseContext.Any()) dest.UseContext = new List<Hl7.Fhir.Model.UsageContext>(UseContext.DeepCopy());
      if(Jurisdiction.Any()) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
      if(CopyrightElement != null) dest.CopyrightElement = (Hl7.Fhir.Model.Markdown)CopyrightElement.DeepCopy();
      if(StringencyElement != null) dest.StringencyElement = (Code<Hl7.Fhir.Model.DataElement.DataElementStringency>)StringencyElement.DeepCopy();
      if(Mapping.Any()) dest.Mapping = new List<Hl7.Fhir.Model.DataElement.MappingComponent>(Mapping.DeepCopy());
      if(Element.Any()) dest.Element = new List<Hl7.Fhir.Model.ElementDefinition>(Element.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new DataElement());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as DataElement;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
      if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
      if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
      if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
      if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
      if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
      if( !DeepComparable.Matches(StringencyElement, otherT.StringencyElement)) return false;
      if( !DeepComparable.Matches(Mapping, otherT.Mapping)) return false;
      if( !DeepComparable.Matches(Element, otherT.Element)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as DataElement;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
      if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
      if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
      if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
      if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
      if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
      if( !DeepComparable.IsExactly(StringencyElement, otherT.StringencyElement)) return false;
      if( !DeepComparable.IsExactly(Mapping, otherT.Mapping)) return false;
      if( !DeepComparable.IsExactly(Element, otherT.Element)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (UrlElement != null) yield return UrlElement;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (VersionElement != null) yield return VersionElement;
        if (StatusElement != null) yield return StatusElement;
        if (ExperimentalElement != null) yield return ExperimentalElement;
        if (DateElement != null) yield return DateElement;
        if (PublisherElement != null) yield return PublisherElement;
        if (NameElement != null) yield return NameElement;
        if (TitleElement != null) yield return TitleElement;
        foreach (var elem in Contact) { if (elem != null) yield return elem; }
        foreach (var elem in UseContext) { if (elem != null) yield return elem; }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
        if (CopyrightElement != null) yield return CopyrightElement;
        if (StringencyElement != null) yield return StringencyElement;
        foreach (var elem in Mapping) { if (elem != null) yield return elem; }
        foreach (var elem in Element) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (UrlElement != null) yield return new ElementValue("url", UrlElement);
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (VersionElement != null) yield return new ElementValue("version", VersionElement);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
        if (DateElement != null) yield return new ElementValue("date", DateElement);
        if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
        if (NameElement != null) yield return new ElementValue("name", NameElement);
        if (TitleElement != null) yield return new ElementValue("title", TitleElement);
        foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
        foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
        if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
        if (StringencyElement != null) yield return new ElementValue("stringency", StringencyElement);
        foreach (var elem in Mapping) { if (elem != null) yield return new ElementValue("mapping", elem); }
        foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "url":
          value = UrlElement;
          return UrlElement is not null;
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "version":
          value = VersionElement;
          return VersionElement is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "experimental":
          value = ExperimentalElement;
          return ExperimentalElement is not null;
        case "date":
          value = DateElement;
          return DateElement is not null;
        case "publisher":
          value = PublisherElement;
          return PublisherElement is not null;
        case "name":
          value = NameElement;
          return NameElement is not null;
        case "title":
          value = TitleElement;
          return TitleElement is not null;
        case "contact":
          value = Contact;
          return Contact?.Any() == true;
        case "useContext":
          value = UseContext;
          return UseContext?.Any() == true;
        case "jurisdiction":
          value = Jurisdiction;
          return Jurisdiction?.Any() == true;
        case "copyright":
          value = CopyrightElement;
          return CopyrightElement is not null;
        case "stringency":
          value = StringencyElement;
          return StringencyElement is not null;
        case "mapping":
          value = Mapping;
          return Mapping?.Any() == true;
        case "element":
          value = Element;
          return Element?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (UrlElement is not null) yield return new KeyValuePair<string,object>("url",UrlElement);
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (VersionElement is not null) yield return new KeyValuePair<string,object>("version",VersionElement);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (ExperimentalElement is not null) yield return new KeyValuePair<string,object>("experimental",ExperimentalElement);
      if (DateElement is not null) yield return new KeyValuePair<string,object>("date",DateElement);
      if (PublisherElement is not null) yield return new KeyValuePair<string,object>("publisher",PublisherElement);
      if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
      if (TitleElement is not null) yield return new KeyValuePair<string,object>("title",TitleElement);
      if (Contact?.Any() == true) yield return new KeyValuePair<string,object>("contact",Contact);
      if (UseContext?.Any() == true) yield return new KeyValuePair<string,object>("useContext",UseContext);
      if (Jurisdiction?.Any() == true) yield return new KeyValuePair<string,object>("jurisdiction",Jurisdiction);
      if (CopyrightElement is not null) yield return new KeyValuePair<string,object>("copyright",CopyrightElement);
      if (StringencyElement is not null) yield return new KeyValuePair<string,object>("stringency",StringencyElement);
      if (Mapping?.Any() == true) yield return new KeyValuePair<string,object>("mapping",Mapping);
      if (Element?.Any() == true) yield return new KeyValuePair<string,object>("element",Element);
    }

  }

}

// end of file
