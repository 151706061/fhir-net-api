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
  /// A slot of time on a schedule that may be available for booking appointments
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Slot","http://hl7.org/fhir/StructureDefinition/Slot", IsResource=true)]
  public partial class Slot : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Slot"; } }

    /// <summary>
    /// The free/busy status of the slot.
    /// (url: http://hl7.org/fhir/ValueSet/slotstatus)
    /// (system: http://hl7.org/fhir/slotstatus)
    /// </summary>
    [FhirEnumeration("SlotStatus", "http://hl7.org/fhir/ValueSet/slotstatus", "http://hl7.org/fhir/slotstatus")]
    public enum SlotStatus
    {
      /// <summary>
      /// Indicates that the time interval is busy because one  or more events have been scheduled for that interval.
      /// (system: http://hl7.org/fhir/slotstatus)
      /// </summary>
      [EnumLiteral("busy"), Description("Busy")]
      Busy,
      /// <summary>
      /// Indicates that the time interval is free for scheduling.
      /// (system: http://hl7.org/fhir/slotstatus)
      /// </summary>
      [EnumLiteral("free"), Description("Free")]
      Free,
      /// <summary>
      /// Indicates that the time interval is busy and that the interval cannot be scheduled.
      /// (system: http://hl7.org/fhir/slotstatus)
      /// </summary>
      [EnumLiteral("busy-unavailable"), Description("Busy (Unavailable)")]
      BusyUnavailable,
      /// <summary>
      /// Indicates that the time interval is busy because one or more events have been tentatively scheduled for that interval.
      /// (system: http://hl7.org/fhir/slotstatus)
      /// </summary>
      [EnumLiteral("busy-tentative"), Description("Busy (Tentative)")]
      BusyTentative,
      /// <summary>
      /// This instance should not have been part of this patient's medical record.
      /// (system: http://hl7.org/fhir/slotstatus)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in error")]
      EnteredInError,
    }

    /// <summary>
    /// External Ids for this item
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
    /// A broad categorization of the service that is to be performed during this appointment
    /// </summary>
    [FhirElement("serviceCategory", InSummary=true, Order=100, FiveWs="FiveWs.class")]
    [Binding("service-category")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ServiceCategory
    {
      get { if(_ServiceCategory==null) _ServiceCategory = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ServiceCategory; }
      set { _ServiceCategory = value; OnPropertyChanged("ServiceCategory"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ServiceCategory;

    /// <summary>
    /// The type of appointments that can be booked into this slot (ideally this would be an identifiable service - which is at a location, rather than the location itself). If provided then this overrides the value provided on the availability resource
    /// </summary>
    [FhirElement("serviceType", InSummary=true, Order=110, FiveWs="FiveWs.class")]
    [Binding("service-type")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ServiceType
    {
      get { if(_ServiceType==null) _ServiceType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ServiceType; }
      set { _ServiceType = value; OnPropertyChanged("ServiceType"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ServiceType;

    /// <summary>
    /// The specialty of a practitioner that would be required to perform the service requested in this appointment
    /// </summary>
    [FhirElement("specialty", InSummary=true, Order=120, FiveWs="FiveWs.class")]
    [Binding("specialty")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Specialty
    {
      get { if(_Specialty==null) _Specialty = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Specialty; }
      set { _Specialty = value; OnPropertyChanged("Specialty"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Specialty;

    /// <summary>
    /// The style of appointment or patient that may be booked in the slot (not service type)
    /// </summary>
    [FhirElement("appointmentType", InSummary=true, Order=130, FiveWs="FiveWs.class")]
    [Binding("appointment-type")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept AppointmentType
    {
      get { return _AppointmentType; }
      set { _AppointmentType = value; OnPropertyChanged("AppointmentType"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _AppointmentType;

    /// <summary>
    /// The schedule resource that this slot defines an interval of status information
    /// </summary>
    [FhirElement("schedule", InSummary=true, Order=140)]
    [CLSCompliant(false)]
    [References("Schedule")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Schedule
    {
      get { return _Schedule; }
      set { _Schedule = value; OnPropertyChanged("Schedule"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Schedule;

    /// <summary>
    /// busy | free | busy-unavailable | busy-tentative | entered-in-error
    /// </summary>
    [FhirElement("status", InSummary=true, Order=150)]
    [DeclaredType(Type = typeof(Code))]
    [Binding("SlotStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.Slot.SlotStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.Slot.SlotStatus> _StatusElement;

    /// <summary>
    /// busy | free | busy-unavailable | busy-tentative | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.Slot.SlotStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.Slot.SlotStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Date/Time that the slot is to begin
    /// </summary>
    [FhirElement("start", InSummary=true, Order=160, FiveWs="FiveWs.planned")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.Instant StartElement
    {
      get { return _StartElement; }
      set { _StartElement = value; OnPropertyChanged("StartElement"); }
    }

    private Hl7.Fhir.Model.Instant _StartElement;

    /// <summary>
    /// Date/Time that the slot is to begin
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public DateTimeOffset? Start
    {
      get { return StartElement != null ? StartElement.Value : null; }
      set
      {
        if (value == null)
          StartElement = null;
        else
          StartElement = new Hl7.Fhir.Model.Instant(value);
        OnPropertyChanged("Start");
      }
    }

    /// <summary>
    /// Date/Time that the slot is to conclude
    /// </summary>
    [FhirElement("end", InSummary=true, Order=170, FiveWs="FiveWs.planned")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.Instant EndElement
    {
      get { return _EndElement; }
      set { _EndElement = value; OnPropertyChanged("EndElement"); }
    }

    private Hl7.Fhir.Model.Instant _EndElement;

    /// <summary>
    /// Date/Time that the slot is to conclude
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public DateTimeOffset? End
    {
      get { return EndElement != null ? EndElement.Value : null; }
      set
      {
        if (value == null)
          EndElement = null;
        else
          EndElement = new Hl7.Fhir.Model.Instant(value);
        OnPropertyChanged("End");
      }
    }

    /// <summary>
    /// This slot has already been overbooked, appointments are unlikely to be accepted for this time
    /// </summary>
    [FhirElement("overbooked", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean OverbookedElement
    {
      get { return _OverbookedElement; }
      set { _OverbookedElement = value; OnPropertyChanged("OverbookedElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _OverbookedElement;

    /// <summary>
    /// This slot has already been overbooked, appointments are unlikely to be accepted for this time
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Overbooked
    {
      get { return OverbookedElement != null ? OverbookedElement.Value : null; }
      set
      {
        if (value == null)
          OverbookedElement = null;
        else
          OverbookedElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Overbooked");
      }
    }

    /// <summary>
    /// Comments on the slot to describe any extended information. Such as custom constraints on the slot
    /// </summary>
    [FhirElement("comment", Order=190)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString CommentElement
    {
      get { return _CommentElement; }
      set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
    }

    private Hl7.Fhir.Model.FhirString _CommentElement;

    /// <summary>
    /// Comments on the slot to describe any extended information. Such as custom constraints on the slot
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

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Slot;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(ServiceCategory != null) dest.ServiceCategory = new List<Hl7.Fhir.Model.CodeableConcept>(ServiceCategory.DeepCopy());
      if(ServiceType != null) dest.ServiceType = new List<Hl7.Fhir.Model.CodeableConcept>(ServiceType.DeepCopy());
      if(Specialty != null) dest.Specialty = new List<Hl7.Fhir.Model.CodeableConcept>(Specialty.DeepCopy());
      if(AppointmentType != null) dest.AppointmentType = (Hl7.Fhir.Model.CodeableConcept)AppointmentType.DeepCopy();
      if(Schedule != null) dest.Schedule = (Hl7.Fhir.Model.ResourceReference)Schedule.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.Slot.SlotStatus>)StatusElement.DeepCopy();
      if(StartElement != null) dest.StartElement = (Hl7.Fhir.Model.Instant)StartElement.DeepCopy();
      if(EndElement != null) dest.EndElement = (Hl7.Fhir.Model.Instant)EndElement.DeepCopy();
      if(OverbookedElement != null) dest.OverbookedElement = (Hl7.Fhir.Model.FhirBoolean)OverbookedElement.DeepCopy();
      if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Slot());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Slot;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(ServiceCategory, otherT.ServiceCategory)) return false;
      if( !DeepComparable.Matches(ServiceType, otherT.ServiceType)) return false;
      if( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
      if( !DeepComparable.Matches(AppointmentType, otherT.AppointmentType)) return false;
      if( !DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
      if( !DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
      if( !DeepComparable.Matches(OverbookedElement, otherT.OverbookedElement)) return false;
      if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Slot;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(ServiceCategory, otherT.ServiceCategory)) return false;
      if( !DeepComparable.IsExactly(ServiceType, otherT.ServiceType)) return false;
      if( !DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
      if( !DeepComparable.IsExactly(AppointmentType, otherT.AppointmentType)) return false;
      if( !DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
      if( !DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
      if( !DeepComparable.IsExactly(OverbookedElement, otherT.OverbookedElement)) return false;
      if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in ServiceCategory) { if (elem != null) yield return elem; }
        foreach (var elem in ServiceType) { if (elem != null) yield return elem; }
        foreach (var elem in Specialty) { if (elem != null) yield return elem; }
        if (AppointmentType != null) yield return AppointmentType;
        if (Schedule != null) yield return Schedule;
        if (StatusElement != null) yield return StatusElement;
        if (StartElement != null) yield return StartElement;
        if (EndElement != null) yield return EndElement;
        if (OverbookedElement != null) yield return OverbookedElement;
        if (CommentElement != null) yield return CommentElement;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in ServiceCategory) { if (elem != null) yield return new ElementValue("serviceCategory", elem); }
        foreach (var elem in ServiceType) { if (elem != null) yield return new ElementValue("serviceType", elem); }
        foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", elem); }
        if (AppointmentType != null) yield return new ElementValue("appointmentType", AppointmentType);
        if (Schedule != null) yield return new ElementValue("schedule", Schedule);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (StartElement != null) yield return new ElementValue("start", StartElement);
        if (EndElement != null) yield return new ElementValue("end", EndElement);
        if (OverbookedElement != null) yield return new ElementValue("overbooked", OverbookedElement);
        if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "serviceCategory":
          value = ServiceCategory;
          return ServiceCategory?.Any() == true;
        case "serviceType":
          value = ServiceType;
          return ServiceType?.Any() == true;
        case "specialty":
          value = Specialty;
          return Specialty?.Any() == true;
        case "appointmentType":
          value = AppointmentType;
          return AppointmentType is not null;
        case "schedule":
          value = Schedule;
          return Schedule is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "start":
          value = StartElement;
          return StartElement is not null;
        case "end":
          value = EndElement;
          return EndElement is not null;
        case "overbooked":
          value = OverbookedElement;
          return OverbookedElement is not null;
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
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (ServiceCategory?.Any() == true) yield return new KeyValuePair<string,object>("serviceCategory",ServiceCategory);
      if (ServiceType?.Any() == true) yield return new KeyValuePair<string,object>("serviceType",ServiceType);
      if (Specialty?.Any() == true) yield return new KeyValuePair<string,object>("specialty",Specialty);
      if (AppointmentType is not null) yield return new KeyValuePair<string,object>("appointmentType",AppointmentType);
      if (Schedule is not null) yield return new KeyValuePair<string,object>("schedule",Schedule);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (StartElement is not null) yield return new KeyValuePair<string,object>("start",StartElement);
      if (EndElement is not null) yield return new KeyValuePair<string,object>("end",EndElement);
      if (OverbookedElement is not null) yield return new KeyValuePair<string,object>("overbooked",OverbookedElement);
      if (CommentElement is not null) yield return new KeyValuePair<string,object>("comment",CommentElement);
    }

  }

}

// end of file
