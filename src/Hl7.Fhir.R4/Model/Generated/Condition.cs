// <auto-generated/>
// Contents of: hl7.fhir.r4.expansions#4.0.1, hl7.fhir.r4.core#4.0.1

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
  /// Detailed information about conditions, problems or diagnoses
  /// </summary>
  /// <remarks>
  /// A clinical condition, problem, diagnosis, or other event, situation, issue, or clinical concept that has risen to a level of concern.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("Condition","http://hl7.org/fhir/StructureDefinition/Condition", IsResource=true)]
  public partial class Condition : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>, ICoded<Hl7.Fhir.Model.CodeableConcept>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Condition"; } }

    /// <summary>
    /// Preferred value set for Condition Clinical Status.
    /// (url: http://hl7.org/fhir/ValueSet/condition-clinical)
    /// (system: http://terminology.hl7.org/CodeSystem/condition-clinical)
    /// </summary>
    [FhirEnumeration("ConditionClinicalStatusCodes", "http://hl7.org/fhir/ValueSet/condition-clinical", "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public enum ConditionClinicalStatusCodes
    {
      /// <summary>
      /// The subject is currently experiencing the symptoms of the condition or there is evidence of the condition.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-clinical)
      /// </summary>
      [EnumLiteral("active"), Description("Active")]
      Active,
      /// <summary>
      /// The subject is experiencing a re-occurence or repeating of a previously resolved condition, e.g. urinary tract infection, pancreatitis, cholangitis, conjunctivitis.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-clinical)
      /// </summary>
      [EnumLiteral("recurrence"), Description("Recurrence")]
      Recurrence,
      /// <summary>
      /// The subject is experiencing a return of a condition, or signs and symptoms after a period of improvement or remission, e.g. relapse of cancer, multiple sclerosis, rheumatoid arthritis, systemic lupus erythematosus, bipolar disorder, [psychotic relapse of] schizophrenia, etc.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-clinical)
      /// </summary>
      [EnumLiteral("relapse"), Description("Relapse")]
      Relapse,
      /// <summary>
      /// The subject is no longer experiencing the symptoms of the condition or there is no longer evidence of the condition.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-clinical)
      /// </summary>
      [EnumLiteral("inactive"), Description("Inactive")]
      Inactive,
      /// <summary>
      /// The subject is no longer experiencing the symptoms of the condition, but there is a risk of the symptoms returning.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-clinical)
      /// </summary>
      [EnumLiteral("remission"), Description("Remission")]
      Remission,
      /// <summary>
      /// The subject is no longer experiencing the symptoms of the condition and there is a negligible perceived risk of the symptoms returning.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-clinical)
      /// </summary>
      [EnumLiteral("resolved"), Description("Resolved")]
      Resolved,
    }

    /// <summary>
    /// The verification status to support or decline the clinical status of the condition or diagnosis.
    /// (url: http://hl7.org/fhir/ValueSet/condition-ver-status)
    /// (system: http://terminology.hl7.org/CodeSystem/condition-ver-status)
    /// </summary>
    [FhirEnumeration("ConditionVerificationStatus", "http://hl7.org/fhir/ValueSet/condition-ver-status", "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public enum ConditionVerificationStatus
    {
      /// <summary>
      /// There is not sufficient diagnostic and/or clinical evidence to treat this as a confirmed condition.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-ver-status)
      /// </summary>
      [EnumLiteral("unconfirmed"), Description("Unconfirmed")]
      Unconfirmed,
      /// <summary>
      /// This is a tentative diagnosis - still a candidate that is under consideration.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-ver-status)
      /// </summary>
      [EnumLiteral("provisional"), Description("Provisional")]
      Provisional,
      /// <summary>
      /// One of a set of potential (and typically mutually exclusive) diagnoses asserted to further guide the diagnostic process and preliminary treatment.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-ver-status)
      /// </summary>
      [EnumLiteral("differential"), Description("Differential")]
      Differential,
      /// <summary>
      /// There is sufficient diagnostic and/or clinical evidence to treat this as a confirmed condition.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-ver-status)
      /// </summary>
      [EnumLiteral("confirmed"), Description("Confirmed")]
      Confirmed,
      /// <summary>
      /// This condition has been ruled out by diagnostic and clinical evidence.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-ver-status)
      /// </summary>
      [EnumLiteral("refuted"), Description("Refuted")]
      Refuted,
      /// <summary>
      /// The statement was entered in error and is not valid.
      /// (system: http://terminology.hl7.org/CodeSystem/condition-ver-status)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in Error")]
      EnteredInError,
    }

    /// <summary>
    /// Stage/grade, usually assessed formally
    /// </summary>
    /// <remarks>
    /// Clinical stage or grade of a condition. May include formal severity assessments.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("Condition#Stage", IsNestedType=true)]
    [BackboneType("Condition.stage")]
    public partial class StageComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Condition#Stage"; } }

      /// <summary>
      /// Simple summary (disease specific)
      /// </summary>
      [FhirElement("summary", Order=40)]
      [Binding("ConditionStage")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Summary
      {
        get { return _Summary; }
        set { _Summary = value; OnPropertyChanged("Summary"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Summary;

      /// <summary>
      /// Formal record of assessment
      /// </summary>
      [FhirElement("assessment", Order=50)]
      [CLSCompliant(false)]
      [References("ClinicalImpression","DiagnosticReport","Observation")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ResourceReference> Assessment
      {
        get { if(_Assessment==null) _Assessment = new List<Hl7.Fhir.Model.ResourceReference>(); return _Assessment; }
        set { _Assessment = value; OnPropertyChanged("Assessment"); }
      }

      private List<Hl7.Fhir.Model.ResourceReference> _Assessment;

      /// <summary>
      /// Kind of staging
      /// </summary>
      [FhirElement("type", Order=60)]
      [Binding("ConditionStageType")]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Type
      {
        get { return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Type;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as StageComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Summary != null) dest.Summary = (Hl7.Fhir.Model.CodeableConcept)Summary.DeepCopy();
        if(Assessment.Any()) dest.Assessment = new List<Hl7.Fhir.Model.ResourceReference>(Assessment.DeepCopy());
        if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new StageComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as StageComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Summary, otherT.Summary)) return false;
        if( !DeepComparable.Matches(Assessment, otherT.Assessment)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as StageComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Summary, otherT.Summary)) return false;
        if( !DeepComparable.IsExactly(Assessment, otherT.Assessment)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Summary != null) yield return Summary;
          foreach (var elem in Assessment) { if (elem != null) yield return elem; }
          if (Type != null) yield return Type;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Summary != null) yield return new ElementValue("summary", Summary);
          foreach (var elem in Assessment) { if (elem != null) yield return new ElementValue("assessment", elem); }
          if (Type != null) yield return new ElementValue("type", Type);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "summary":
            value = Summary;
            return Summary is not null;
          case "assessment":
            value = Assessment;
            return Assessment?.Any() == true;
          case "type":
            value = Type;
            return Type is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Summary is not null) yield return new KeyValuePair<string,object>("summary",Summary);
        if (Assessment?.Any() == true) yield return new KeyValuePair<string,object>("assessment",Assessment);
        if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
      }

    }

    /// <summary>
    /// Supporting evidence
    /// </summary>
    /// <remarks>
    /// Supporting evidence / manifestations that are the basis of the Condition's verification status, such as evidence that confirmed or refuted the condition.
    /// The evidence may be a simple list of coded symptoms/manifestations, or references to observations or formal assessments, or both.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("Condition#Evidence", IsNestedType=true)]
    [BackboneType("Condition.evidence")]
    public partial class EvidenceComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Condition#Evidence"; } }

      /// <summary>
      /// Manifestation/symptom
      /// </summary>
      [FhirElement("code", InSummary=true, Order=40, FiveWs="FiveWs.why[x]")]
      [Binding("ManifestationOrSymptom")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> Code
      {
        get { if(_Code==null) _Code = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _Code;

      /// <summary>
      /// Supporting information found elsewhere
      /// </summary>
      [FhirElement("detail", InSummary=true, Order=50, FiveWs="FiveWs.why[x]")]
      [CLSCompliant(false)]
      [References("Resource")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ResourceReference> Detail
      {
        get { if(_Detail==null) _Detail = new List<Hl7.Fhir.Model.ResourceReference>(); return _Detail; }
        set { _Detail = value; OnPropertyChanged("Detail"); }
      }

      private List<Hl7.Fhir.Model.ResourceReference> _Detail;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as EvidenceComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code.Any()) dest.Code = new List<Hl7.Fhir.Model.CodeableConcept>(Code.DeepCopy());
        if(Detail.Any()) dest.Detail = new List<Hl7.Fhir.Model.ResourceReference>(Detail.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new EvidenceComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as EvidenceComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as EvidenceComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          foreach (var elem in Code) { if (elem != null) yield return elem; }
          foreach (var elem in Detail) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
          foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code?.Any() == true;
          case "detail":
            value = Detail;
            return Detail?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code?.Any() == true) yield return new KeyValuePair<string,object>("code",Code);
        if (Detail?.Any() == true) yield return new KeyValuePair<string,object>("detail",Detail);
      }

    }

    /// <summary>
    /// External Ids for this condition
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
    /// active | recurrence | relapse | inactive | remission | resolved
    /// </summary>
    [FhirElement("clinicalStatus", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.status")]
    [Binding("ConditionClinicalStatus")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept ClinicalStatus
    {
      get { return _ClinicalStatus; }
      set { _ClinicalStatus = value; OnPropertyChanged("ClinicalStatus"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _ClinicalStatus;

    /// <summary>
    /// unconfirmed | provisional | differential | confirmed | refuted | entered-in-error
    /// </summary>
    [FhirElement("verificationStatus", InSummary=true, IsModifier=true, Order=110, FiveWs="FiveWs.status")]
    [Binding("ConditionVerificationStatus")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept VerificationStatus
    {
      get { return _VerificationStatus; }
      set { _VerificationStatus = value; OnPropertyChanged("VerificationStatus"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _VerificationStatus;

    /// <summary>
    /// problem-list-item | encounter-diagnosis
    /// </summary>
    [FhirElement("category", Order=120, FiveWs="FiveWs.class")]
    [Binding("ConditionCategory")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// Subjective severity of condition
    /// </summary>
    [FhirElement("severity", Order=130, FiveWs="FiveWs.grade")]
    [Binding("ConditionSeverity")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Severity
    {
      get { return _Severity; }
      set { _Severity = value; OnPropertyChanged("Severity"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Severity;

    /// <summary>
    /// Identification of the condition, problem or diagnosis
    /// </summary>
    [FhirElement("code", InSummary=true, Order=140, FiveWs="FiveWs.what[x]")]
    [Binding("ConditionKind")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Code
    {
      get { return _Code; }
      set { _Code = value; OnPropertyChanged("Code"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Code;

    /// <summary>
    /// Anatomical location, if relevant
    /// </summary>
    [FhirElement("bodySite", InSummary=true, Order=150)]
    [Binding("BodySite")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> BodySite
    {
      get { if(_BodySite==null) _BodySite = new List<Hl7.Fhir.Model.CodeableConcept>(); return _BodySite; }
      set { _BodySite = value; OnPropertyChanged("BodySite"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _BodySite;

    /// <summary>
    /// Who has the condition?
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=160, FiveWs="FiveWs.subject")]
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
    /// Encounter created as part of
    /// </summary>
    [FhirElement("encounter", InSummary=true, Order=170, FiveWs="FiveWs.context")]
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
    /// Estimated or actual date,  date-time, or age
    /// </summary>
    [FhirElement("onset", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.init")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Age),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.FhirString))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Onset
    {
      get { return _Onset; }
      set { _Onset = value; OnPropertyChanged("Onset"); }
    }

    private Hl7.Fhir.Model.DataType _Onset;

    /// <summary>
    /// When in resolution/remission
    /// </summary>
    [FhirElement("abatement", Order=190, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.done[x]")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Age),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.FhirString))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Abatement
    {
      get { return _Abatement; }
      set { _Abatement = value; OnPropertyChanged("Abatement"); }
    }

    private Hl7.Fhir.Model.DataType _Abatement;

    /// <summary>
    /// Date record was first recorded
    /// </summary>
    [FhirElement("recordedDate", InSummary=true, Order=200, FiveWs="FiveWs.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime RecordedDateElement
    {
      get { return _RecordedDateElement; }
      set { _RecordedDateElement = value; OnPropertyChanged("RecordedDateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _RecordedDateElement;

    /// <summary>
    /// Date record was first recorded
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string RecordedDate
    {
      get { return RecordedDateElement != null ? RecordedDateElement.Value : null; }
      set
      {
        if (value == null)
          RecordedDateElement = null;
        else
          RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("RecordedDate");
      }
    }

    /// <summary>
    /// Who recorded the condition
    /// </summary>
    [FhirElement("recorder", InSummary=true, Order=210, FiveWs="FiveWs.author")]
    [CLSCompliant(false)]
    [References("Practitioner","PractitionerRole","Patient","RelatedPerson")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Recorder
    {
      get { return _Recorder; }
      set { _Recorder = value; OnPropertyChanged("Recorder"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Recorder;

    /// <summary>
    /// Person who asserts this condition
    /// </summary>
    [FhirElement("asserter", InSummary=true, Order=220, FiveWs="FiveWs.source")]
    [CLSCompliant(false)]
    [References("Practitioner","PractitionerRole","Patient","RelatedPerson")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Asserter
    {
      get { return _Asserter; }
      set { _Asserter = value; OnPropertyChanged("Asserter"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Asserter;

    /// <summary>
    /// Stage/grade, usually assessed formally
    /// </summary>
    [FhirElement("stage", Order=230)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Condition.StageComponent> Stage
    {
      get { if(_Stage==null) _Stage = new List<Hl7.Fhir.Model.Condition.StageComponent>(); return _Stage; }
      set { _Stage = value; OnPropertyChanged("Stage"); }
    }

    private List<Hl7.Fhir.Model.Condition.StageComponent> _Stage;

    /// <summary>
    /// Supporting evidence
    /// </summary>
    [FhirElement("evidence", Order=240)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Condition.EvidenceComponent> Evidence
    {
      get { if(_Evidence==null) _Evidence = new List<Hl7.Fhir.Model.Condition.EvidenceComponent>(); return _Evidence; }
      set { _Evidence = value; OnPropertyChanged("Evidence"); }
    }

    private List<Hl7.Fhir.Model.Condition.EvidenceComponent> _Evidence;

    /// <summary>
    /// Additional information about the Condition
    /// </summary>
    [FhirElement("note", Order=250)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    Hl7.Fhir.Model.CodeableConcept ICoded<Hl7.Fhir.Model.CodeableConcept>.Code { get => Code; set => Code = value; }
    IEnumerable<Coding> ICoded.ToCodings() => Code.ToCodings();

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Condition;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(ClinicalStatus != null) dest.ClinicalStatus = (Hl7.Fhir.Model.CodeableConcept)ClinicalStatus.DeepCopy();
      if(VerificationStatus != null) dest.VerificationStatus = (Hl7.Fhir.Model.CodeableConcept)VerificationStatus.DeepCopy();
      if(Category.Any()) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(Severity != null) dest.Severity = (Hl7.Fhir.Model.CodeableConcept)Severity.DeepCopy();
      if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
      if(BodySite.Any()) dest.BodySite = new List<Hl7.Fhir.Model.CodeableConcept>(BodySite.DeepCopy());
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
      if(Onset != null) dest.Onset = (Hl7.Fhir.Model.DataType)Onset.DeepCopy();
      if(Abatement != null) dest.Abatement = (Hl7.Fhir.Model.DataType)Abatement.DeepCopy();
      if(RecordedDateElement != null) dest.RecordedDateElement = (Hl7.Fhir.Model.FhirDateTime)RecordedDateElement.DeepCopy();
      if(Recorder != null) dest.Recorder = (Hl7.Fhir.Model.ResourceReference)Recorder.DeepCopy();
      if(Asserter != null) dest.Asserter = (Hl7.Fhir.Model.ResourceReference)Asserter.DeepCopy();
      if(Stage.Any()) dest.Stage = new List<Hl7.Fhir.Model.Condition.StageComponent>(Stage.DeepCopy());
      if(Evidence.Any()) dest.Evidence = new List<Hl7.Fhir.Model.Condition.EvidenceComponent>(Evidence.DeepCopy());
      if(Note.Any()) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Condition());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Condition;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(ClinicalStatus, otherT.ClinicalStatus)) return false;
      if( !DeepComparable.Matches(VerificationStatus, otherT.VerificationStatus)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(Severity, otherT.Severity)) return false;
      if( !DeepComparable.Matches(Code, otherT.Code)) return false;
      if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.Matches(Onset, otherT.Onset)) return false;
      if( !DeepComparable.Matches(Abatement, otherT.Abatement)) return false;
      if( !DeepComparable.Matches(RecordedDateElement, otherT.RecordedDateElement)) return false;
      if( !DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
      if( !DeepComparable.Matches(Asserter, otherT.Asserter)) return false;
      if( !DeepComparable.Matches(Stage, otherT.Stage)) return false;
      if( !DeepComparable.Matches(Evidence, otherT.Evidence)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Condition;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(ClinicalStatus, otherT.ClinicalStatus)) return false;
      if( !DeepComparable.IsExactly(VerificationStatus, otherT.VerificationStatus)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(Severity, otherT.Severity)) return false;
      if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
      if( !DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
      if( !DeepComparable.IsExactly(Onset, otherT.Onset)) return false;
      if( !DeepComparable.IsExactly(Abatement, otherT.Abatement)) return false;
      if( !DeepComparable.IsExactly(RecordedDateElement, otherT.RecordedDateElement)) return false;
      if( !DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
      if( !DeepComparable.IsExactly(Asserter, otherT.Asserter)) return false;
      if( !DeepComparable.IsExactly(Stage, otherT.Stage)) return false;
      if( !DeepComparable.IsExactly(Evidence, otherT.Evidence)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (ClinicalStatus != null) yield return ClinicalStatus;
        if (VerificationStatus != null) yield return VerificationStatus;
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        if (Severity != null) yield return Severity;
        if (Code != null) yield return Code;
        foreach (var elem in BodySite) { if (elem != null) yield return elem; }
        if (Subject != null) yield return Subject;
        if (Encounter != null) yield return Encounter;
        if (Onset != null) yield return Onset;
        if (Abatement != null) yield return Abatement;
        if (RecordedDateElement != null) yield return RecordedDateElement;
        if (Recorder != null) yield return Recorder;
        if (Asserter != null) yield return Asserter;
        foreach (var elem in Stage) { if (elem != null) yield return elem; }
        foreach (var elem in Evidence) { if (elem != null) yield return elem; }
        foreach (var elem in Note) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (ClinicalStatus != null) yield return new ElementValue("clinicalStatus", ClinicalStatus);
        if (VerificationStatus != null) yield return new ElementValue("verificationStatus", VerificationStatus);
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        if (Severity != null) yield return new ElementValue("severity", Severity);
        if (Code != null) yield return new ElementValue("code", Code);
        foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", elem); }
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (Encounter != null) yield return new ElementValue("encounter", Encounter);
        if (Onset != null) yield return new ElementValue("onset", Onset);
        if (Abatement != null) yield return new ElementValue("abatement", Abatement);
        if (RecordedDateElement != null) yield return new ElementValue("recordedDate", RecordedDateElement);
        if (Recorder != null) yield return new ElementValue("recorder", Recorder);
        if (Asserter != null) yield return new ElementValue("asserter", Asserter);
        foreach (var elem in Stage) { if (elem != null) yield return new ElementValue("stage", elem); }
        foreach (var elem in Evidence) { if (elem != null) yield return new ElementValue("evidence", elem); }
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "clinicalStatus":
          value = ClinicalStatus;
          return ClinicalStatus is not null;
        case "verificationStatus":
          value = VerificationStatus;
          return VerificationStatus is not null;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "severity":
          value = Severity;
          return Severity is not null;
        case "code":
          value = Code;
          return Code is not null;
        case "bodySite":
          value = BodySite;
          return BodySite?.Any() == true;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "encounter":
          value = Encounter;
          return Encounter is not null;
        case "onset":
          value = Onset;
          return Onset is not null;
        case "abatement":
          value = Abatement;
          return Abatement is not null;
        case "recordedDate":
          value = RecordedDateElement;
          return RecordedDateElement is not null;
        case "recorder":
          value = Recorder;
          return Recorder is not null;
        case "asserter":
          value = Asserter;
          return Asserter is not null;
        case "stage":
          value = Stage;
          return Stage?.Any() == true;
        case "evidence":
          value = Evidence;
          return Evidence?.Any() == true;
        case "note":
          value = Note;
          return Note?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (ClinicalStatus is not null) yield return new KeyValuePair<string,object>("clinicalStatus",ClinicalStatus);
      if (VerificationStatus is not null) yield return new KeyValuePair<string,object>("verificationStatus",VerificationStatus);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (Severity is not null) yield return new KeyValuePair<string,object>("severity",Severity);
      if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
      if (BodySite?.Any() == true) yield return new KeyValuePair<string,object>("bodySite",BodySite);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Encounter is not null) yield return new KeyValuePair<string,object>("encounter",Encounter);
      if (Onset is not null) yield return new KeyValuePair<string,object>("onset",Onset);
      if (Abatement is not null) yield return new KeyValuePair<string,object>("abatement",Abatement);
      if (RecordedDateElement is not null) yield return new KeyValuePair<string,object>("recordedDate",RecordedDateElement);
      if (Recorder is not null) yield return new KeyValuePair<string,object>("recorder",Recorder);
      if (Asserter is not null) yield return new KeyValuePair<string,object>("asserter",Asserter);
      if (Stage?.Any() == true) yield return new KeyValuePair<string,object>("stage",Stage);
      if (Evidence?.Any() == true) yield return new KeyValuePair<string,object>("evidence",Evidence);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
    }

  }

}

// end of file
