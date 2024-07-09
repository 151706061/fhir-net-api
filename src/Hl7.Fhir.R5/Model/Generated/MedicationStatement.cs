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
  /// Record of medication being taken by a patient
  /// </summary>
  /// <remarks>
  /// A record of a medication that is being consumed by a patient.   A MedicationStatement may indicate that the patient may be taking the medication now or has taken the medication in the past or will be taking the medication in the future.  The source of this information can be the patient, significant other (such as a family member or spouse), or a clinician.  A common scenario where this information is captured is during the history taking process during a patient visit or stay.   The medication information may come from sources such as the patient's memory, from a prescription bottle,  or from a list of medications the patient, clinician or other party maintains. 
  /// The primary difference between a medicationstatement and a medicationadministration is that the medication administration has complete administration information and is based on actual administration information from the person who administered the medication.  A medicationstatement is often, if not always, less specific.  There is no required date/time when the medication was administered, in fact we only know that a source has reported the patient is taking this medication, where details such as time, quantity, or rate or even medication product may be incomplete or missing or less precise.  As stated earlier, the Medication Statement information may come from the patient's memory, from a prescription bottle or from a list of medications the patient, clinician or other party maintains.  Medication administration is more formal and is not missing detailed information.
  /// The MedicationStatement resource was previously called MedicationStatement.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("MedicationStatement","http://hl7.org/fhir/StructureDefinition/MedicationStatement", IsResource=true)]
  public partial class MedicationStatement : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "MedicationStatement"; } }

    /// <summary>
    /// MedicationStatement Status Codes
    /// (url: http://hl7.org/fhir/ValueSet/medication-statement-status)
    /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
    /// </summary>
    [FhirEnumeration("MedicationStatementStatusCodes", "http://hl7.org/fhir/ValueSet/medication-statement-status", "http://hl7.org/fhir/CodeSystem/medication-statement-status")]
    public enum MedicationStatementStatusCodes
    {
      /// <summary>
      /// The action of recording the medication statement is finished.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("recorded"), Description("Recorded")]
      Recorded,
      /// <summary>
      /// Some of the actions that are implied by the medication usage may have occurred.  For example, the patient may have taken some of the medication.  Clinical decision support systems should take this status into account.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in Error")]
      EnteredInError,
      /// <summary>
      /// The medication usage is draft or preliminary.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("draft"), Description("Draft")]
      Draft,
    }

    /// <summary>
    /// Indicates whether the medication is or is not being consumed or administered
    /// </summary>
    /// <remarks>
    /// This element can be used to indicate whether a patient is following a course of treatment as instructed/prescribed or whether they are taking medications of their own volition.  It can also be used to indicate that a patient is not taking a medication, either because they were told not to or because they decided on their own.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("MedicationStatement#Adherence", IsNestedType=true)]
    [BackboneType("MedicationStatement.adherence")]
    public partial class AdherenceComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "MedicationStatement#Adherence"; } }

      /// <summary>
      /// Type of adherence
      /// </summary>
      [FhirElement("code", InSummary=true, Order=40)]
      [Binding("MedicationStatementAdherence")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// Details of the reason for the current use of the medication
      /// </summary>
      [FhirElement("reason", Order=50)]
      [Binding("MedicationStatementStatusReason")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Reason
      {
        get { return _Reason; }
        set { _Reason = value; OnPropertyChanged("Reason"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Reason;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as AdherenceComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(Reason != null) dest.Reason = (Hl7.Fhir.Model.CodeableConcept)Reason.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new AdherenceComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as AdherenceComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as AdherenceComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          if (Reason != null) yield return Reason;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (Reason != null) yield return new ElementValue("reason", Reason);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "reason":
            value = Reason;
            return Reason is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (Reason is not null) yield return new KeyValuePair<string,object>("reason",Reason);
      }

    }

    /// <summary>
    /// External identifier
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
    /// Part of referenced event
    /// </summary>
    [FhirElement("partOf", Order=100)]
    [CLSCompliant(false)]
    [References("Procedure","MedicationStatement")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> PartOf
    {
      get { if(_PartOf==null) _PartOf = new List<Hl7.Fhir.Model.ResourceReference>(); return _PartOf; }
      set { _PartOf = value; OnPropertyChanged("PartOf"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _PartOf;

    /// <summary>
    /// recorded | entered-in-error | draft
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=110, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("MedicationStatementStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatementStatusCodes> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatementStatusCodes> _StatusElement;

    /// <summary>
    /// recorded | entered-in-error | draft
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.MedicationStatement.MedicationStatementStatusCodes? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatementStatusCodes>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Type of medication statement
    /// </summary>
    [FhirElement("category", InSummary=true, Order=120, FiveWs="FiveWs.class")]
    [Binding("MedicationStatementAdministrationLocation")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// What medication was taken
    /// </summary>
    [FhirElement("medication", InSummary=true, Order=130, FiveWs="FiveWs.what[x]")]
    [Binding("MedicationCode")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableReference Medication
    {
      get { return _Medication; }
      set { _Medication = value; OnPropertyChanged("Medication"); }
    }

    private Hl7.Fhir.Model.CodeableReference _Medication;

    /// <summary>
    /// Who is/was taking  the medication
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=140, FiveWs="FiveWs.subject")]
    [CLSCompliant(false)]
    [References("Patient","Group")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// Encounter associated with MedicationStatement
    /// </summary>
    [FhirElement("encounter", InSummary=true, Order=150)]
    [CLSCompliant(false)]
    [References("Encounter")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Encounter
    {
      get { return _Encounter; }
      set { _Encounter = value; OnPropertyChanged("Encounter"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Encounter;

    /// <summary>
    /// The date/time or interval when the medication is/was/will be taken
    /// </summary>
    [FhirElement("effective", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.done[x]")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Timing))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Effective
    {
      get { return _Effective; }
      set { _Effective = value; OnPropertyChanged("Effective"); }
    }

    private Hl7.Fhir.Model.DataType _Effective;

    /// <summary>
    /// When the usage was asserted?
    /// </summary>
    [FhirElement("dateAsserted", InSummary=true, Order=170, FiveWs="FiveWs.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime DateAssertedElement
    {
      get { return _DateAssertedElement; }
      set { _DateAssertedElement = value; OnPropertyChanged("DateAssertedElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _DateAssertedElement;

    /// <summary>
    /// When the usage was asserted?
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string DateAsserted
    {
      get { return DateAssertedElement != null ? DateAssertedElement.Value : null; }
      set
      {
        if (value == null)
          DateAssertedElement = null;
        else
          DateAssertedElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("DateAsserted");
      }
    }

    /// <summary>
    /// Person or organization that provided the information about the taking of this medication
    /// </summary>
    [FhirElement("informationSource", Order=180, FiveWs="FiveWs.source")]
    [CLSCompliant(false)]
    [References("Patient","Practitioner","PractitionerRole","RelatedPerson","Organization")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> InformationSource
    {
      get { if(_InformationSource==null) _InformationSource = new List<Hl7.Fhir.Model.ResourceReference>(); return _InformationSource; }
      set { _InformationSource = value; OnPropertyChanged("InformationSource"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _InformationSource;

    /// <summary>
    /// Link to information used to derive the MedicationStatement
    /// </summary>
    [FhirElement("derivedFrom", Order=190)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> DerivedFrom
    {
      get { if(_DerivedFrom==null) _DerivedFrom = new List<Hl7.Fhir.Model.ResourceReference>(); return _DerivedFrom; }
      set { _DerivedFrom = value; OnPropertyChanged("DerivedFrom"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _DerivedFrom;

    /// <summary>
    /// Reason for why the medication is being/was taken
    /// </summary>
    [FhirElement("reason", Order=200, FiveWs="FiveWs.why[x]")]
    [Binding("MedicationReason")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableReference> Reason
    {
      get { if(_Reason==null) _Reason = new List<Hl7.Fhir.Model.CodeableReference>(); return _Reason; }
      set { _Reason = value; OnPropertyChanged("Reason"); }
    }

    private List<Hl7.Fhir.Model.CodeableReference> _Reason;

    /// <summary>
    /// Further information about the usage
    /// </summary>
    [FhirElement("note", Order=210)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    /// <summary>
    /// Link to information relevant to the usage of a medication
    /// </summary>
    [FhirElement("relatedClinicalInformation", Order=220)]
    [CLSCompliant(false)]
    [References("Observation","Condition")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> RelatedClinicalInformation
    {
      get { if(_RelatedClinicalInformation==null) _RelatedClinicalInformation = new List<Hl7.Fhir.Model.ResourceReference>(); return _RelatedClinicalInformation; }
      set { _RelatedClinicalInformation = value; OnPropertyChanged("RelatedClinicalInformation"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _RelatedClinicalInformation;

    /// <summary>
    /// Full representation of the dosage instructions
    /// </summary>
    [FhirElement("renderedDosageInstruction", Order=230)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown RenderedDosageInstructionElement
    {
      get { return _RenderedDosageInstructionElement; }
      set { _RenderedDosageInstructionElement = value; OnPropertyChanged("RenderedDosageInstructionElement"); }
    }

    private Hl7.Fhir.Model.Markdown _RenderedDosageInstructionElement;

    /// <summary>
    /// Full representation of the dosage instructions
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string RenderedDosageInstruction
    {
      get { return RenderedDosageInstructionElement != null ? RenderedDosageInstructionElement.Value : null; }
      set
      {
        if (value == null)
          RenderedDosageInstructionElement = null;
        else
          RenderedDosageInstructionElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("RenderedDosageInstruction");
      }
    }

    /// <summary>
    /// Details of how medication is/was taken or should be taken
    /// </summary>
    [FhirElement("dosage", Order=240)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Dosage> Dosage
    {
      get { if(_Dosage==null) _Dosage = new List<Hl7.Fhir.Model.Dosage>(); return _Dosage; }
      set { _Dosage = value; OnPropertyChanged("Dosage"); }
    }

    private List<Hl7.Fhir.Model.Dosage> _Dosage;

    /// <summary>
    /// Indicates whether the medication is or is not being consumed or administered
    /// </summary>
    [FhirElement("adherence", InSummary=true, Order=250)]
    [DataMember]
    public Hl7.Fhir.Model.MedicationStatement.AdherenceComponent Adherence
    {
      get { return _Adherence; }
      set { _Adherence = value; OnPropertyChanged("Adherence"); }
    }

    private Hl7.Fhir.Model.MedicationStatement.AdherenceComponent _Adherence;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as MedicationStatement;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(PartOf.Any()) dest.PartOf = new List<Hl7.Fhir.Model.ResourceReference>(PartOf.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatementStatusCodes>)StatusElement.DeepCopy();
      if(Category.Any()) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(Medication != null) dest.Medication = (Hl7.Fhir.Model.CodeableReference)Medication.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
      if(Effective != null) dest.Effective = (Hl7.Fhir.Model.DataType)Effective.DeepCopy();
      if(DateAssertedElement != null) dest.DateAssertedElement = (Hl7.Fhir.Model.FhirDateTime)DateAssertedElement.DeepCopy();
      if(InformationSource.Any()) dest.InformationSource = new List<Hl7.Fhir.Model.ResourceReference>(InformationSource.DeepCopy());
      if(DerivedFrom.Any()) dest.DerivedFrom = new List<Hl7.Fhir.Model.ResourceReference>(DerivedFrom.DeepCopy());
      if(Reason.Any()) dest.Reason = new List<Hl7.Fhir.Model.CodeableReference>(Reason.DeepCopy());
      if(Note.Any()) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      if(RelatedClinicalInformation.Any()) dest.RelatedClinicalInformation = new List<Hl7.Fhir.Model.ResourceReference>(RelatedClinicalInformation.DeepCopy());
      if(RenderedDosageInstructionElement != null) dest.RenderedDosageInstructionElement = (Hl7.Fhir.Model.Markdown)RenderedDosageInstructionElement.DeepCopy();
      if(Dosage.Any()) dest.Dosage = new List<Hl7.Fhir.Model.Dosage>(Dosage.DeepCopy());
      if(Adherence != null) dest.Adherence = (Hl7.Fhir.Model.MedicationStatement.AdherenceComponent)Adherence.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new MedicationStatement());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as MedicationStatement;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(Medication, otherT.Medication)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.Matches(Effective, otherT.Effective)) return false;
      if( !DeepComparable.Matches(DateAssertedElement, otherT.DateAssertedElement)) return false;
      if( !DeepComparable.Matches(InformationSource, otherT.InformationSource)) return false;
      if( !DeepComparable.Matches(DerivedFrom, otherT.DerivedFrom)) return false;
      if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;
      if( !DeepComparable.Matches(RelatedClinicalInformation, otherT.RelatedClinicalInformation)) return false;
      if( !DeepComparable.Matches(RenderedDosageInstructionElement, otherT.RenderedDosageInstructionElement)) return false;
      if( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;
      if( !DeepComparable.Matches(Adherence, otherT.Adherence)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as MedicationStatement;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
      if( !DeepComparable.IsExactly(DateAssertedElement, otherT.DateAssertedElement)) return false;
      if( !DeepComparable.IsExactly(InformationSource, otherT.InformationSource)) return false;
      if( !DeepComparable.IsExactly(DerivedFrom, otherT.DerivedFrom)) return false;
      if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
      if( !DeepComparable.IsExactly(RelatedClinicalInformation, otherT.RelatedClinicalInformation)) return false;
      if( !DeepComparable.IsExactly(RenderedDosageInstructionElement, otherT.RenderedDosageInstructionElement)) return false;
      if( !DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;
      if( !DeepComparable.IsExactly(Adherence, otherT.Adherence)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in PartOf) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        if (Medication != null) yield return Medication;
        if (Subject != null) yield return Subject;
        if (Encounter != null) yield return Encounter;
        if (Effective != null) yield return Effective;
        if (DateAssertedElement != null) yield return DateAssertedElement;
        foreach (var elem in InformationSource) { if (elem != null) yield return elem; }
        foreach (var elem in DerivedFrom) { if (elem != null) yield return elem; }
        foreach (var elem in Reason) { if (elem != null) yield return elem; }
        foreach (var elem in Note) { if (elem != null) yield return elem; }
        foreach (var elem in RelatedClinicalInformation) { if (elem != null) yield return elem; }
        if (RenderedDosageInstructionElement != null) yield return RenderedDosageInstructionElement;
        foreach (var elem in Dosage) { if (elem != null) yield return elem; }
        if (Adherence != null) yield return Adherence;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        if (Medication != null) yield return new ElementValue("medication", Medication);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (Encounter != null) yield return new ElementValue("encounter", Encounter);
        if (Effective != null) yield return new ElementValue("effective", Effective);
        if (DateAssertedElement != null) yield return new ElementValue("dateAsserted", DateAssertedElement);
        foreach (var elem in InformationSource) { if (elem != null) yield return new ElementValue("informationSource", elem); }
        foreach (var elem in DerivedFrom) { if (elem != null) yield return new ElementValue("derivedFrom", elem); }
        foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
        foreach (var elem in RelatedClinicalInformation) { if (elem != null) yield return new ElementValue("relatedClinicalInformation", elem); }
        if (RenderedDosageInstructionElement != null) yield return new ElementValue("renderedDosageInstruction", RenderedDosageInstructionElement);
        foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", elem); }
        if (Adherence != null) yield return new ElementValue("adherence", Adherence);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "partOf":
          value = PartOf;
          return PartOf?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "medication":
          value = Medication;
          return Medication is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "encounter":
          value = Encounter;
          return Encounter is not null;
        case "effective":
          value = Effective;
          return Effective is not null;
        case "dateAsserted":
          value = DateAssertedElement;
          return DateAssertedElement is not null;
        case "informationSource":
          value = InformationSource;
          return InformationSource?.Any() == true;
        case "derivedFrom":
          value = DerivedFrom;
          return DerivedFrom?.Any() == true;
        case "reason":
          value = Reason;
          return Reason?.Any() == true;
        case "note":
          value = Note;
          return Note?.Any() == true;
        case "relatedClinicalInformation":
          value = RelatedClinicalInformation;
          return RelatedClinicalInformation?.Any() == true;
        case "renderedDosageInstruction":
          value = RenderedDosageInstructionElement;
          return RenderedDosageInstructionElement is not null;
        case "dosage":
          value = Dosage;
          return Dosage?.Any() == true;
        case "adherence":
          value = Adherence;
          return Adherence is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (PartOf?.Any() == true) yield return new KeyValuePair<string,object>("partOf",PartOf);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (Medication is not null) yield return new KeyValuePair<string,object>("medication",Medication);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Encounter is not null) yield return new KeyValuePair<string,object>("encounter",Encounter);
      if (Effective is not null) yield return new KeyValuePair<string,object>("effective",Effective);
      if (DateAssertedElement is not null) yield return new KeyValuePair<string,object>("dateAsserted",DateAssertedElement);
      if (InformationSource?.Any() == true) yield return new KeyValuePair<string,object>("informationSource",InformationSource);
      if (DerivedFrom?.Any() == true) yield return new KeyValuePair<string,object>("derivedFrom",DerivedFrom);
      if (Reason?.Any() == true) yield return new KeyValuePair<string,object>("reason",Reason);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
      if (RelatedClinicalInformation?.Any() == true) yield return new KeyValuePair<string,object>("relatedClinicalInformation",RelatedClinicalInformation);
      if (RenderedDosageInstructionElement is not null) yield return new KeyValuePair<string,object>("renderedDosageInstruction",RenderedDosageInstructionElement);
      if (Dosage?.Any() == true) yield return new KeyValuePair<string,object>("dosage",Dosage);
      if (Adherence is not null) yield return new KeyValuePair<string,object>("adherence",Adherence);
    }

  }

}

// end of file
