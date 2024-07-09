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
  /// Regulatory approval, clearance or licencing related to a regulated product, treatment, facility or activity e.g. Market Authorization for a Medicinal Product
  /// </summary>
  /// <remarks>
  /// Regulatory approval, clearance or licencing related to a regulated product, treatment, facility or activity that is cited in a guidance, regulation, rule or legislative act. An example is Market Authorization relating to a Medicinal Product.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("RegulatedAuthorization","http://hl7.org/fhir/StructureDefinition/RegulatedAuthorization", IsResource=true)]
  public partial class RegulatedAuthorization : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "RegulatedAuthorization"; } }

    /// <summary>
    /// The case or regulatory procedure for granting or amending a regulated authorization. Note: This area is subject to ongoing review and the workgroup is seeking implementer feedback on its use (see link at bottom of page)
    /// </summary>
    /// <remarks>
    /// The case or regulatory procedure for granting or amending a regulated authorization. An authorization is granted in response to submissions/applications by those seeking authorization. A case is the administrative process that deals with the application(s) that relate to this and assesses them. Note: This area is subject to ongoing review and the workgroup is seeking implementer feedback on its use (see link at bottom of page).
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("RegulatedAuthorization#Case", IsNestedType=true)]
    [BackboneType("RegulatedAuthorization.case")]
    public partial class CaseComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "RegulatedAuthorization#Case"; } }

      /// <summary>
      /// Identifier by which this case can be referenced
      /// </summary>
      [FhirElement("identifier", InSummary=true, Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.Identifier Identifier
      {
        get { return _Identifier; }
        set { _Identifier = value; OnPropertyChanged("Identifier"); }
      }

      private Hl7.Fhir.Model.Identifier _Identifier;

      /// <summary>
      /// The defining type of case
      /// </summary>
      [FhirElement("type", InSummary=true, Order=50)]
      [Binding("RegulatedAuthorizationCaseType")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Type
      {
        get { return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Type;

      /// <summary>
      /// The status associated with the case
      /// </summary>
      [FhirElement("status", InSummary=true, Order=60)]
      [Binding("PublicationStatus")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Status
      {
        get { return _Status; }
        set { _Status = value; OnPropertyChanged("Status"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Status;

      /// <summary>
      /// Relevant date for this case
      /// </summary>
      [FhirElement("date", InSummary=true, Order=70, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.FhirDateTime))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Date
      {
        get { return _Date; }
        set { _Date = value; OnPropertyChanged("Date"); }
      }

      private Hl7.Fhir.Model.DataType _Date;

      /// <summary>
      /// Applications submitted to obtain a regulated authorization. Steps within the longer running case or procedure
      /// </summary>
      [FhirElement("application", InSummary=true, Order=80)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.RegulatedAuthorization.CaseComponent> Application
      {
        get { if(_Application==null) _Application = new List<Hl7.Fhir.Model.RegulatedAuthorization.CaseComponent>(); return _Application; }
        set { _Application = value; OnPropertyChanged("Application"); }
      }

      private List<Hl7.Fhir.Model.RegulatedAuthorization.CaseComponent> _Application;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as CaseComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
        if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
        if(Status != null) dest.Status = (Hl7.Fhir.Model.CodeableConcept)Status.DeepCopy();
        if(Date != null) dest.Date = (Hl7.Fhir.Model.DataType)Date.DeepCopy();
        if(Application.Any()) dest.Application = new List<Hl7.Fhir.Model.RegulatedAuthorization.CaseComponent>(Application.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new CaseComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as CaseComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;
        if( !DeepComparable.Matches(Status, otherT.Status)) return false;
        if( !DeepComparable.Matches(Date, otherT.Date)) return false;
        if( !DeepComparable.Matches(Application, otherT.Application)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as CaseComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
        if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
        if( !DeepComparable.IsExactly(Date, otherT.Date)) return false;
        if( !DeepComparable.IsExactly(Application, otherT.Application)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Identifier != null) yield return Identifier;
          if (Type != null) yield return Type;
          if (Status != null) yield return Status;
          if (Date != null) yield return Date;
          foreach (var elem in Application) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Identifier != null) yield return new ElementValue("identifier", Identifier);
          if (Type != null) yield return new ElementValue("type", Type);
          if (Status != null) yield return new ElementValue("status", Status);
          if (Date != null) yield return new ElementValue("date", Date);
          foreach (var elem in Application) { if (elem != null) yield return new ElementValue("application", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "identifier":
            value = Identifier;
            return Identifier is not null;
          case "type":
            value = Type;
            return Type is not null;
          case "status":
            value = Status;
            return Status is not null;
          case "date":
            value = Date;
            return Date is not null;
          case "application":
            value = Application;
            return Application?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Identifier is not null) yield return new KeyValuePair<string,object>("identifier",Identifier);
        if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
        if (Status is not null) yield return new KeyValuePair<string,object>("status",Status);
        if (Date is not null) yield return new KeyValuePair<string,object>("date",Date);
        if (Application?.Any() == true) yield return new KeyValuePair<string,object>("application",Application);
      }

    }

    /// <summary>
    /// Business identifier for the authorization, typically assigned by the authorizing body
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="FiveWs.class")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// The product type, treatment, facility or activity that is being authorized
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=100)]
    [CLSCompliant(false)]
    [References("MedicinalProductDefinition","BiologicallyDerivedProduct","NutritionProduct","PackagedProductDefinition","ManufacturedItemDefinition","Ingredient","SubstanceDefinition","DeviceDefinition","ResearchStudy","ActivityDefinition","PlanDefinition","ObservationDefinition","Practitioner","Organization","Location")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Subject
    {
      get { if(_Subject==null) _Subject = new List<Hl7.Fhir.Model.ResourceReference>(); return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Subject;

    /// <summary>
    /// Overall type of this authorization, for example drug marketing approval, orphan drug designation
    /// </summary>
    [FhirElement("type", InSummary=true, Order=110)]
    [Binding("RegulatedAuthorizationType")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Type
    {
      get { return _Type; }
      set { _Type = value; OnPropertyChanged("Type"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Type;

    /// <summary>
    /// General textual supporting information
    /// </summary>
    [FhirElement("description", InSummary=true, Order=120)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown DescriptionElement
    {
      get { return _DescriptionElement; }
      set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
    }

    private Hl7.Fhir.Model.Markdown _DescriptionElement;

    /// <summary>
    /// General textual supporting information
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
          DescriptionElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Description");
      }
    }

    /// <summary>
    /// The territory in which the authorization has been granted
    /// </summary>
    [FhirElement("region", InSummary=true, Order=130)]
    [Binding("Jurisdiction")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Region
    {
      get { if(_Region==null) _Region = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Region; }
      set { _Region = value; OnPropertyChanged("Region"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Region;

    /// <summary>
    /// The status that is authorised e.g. approved. Intermediate states can be tracked with cases and applications
    /// </summary>
    [FhirElement("status", InSummary=true, Order=140)]
    [Binding("PublicationStatus")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Status
    {
      get { return _Status; }
      set { _Status = value; OnPropertyChanged("Status"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Status;

    /// <summary>
    /// The date at which the current status was assigned
    /// </summary>
    [FhirElement("statusDate", InSummary=true, Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime StatusDateElement
    {
      get { return _StatusDateElement; }
      set { _StatusDateElement = value; OnPropertyChanged("StatusDateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _StatusDateElement;

    /// <summary>
    /// The date at which the current status was assigned
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string StatusDate
    {
      get { return StatusDateElement != null ? StatusDateElement.Value : null; }
      set
      {
        if (value == null)
          StatusDateElement = null;
        else
          StatusDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("StatusDate");
      }
    }

    /// <summary>
    /// The time period in which the regulatory approval etc. is in effect, e.g. a Marketing Authorization includes the date of authorization and/or expiration date
    /// </summary>
    [FhirElement("validityPeriod", InSummary=true, Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.Period ValidityPeriod
    {
      get { return _ValidityPeriod; }
      set { _ValidityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
    }

    private Hl7.Fhir.Model.Period _ValidityPeriod;

    /// <summary>
    /// Condition for which the use of the regulated product applies
    /// </summary>
    [FhirElement("indication", InSummary=true, Order=170)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableReference> Indication
    {
      get { if(_Indication==null) _Indication = new List<Hl7.Fhir.Model.CodeableReference>(); return _Indication; }
      set { _Indication = value; OnPropertyChanged("Indication"); }
    }

    private List<Hl7.Fhir.Model.CodeableReference> _Indication;

    /// <summary>
    /// The intended use of the product, e.g. prevention, treatment
    /// </summary>
    [FhirElement("intendedUse", InSummary=true, Order=180)]
    [Binding("ProductIntendedUse")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept IntendedUse
    {
      get { return _IntendedUse; }
      set { _IntendedUse = value; OnPropertyChanged("IntendedUse"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _IntendedUse;

    /// <summary>
    /// The legal/regulatory framework or reasons under which this authorization is granted
    /// </summary>
    [FhirElement("basis", InSummary=true, Order=190)]
    [Binding("RegulatedAuthorizationBasis")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Basis
    {
      get { if(_Basis==null) _Basis = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Basis; }
      set { _Basis = value; OnPropertyChanged("Basis"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Basis;

    /// <summary>
    /// The organization that has been granted this authorization, by the regulator
    /// </summary>
    [FhirElement("holder", InSummary=true, Order=200)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Holder
    {
      get { return _Holder; }
      set { _Holder = value; OnPropertyChanged("Holder"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Holder;

    /// <summary>
    /// The regulatory authority or authorizing body granting the authorization
    /// </summary>
    [FhirElement("regulator", InSummary=true, Order=210)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Regulator
    {
      get { return _Regulator; }
      set { _Regulator = value; OnPropertyChanged("Regulator"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Regulator;

    /// <summary>
    /// Additional information or supporting documentation about the authorization
    /// </summary>
    [FhirElement("attachedDocument", InSummary=true, Order=220)]
    [CLSCompliant(false)]
    [References("DocumentReference")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> AttachedDocument
    {
      get { if(_AttachedDocument==null) _AttachedDocument = new List<Hl7.Fhir.Model.ResourceReference>(); return _AttachedDocument; }
      set { _AttachedDocument = value; OnPropertyChanged("AttachedDocument"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _AttachedDocument;

    /// <summary>
    /// The case or regulatory procedure for granting or amending a regulated authorization. Note: This area is subject to ongoing review and the workgroup is seeking implementer feedback on its use (see link at bottom of page)
    /// </summary>
    [FhirElement("case", InSummary=true, Order=230)]
    [DataMember]
    public Hl7.Fhir.Model.RegulatedAuthorization.CaseComponent Case
    {
      get { return _Case; }
      set { _Case = value; OnPropertyChanged("Case"); }
    }

    private Hl7.Fhir.Model.RegulatedAuthorization.CaseComponent _Case;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as RegulatedAuthorization;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Subject.Any()) dest.Subject = new List<Hl7.Fhir.Model.ResourceReference>(Subject.DeepCopy());
      if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
      if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
      if(Region.Any()) dest.Region = new List<Hl7.Fhir.Model.CodeableConcept>(Region.DeepCopy());
      if(Status != null) dest.Status = (Hl7.Fhir.Model.CodeableConcept)Status.DeepCopy();
      if(StatusDateElement != null) dest.StatusDateElement = (Hl7.Fhir.Model.FhirDateTime)StatusDateElement.DeepCopy();
      if(ValidityPeriod != null) dest.ValidityPeriod = (Hl7.Fhir.Model.Period)ValidityPeriod.DeepCopy();
      if(Indication.Any()) dest.Indication = new List<Hl7.Fhir.Model.CodeableReference>(Indication.DeepCopy());
      if(IntendedUse != null) dest.IntendedUse = (Hl7.Fhir.Model.CodeableConcept)IntendedUse.DeepCopy();
      if(Basis.Any()) dest.Basis = new List<Hl7.Fhir.Model.CodeableConcept>(Basis.DeepCopy());
      if(Holder != null) dest.Holder = (Hl7.Fhir.Model.ResourceReference)Holder.DeepCopy();
      if(Regulator != null) dest.Regulator = (Hl7.Fhir.Model.ResourceReference)Regulator.DeepCopy();
      if(AttachedDocument.Any()) dest.AttachedDocument = new List<Hl7.Fhir.Model.ResourceReference>(AttachedDocument.DeepCopy());
      if(Case != null) dest.Case = (Hl7.Fhir.Model.RegulatedAuthorization.CaseComponent)Case.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new RegulatedAuthorization());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as RegulatedAuthorization;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Type, otherT.Type)) return false;
      if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.Matches(Region, otherT.Region)) return false;
      if( !DeepComparable.Matches(Status, otherT.Status)) return false;
      if( !DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
      if( !DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;
      if( !DeepComparable.Matches(Indication, otherT.Indication)) return false;
      if( !DeepComparable.Matches(IntendedUse, otherT.IntendedUse)) return false;
      if( !DeepComparable.Matches(Basis, otherT.Basis)) return false;
      if( !DeepComparable.Matches(Holder, otherT.Holder)) return false;
      if( !DeepComparable.Matches(Regulator, otherT.Regulator)) return false;
      if( !DeepComparable.Matches(AttachedDocument, otherT.AttachedDocument)) return false;
      if( !DeepComparable.Matches(Case, otherT.Case)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as RegulatedAuthorization;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
      if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.IsExactly(Region, otherT.Region)) return false;
      if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
      if( !DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
      if( !DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;
      if( !DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
      if( !DeepComparable.IsExactly(IntendedUse, otherT.IntendedUse)) return false;
      if( !DeepComparable.IsExactly(Basis, otherT.Basis)) return false;
      if( !DeepComparable.IsExactly(Holder, otherT.Holder)) return false;
      if( !DeepComparable.IsExactly(Regulator, otherT.Regulator)) return false;
      if( !DeepComparable.IsExactly(AttachedDocument, otherT.AttachedDocument)) return false;
      if( !DeepComparable.IsExactly(Case, otherT.Case)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in Subject) { if (elem != null) yield return elem; }
        if (Type != null) yield return Type;
        if (DescriptionElement != null) yield return DescriptionElement;
        foreach (var elem in Region) { if (elem != null) yield return elem; }
        if (Status != null) yield return Status;
        if (StatusDateElement != null) yield return StatusDateElement;
        if (ValidityPeriod != null) yield return ValidityPeriod;
        foreach (var elem in Indication) { if (elem != null) yield return elem; }
        if (IntendedUse != null) yield return IntendedUse;
        foreach (var elem in Basis) { if (elem != null) yield return elem; }
        if (Holder != null) yield return Holder;
        if (Regulator != null) yield return Regulator;
        foreach (var elem in AttachedDocument) { if (elem != null) yield return elem; }
        if (Case != null) yield return Case;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", elem); }
        if (Type != null) yield return new ElementValue("type", Type);
        if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        foreach (var elem in Region) { if (elem != null) yield return new ElementValue("region", elem); }
        if (Status != null) yield return new ElementValue("status", Status);
        if (StatusDateElement != null) yield return new ElementValue("statusDate", StatusDateElement);
        if (ValidityPeriod != null) yield return new ElementValue("validityPeriod", ValidityPeriod);
        foreach (var elem in Indication) { if (elem != null) yield return new ElementValue("indication", elem); }
        if (IntendedUse != null) yield return new ElementValue("intendedUse", IntendedUse);
        foreach (var elem in Basis) { if (elem != null) yield return new ElementValue("basis", elem); }
        if (Holder != null) yield return new ElementValue("holder", Holder);
        if (Regulator != null) yield return new ElementValue("regulator", Regulator);
        foreach (var elem in AttachedDocument) { if (elem != null) yield return new ElementValue("attachedDocument", elem); }
        if (Case != null) yield return new ElementValue("case", Case);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "subject":
          value = Subject;
          return Subject?.Any() == true;
        case "type":
          value = Type;
          return Type is not null;
        case "description":
          value = DescriptionElement;
          return DescriptionElement is not null;
        case "region":
          value = Region;
          return Region?.Any() == true;
        case "status":
          value = Status;
          return Status is not null;
        case "statusDate":
          value = StatusDateElement;
          return StatusDateElement is not null;
        case "validityPeriod":
          value = ValidityPeriod;
          return ValidityPeriod is not null;
        case "indication":
          value = Indication;
          return Indication?.Any() == true;
        case "intendedUse":
          value = IntendedUse;
          return IntendedUse is not null;
        case "basis":
          value = Basis;
          return Basis?.Any() == true;
        case "holder":
          value = Holder;
          return Holder is not null;
        case "regulator":
          value = Regulator;
          return Regulator is not null;
        case "attachedDocument":
          value = AttachedDocument;
          return AttachedDocument?.Any() == true;
        case "case":
          value = Case;
          return Case is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Subject?.Any() == true) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
      if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      if (Region?.Any() == true) yield return new KeyValuePair<string,object>("region",Region);
      if (Status is not null) yield return new KeyValuePair<string,object>("status",Status);
      if (StatusDateElement is not null) yield return new KeyValuePair<string,object>("statusDate",StatusDateElement);
      if (ValidityPeriod is not null) yield return new KeyValuePair<string,object>("validityPeriod",ValidityPeriod);
      if (Indication?.Any() == true) yield return new KeyValuePair<string,object>("indication",Indication);
      if (IntendedUse is not null) yield return new KeyValuePair<string,object>("intendedUse",IntendedUse);
      if (Basis?.Any() == true) yield return new KeyValuePair<string,object>("basis",Basis);
      if (Holder is not null) yield return new KeyValuePair<string,object>("holder",Holder);
      if (Regulator is not null) yield return new KeyValuePair<string,object>("regulator",Regulator);
      if (AttachedDocument?.Any() == true) yield return new KeyValuePair<string,object>("attachedDocument",AttachedDocument);
      if (Case is not null) yield return new KeyValuePair<string,object>("case",Case);
    }

  }

}

// end of file
