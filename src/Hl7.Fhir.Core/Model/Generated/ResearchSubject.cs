// <auto-generated/>
// Contents of: hl7.fhir.r4b.core version: 4.3.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

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
  /// Physical entity which is the primary unit of interest in the study
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ResearchSubject","http://hl7.org/fhir/StructureDefinition/ResearchSubject", IsResource=true)]
  public partial class ResearchSubject : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ResearchSubject"; } }

    /// <summary>
    /// Indicates the progression of a study subject through a study.
    /// (url: http://hl7.org/fhir/ValueSet/research-subject-status)
    /// (system: http://hl7.org/fhir/research-subject-status)
    /// </summary>
    [FhirEnumeration("ResearchSubjectStatus")]
    public enum ResearchSubjectStatus
    {
      /// <summary>
      /// An identified person that can be considered for inclusion in a study.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("candidate", "http://hl7.org/fhir/research-subject-status"), Description("Candidate")]
      Candidate,
      /// <summary>
      /// A person that has met the eligibility criteria for inclusion in a study.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("eligible", "http://hl7.org/fhir/research-subject-status"), Description("Eligible")]
      Eligible,
      /// <summary>
      /// A person is no longer receiving study intervention and/or being evaluated with tests and procedures according to the protocol, but they are being monitored on a protocol-prescribed schedule.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("follow-up", "http://hl7.org/fhir/research-subject-status"), Description("Follow-up")]
      FollowUp,
      /// <summary>
      /// A person who did not meet one or more criteria required for participation in a study is considered to have failed screening or
      /// is ineligible for the study.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("ineligible", "http://hl7.org/fhir/research-subject-status"), Description("Ineligible")]
      Ineligible,
      /// <summary>
      /// A person for whom registration was not completed.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("not-registered", "http://hl7.org/fhir/research-subject-status"), Description("Not Registered")]
      NotRegistered,
      /// <summary>
      /// A person that has ended their participation on a study either because their treatment/observation is complete or through not
      /// responding, withdrawal, non-compliance and/or adverse event.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("off-study", "http://hl7.org/fhir/research-subject-status"), Description("Off-study")]
      OffStudy,
      /// <summary>
      /// A person that is enrolled or registered on a study.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("on-study", "http://hl7.org/fhir/research-subject-status"), Description("On-study")]
      OnStudy,
      /// <summary>
      /// The person is receiving the treatment or participating in an activity (e.g. yoga, diet, etc.) that the study is evaluating.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("on-study-intervention", "http://hl7.org/fhir/research-subject-status"), Description("On-study-intervention")]
      OnStudyIntervention,
      /// <summary>
      /// The subject is being evaluated via tests and assessments according to the study calendar, but is not receiving any intervention. Note that this state is study-dependent and might not exist in all studies.  A synonym for this is "short-term follow-up".
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("on-study-observation", "http://hl7.org/fhir/research-subject-status"), Description("On-study-observation")]
      OnStudyObservation,
      /// <summary>
      /// A person is pre-registered for a study.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("pending-on-study", "http://hl7.org/fhir/research-subject-status"), Description("Pending on-study")]
      PendingOnStudy,
      /// <summary>
      /// A person that is potentially eligible for participation in the study.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("potential-candidate", "http://hl7.org/fhir/research-subject-status"), Description("Potential Candidate")]
      PotentialCandidate,
      /// <summary>
      /// A person who is being evaluated for eligibility for a study.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("screening", "http://hl7.org/fhir/research-subject-status"), Description("Screening")]
      Screening,
      /// <summary>
      /// The person has withdrawn their participation in the study before registration.
      /// (system: http://hl7.org/fhir/research-subject-status)
      /// </summary>
      [EnumLiteral("withdrawn", "http://hl7.org/fhir/research-subject-status"), Description("Withdrawn")]
      Withdrawn,
    }

    /// <summary>
    /// Business Identifier for research subject in a study
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
    /// candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus> _StatusElement;

    /// <summary>
    /// candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Start and end of participation
    /// </summary>
    [FhirElement("period", InSummary=true, Order=110, FiveWs="FiveWs.planned")]
    [DataMember]
    public Hl7.Fhir.Model.Period Period
    {
      get { return _Period; }
      set { _Period = value; OnPropertyChanged("Period"); }
    }

    private Hl7.Fhir.Model.Period _Period;

    /// <summary>
    /// Study subject is part of
    /// </summary>
    [FhirElement("study", InSummary=true, Order=120)]
    [CLSCompliant(false)]
    [References("ResearchStudy")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Study
    {
      get { return _Study; }
      set { _Study = value; OnPropertyChanged("Study"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Study;

    /// <summary>
    /// Who is part of study
    /// </summary>
    [FhirElement("individual", InSummary=true, Order=130)]
    [CLSCompliant(false)]
    [References("Patient")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Individual
    {
      get { return _Individual; }
      set { _Individual = value; OnPropertyChanged("Individual"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Individual;

    /// <summary>
    /// What path should be followed
    /// </summary>
    [FhirElement("assignedArm", Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString AssignedArmElement
    {
      get { return _AssignedArmElement; }
      set { _AssignedArmElement = value; OnPropertyChanged("AssignedArmElement"); }
    }

    private Hl7.Fhir.Model.FhirString _AssignedArmElement;

    /// <summary>
    /// What path should be followed
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string AssignedArm
    {
      get { return AssignedArmElement != null ? AssignedArmElement.Value : null; }
      set
      {
        if (value == null)
          AssignedArmElement = null;
        else
          AssignedArmElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("AssignedArm");
      }
    }

    /// <summary>
    /// What path was followed
    /// </summary>
    [FhirElement("actualArm", Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString ActualArmElement
    {
      get { return _ActualArmElement; }
      set { _ActualArmElement = value; OnPropertyChanged("ActualArmElement"); }
    }

    private Hl7.Fhir.Model.FhirString _ActualArmElement;

    /// <summary>
    /// What path was followed
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string ActualArm
    {
      get { return ActualArmElement != null ? ActualArmElement.Value : null; }
      set
      {
        if (value == null)
          ActualArmElement = null;
        else
          ActualArmElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("ActualArm");
      }
    }

    /// <summary>
    /// Agreement to participate in study
    /// </summary>
    [FhirElement("consent", Order=160)]
    [CLSCompliant(false)]
    [References("Consent")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Consent
    {
      get { return _Consent; }
      set { _Consent = value; OnPropertyChanged("Consent"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Consent;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ResearchSubject;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus>)StatusElement.DeepCopy();
      if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
      if(Study != null) dest.Study = (Hl7.Fhir.Model.ResourceReference)Study.DeepCopy();
      if(Individual != null) dest.Individual = (Hl7.Fhir.Model.ResourceReference)Individual.DeepCopy();
      if(AssignedArmElement != null) dest.AssignedArmElement = (Hl7.Fhir.Model.FhirString)AssignedArmElement.DeepCopy();
      if(ActualArmElement != null) dest.ActualArmElement = (Hl7.Fhir.Model.FhirString)ActualArmElement.DeepCopy();
      if(Consent != null) dest.Consent = (Hl7.Fhir.Model.ResourceReference)Consent.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ResearchSubject());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ResearchSubject;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Period, otherT.Period)) return false;
      if( !DeepComparable.Matches(Study, otherT.Study)) return false;
      if( !DeepComparable.Matches(Individual, otherT.Individual)) return false;
      if( !DeepComparable.Matches(AssignedArmElement, otherT.AssignedArmElement)) return false;
      if( !DeepComparable.Matches(ActualArmElement, otherT.ActualArmElement)) return false;
      if( !DeepComparable.Matches(Consent, otherT.Consent)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ResearchSubject;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
      if( !DeepComparable.IsExactly(Study, otherT.Study)) return false;
      if( !DeepComparable.IsExactly(Individual, otherT.Individual)) return false;
      if( !DeepComparable.IsExactly(AssignedArmElement, otherT.AssignedArmElement)) return false;
      if( !DeepComparable.IsExactly(ActualArmElement, otherT.ActualArmElement)) return false;
      if( !DeepComparable.IsExactly(Consent, otherT.Consent)) return false;

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
        if (Period != null) yield return Period;
        if (Study != null) yield return Study;
        if (Individual != null) yield return Individual;
        if (AssignedArmElement != null) yield return AssignedArmElement;
        if (ActualArmElement != null) yield return ActualArmElement;
        if (Consent != null) yield return Consent;
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
        if (Period != null) yield return new ElementValue("period", Period);
        if (Study != null) yield return new ElementValue("study", Study);
        if (Individual != null) yield return new ElementValue("individual", Individual);
        if (AssignedArmElement != null) yield return new ElementValue("assignedArm", AssignedArmElement);
        if (ActualArmElement != null) yield return new ElementValue("actualArm", ActualArmElement);
        if (Consent != null) yield return new ElementValue("consent", Consent);
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
        case "period":
          value = Period;
          return Period is not null;
        case "study":
          value = Study;
          return Study is not null;
        case "individual":
          value = Individual;
          return Individual is not null;
        case "assignedArm":
          value = AssignedArmElement;
          return AssignedArmElement is not null;
        case "actualArm":
          value = ActualArmElement;
          return ActualArmElement is not null;
        case "consent":
          value = Consent;
          return Consent is not null;
        default:
          return base.TryGetValue(key, out value);
      };

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      if (Study is not null) yield return new KeyValuePair<string,object>("study",Study);
      if (Individual is not null) yield return new KeyValuePair<string,object>("individual",Individual);
      if (AssignedArmElement is not null) yield return new KeyValuePair<string,object>("assignedArm",AssignedArmElement);
      if (ActualArmElement is not null) yield return new KeyValuePair<string,object>("actualArm",ActualArmElement);
      if (Consent is not null) yield return new KeyValuePair<string,object>("consent",Consent);
    }

  }

}

// end of file
