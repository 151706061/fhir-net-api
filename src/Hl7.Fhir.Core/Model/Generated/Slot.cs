﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

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

//
// Generated on Fri, Dec 5, 2014 10:08+0100 for FHIR v0.3.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// (informative) A slot of time on a schedule that may be available for booking appointments
    /// </summary>
    [FhirType("Slot", IsResource=true)]
    [DataContract]
    public partial class Slot : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        public override ResourceType ResourceType { get { return ResourceType.Slot; } }
        public override string TypeName { get { return "Slot"; } }
        
        /// <summary>
        /// The free/busy status of an appointment
        /// </summary>
        [FhirEnumeration("SlotStatus")]
        public enum SlotStatus
        {
            /// <summary>
            /// Indicates that the time interval is busy because one  or more events have been scheduled for that interval.
            /// </summary>
            [EnumLiteral("BUSY")]
            BUSY,
            /// <summary>
            /// Indicates that the time interval is free for scheduling.
            /// </summary>
            [EnumLiteral("FREE")]
            FREE,
            /// <summary>
            /// Indicates that the time interval is busy and that the interval can not be scheduled.
            /// </summary>
            [EnumLiteral("BUSY-UNAVAILABLE")]
            BUSYUNAVAILABLE,
            /// <summary>
            /// Indicates that the time interval is busy because one or more events have been tentatively scheduled for that interval.
            /// </summary>
            [EnumLiteral("BUSY-TENTATIVE")]
            BUSYTENTATIVE,
        }
        
        /// <summary>
        /// External Ids for this item
        /// </summary>
        [FhirElement("identifier", Order=50)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// The type of appointments that can be booked into this slot (ideally this would be an identifiable service - which is at a location, rather than the location itself). If provided then this overrides the value provided on the availability resource
        /// </summary>
        [FhirElement("type", Order=60)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// The availability resource that this slot defines an interval of status information
        /// </summary>
        [FhirElement("availability", Order=70)]
        [References("Availability")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Availability
        {
            get { return _Availability; }
            set { _Availability = value; OnPropertyChanged("Availability"); }
        }
        private Hl7.Fhir.Model.ResourceReference _Availability;
        
        /// <summary>
        /// BUSY | FREE | BUSY-UNAVAILABLE | BUSY-TENTATIVE
        /// </summary>
        [FhirElement("freeBusyType", Order=80)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Slot.SlotStatus> FreeBusyTypeElement
        {
            get { return _FreeBusyTypeElement; }
            set { _FreeBusyTypeElement = value; OnPropertyChanged("FreeBusyTypeElement"); }
        }
        private Code<Hl7.Fhir.Model.Slot.SlotStatus> _FreeBusyTypeElement;
        
        /// <summary>
        /// BUSY | FREE | BUSY-UNAVAILABLE | BUSY-TENTATIVE
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Slot.SlotStatus? FreeBusyType
        {
            get { return FreeBusyTypeElement != null ? FreeBusyTypeElement.Value : null; }
            set
            {
                if(value == null)
                  FreeBusyTypeElement = null; 
                else
                  FreeBusyTypeElement = new Code<Hl7.Fhir.Model.Slot.SlotStatus>(value);
                OnPropertyChanged("FreeBusyType");
            }
        }
        
        /// <summary>
        /// Date/Time that the slot is to begin
        /// </summary>
        [FhirElement("start", Order=90)]
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
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? Start
        {
            get { return StartElement != null ? StartElement.Value : null; }
            set
            {
                if(value == null)
                  StartElement = null; 
                else
                  StartElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("Start");
            }
        }
        
        /// <summary>
        /// Date/Time that the slot is to conclude
        /// </summary>
        [FhirElement("end", Order=100)]
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
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? End
        {
            get { return EndElement != null ? EndElement.Value : null; }
            set
            {
                if(value == null)
                  EndElement = null; 
                else
                  EndElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("End");
            }
        }
        
        /// <summary>
        /// This slot has already been overbooked, appointments are unlikely to be accepted for this time
        /// </summary>
        [FhirElement("overbooked", Order=110)]
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
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Overbooked
        {
            get { return OverbookedElement != null ? OverbookedElement.Value : null; }
            set
            {
                if(value == null)
                  OverbookedElement = null; 
                else
                  OverbookedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Overbooked");
            }
        }
        
        /// <summary>
        /// Comments on the slot to describe any extended information. Such as custom constraints on the slot
        /// </summary>
        [FhirElement("comment", Order=120)]
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
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Comment
        {
            get { return CommentElement != null ? CommentElement.Value : null; }
            set
            {
                if(value == null)
                  CommentElement = null; 
                else
                  CommentElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Comment");
            }
        }
        
        /// <summary>
        /// When this slot was created, or last revised
        /// </summary>
        [FhirElement("lastModified", Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime LastModifiedElement
        {
            get { return _LastModifiedElement; }
            set { _LastModifiedElement = value; OnPropertyChanged("LastModifiedElement"); }
        }
        private Hl7.Fhir.Model.FhirDateTime _LastModifiedElement;
        
        /// <summary>
        /// When this slot was created, or last revised
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string LastModified
        {
            get { return LastModifiedElement != null ? LastModifiedElement.Value : null; }
            set
            {
                if(value == null)
                  LastModifiedElement = null; 
                else
                  LastModifiedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("LastModified");
            }
        }
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Slot;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(Availability != null) dest.Availability = (Hl7.Fhir.Model.ResourceReference)Availability.DeepCopy();
                if(FreeBusyTypeElement != null) dest.FreeBusyTypeElement = (Code<Hl7.Fhir.Model.Slot.SlotStatus>)FreeBusyTypeElement.DeepCopy();
                if(StartElement != null) dest.StartElement = (Hl7.Fhir.Model.Instant)StartElement.DeepCopy();
                if(EndElement != null) dest.EndElement = (Hl7.Fhir.Model.Instant)EndElement.DeepCopy();
                if(OverbookedElement != null) dest.OverbookedElement = (Hl7.Fhir.Model.FhirBoolean)OverbookedElement.DeepCopy();
                if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
                if(LastModifiedElement != null) dest.LastModifiedElement = (Hl7.Fhir.Model.FhirDateTime)LastModifiedElement.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Slot());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Slot;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Availability, otherT.Availability)) return false;
            if( !DeepComparable.Matches(FreeBusyTypeElement, otherT.FreeBusyTypeElement)) return false;
            if( !DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
            if( !DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
            if( !DeepComparable.Matches(OverbookedElement, otherT.OverbookedElement)) return false;
            if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if( !DeepComparable.Matches(LastModifiedElement, otherT.LastModifiedElement)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Slot;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Availability, otherT.Availability)) return false;
            if( !DeepComparable.IsExactly(FreeBusyTypeElement, otherT.FreeBusyTypeElement)) return false;
            if( !DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
            if( !DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
            if( !DeepComparable.IsExactly(OverbookedElement, otherT.OverbookedElement)) return false;
            if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if( !DeepComparable.IsExactly(LastModifiedElement, otherT.LastModifiedElement)) return false;
            
            return true;
        }
        
    }
    
}