// <auto-generated/>
// Contents of: hl7.fhir.r3.core version: 3.0.2

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
  /// Who, What, When for a set of resources
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Provenance","http://hl7.org/fhir/StructureDefinition/Provenance", IsResource=true)]
  public partial class Provenance : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Provenance"; } }

    /// <summary>
    /// How an entity was used in an activity.
    /// (url: http://hl7.org/fhir/ValueSet/provenance-entity-role)
    /// (system: http://hl7.org/fhir/provenance-entity-role)
    /// </summary>
    [FhirEnumeration("ProvenanceEntityRole")]
    public enum ProvenanceEntityRole
    {
      /// <summary>
      /// A transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a preexisting entity.
      /// (system: http://hl7.org/fhir/provenance-entity-role)
      /// </summary>
      [EnumLiteral("derivation", "http://hl7.org/fhir/provenance-entity-role"), Description("Derivation")]
      Derivation,
      /// <summary>
      /// A derivation for which the resulting entity is a revised version of some original.
      /// (system: http://hl7.org/fhir/provenance-entity-role)
      /// </summary>
      [EnumLiteral("revision", "http://hl7.org/fhir/provenance-entity-role"), Description("Revision")]
      Revision,
      /// <summary>
      /// The repeat of (some or all of) an entity, such as text or image, by someone who may or may not be its original author.
      /// (system: http://hl7.org/fhir/provenance-entity-role)
      /// </summary>
      [EnumLiteral("quotation", "http://hl7.org/fhir/provenance-entity-role"), Description("Quotation")]
      Quotation,
      /// <summary>
      /// A primary source for a topic refers to something produced by some agent with direct experience and knowledge about the topic, at the time of the topic's study, without benefit from hindsight.
      /// (system: http://hl7.org/fhir/provenance-entity-role)
      /// </summary>
      [EnumLiteral("source", "http://hl7.org/fhir/provenance-entity-role"), Description("Source")]
      Source,
      /// <summary>
      /// A derivation for which the entity is removed from accessibility usually through the use of the Delete operation.
      /// (system: http://hl7.org/fhir/provenance-entity-role)
      /// </summary>
      [EnumLiteral("removal", "http://hl7.org/fhir/provenance-entity-role"), Description("Removal")]
      Removal,
    }

    /// <summary>
    /// Actor involved
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Provenance#Agent", IsNestedType=true)]
    public partial class AgentComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Provenance#Agent"; } }

      /// <summary>
      /// What the agents role was
      /// </summary>
      [FhirElement("role", InSummary=true, Order=40)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> Role
      {
        get { if(_Role==null) _Role = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Role; }
        set { _Role = value; OnPropertyChanged("Role"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _Role;

      /// <summary>
      /// Who participated
      /// </summary>
      [FhirElement("who", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("Practitioner","RelatedPerson","Patient","Device","Organization")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.ResourceReference))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType Who
      {
        get { return _Who; }
        set { _Who = value; OnPropertyChanged("Who"); }
      }

      private Hl7.Fhir.Model.DataType _Who;

      /// <summary>
      /// Who the agent is representing
      /// </summary>
      [FhirElement("onBehalfOf", Order=60, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("Practitioner","RelatedPerson","Patient","Device","Organization")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.ResourceReference))]
      [DataMember]
      public Hl7.Fhir.Model.DataType OnBehalfOf
      {
        get { return _OnBehalfOf; }
        set { _OnBehalfOf = value; OnPropertyChanged("OnBehalfOf"); }
      }

      private Hl7.Fhir.Model.DataType _OnBehalfOf;

      /// <summary>
      /// Type of relationship between agents
      /// </summary>
      [FhirElement("relatedAgentType", Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept RelatedAgentType
      {
        get { return _RelatedAgentType; }
        set { _RelatedAgentType = value; OnPropertyChanged("RelatedAgentType"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _RelatedAgentType;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as AgentComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Role != null) dest.Role = new List<Hl7.Fhir.Model.CodeableConcept>(Role.DeepCopy());
        if(Who != null) dest.Who = (Hl7.Fhir.Model.DataType)Who.DeepCopy();
        if(OnBehalfOf != null) dest.OnBehalfOf = (Hl7.Fhir.Model.DataType)OnBehalfOf.DeepCopy();
        if(RelatedAgentType != null) dest.RelatedAgentType = (Hl7.Fhir.Model.CodeableConcept)RelatedAgentType.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new AgentComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as AgentComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Role, otherT.Role)) return false;
        if( !DeepComparable.Matches(Who, otherT.Who)) return false;
        if( !DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;
        if( !DeepComparable.Matches(RelatedAgentType, otherT.RelatedAgentType)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as AgentComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
        if( !DeepComparable.IsExactly(Who, otherT.Who)) return false;
        if( !DeepComparable.IsExactly(OnBehalfOf, otherT.OnBehalfOf)) return false;
        if( !DeepComparable.IsExactly(RelatedAgentType, otherT.RelatedAgentType)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          foreach (var elem in Role) { if (elem != null) yield return elem; }
          if (Who != null) yield return Who;
          if (OnBehalfOf != null) yield return OnBehalfOf;
          if (RelatedAgentType != null) yield return RelatedAgentType;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", elem); }
          if (Who != null) yield return new ElementValue("who", Who);
          if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
          if (RelatedAgentType != null) yield return new ElementValue("relatedAgentType", RelatedAgentType);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "role":
            value = Role;
            return Role?.Any() == true;
          case "who":
            value = Who;
            return Who is not null;
          case "onBehalfOf":
            value = OnBehalfOf;
            return OnBehalfOf is not null;
          case "relatedAgentType":
            value = RelatedAgentType;
            return RelatedAgentType is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Role?.Any() == true) yield return new KeyValuePair<string,object>("role",Role);
        if (Who is not null) yield return new KeyValuePair<string,object>("who",Who);
        if (OnBehalfOf is not null) yield return new KeyValuePair<string,object>("onBehalfOf",OnBehalfOf);
        if (RelatedAgentType is not null) yield return new KeyValuePair<string,object>("relatedAgentType",RelatedAgentType);
      }

    }

    /// <summary>
    /// An entity used in this activity
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Provenance#Entity", IsNestedType=true)]
    public partial class EntityComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Provenance#Entity"; } }

      /// <summary>
      /// derivation | revision | quotation | source | removal
      /// </summary>
      [FhirElement("role", InSummary=true, Order=40)]
      [DeclaredType(Type = typeof(Code))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole> RoleElement
      {
        get { return _RoleElement; }
        set { _RoleElement = value; OnPropertyChanged("RoleElement"); }
      }

      private Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole> _RoleElement;

      /// <summary>
      /// derivation | revision | quotation | source | removal
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public Hl7.Fhir.Model.Provenance.ProvenanceEntityRole? Role
      {
        get { return RoleElement != null ? RoleElement.Value : null; }
        set
        {
          if (value == null)
            RoleElement = null;
          else
            RoleElement = new Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>(value);
          OnPropertyChanged("Role");
        }
      }

      /// <summary>
      /// Identity of entity
      /// </summary>
      [FhirElement("what", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("Resource")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.Identifier))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType What
      {
        get { return _What; }
        set { _What = value; OnPropertyChanged("What"); }
      }

      private Hl7.Fhir.Model.DataType _What;

      /// <summary>
      /// Entity is attributed to this agent
      /// </summary>
      [FhirElement("agent", Order=60)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.Provenance.AgentComponent> Agent
      {
        get { if(_Agent==null) _Agent = new List<Hl7.Fhir.Model.Provenance.AgentComponent>(); return _Agent; }
        set { _Agent = value; OnPropertyChanged("Agent"); }
      }

      private List<Hl7.Fhir.Model.Provenance.AgentComponent> _Agent;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as EntityComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(RoleElement != null) dest.RoleElement = (Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>)RoleElement.DeepCopy();
        if(What != null) dest.What = (Hl7.Fhir.Model.DataType)What.DeepCopy();
        if(Agent != null) dest.Agent = new List<Hl7.Fhir.Model.Provenance.AgentComponent>(Agent.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new EntityComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as EntityComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(RoleElement, otherT.RoleElement)) return false;
        if( !DeepComparable.Matches(What, otherT.What)) return false;
        if( !DeepComparable.Matches(Agent, otherT.Agent)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as EntityComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(RoleElement, otherT.RoleElement)) return false;
        if( !DeepComparable.IsExactly(What, otherT.What)) return false;
        if( !DeepComparable.IsExactly(Agent, otherT.Agent)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (RoleElement != null) yield return RoleElement;
          if (What != null) yield return What;
          foreach (var elem in Agent) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (RoleElement != null) yield return new ElementValue("role", RoleElement);
          if (What != null) yield return new ElementValue("what", What);
          foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "role":
            value = RoleElement;
            return RoleElement is not null;
          case "what":
            value = What;
            return What is not null;
          case "agent":
            value = Agent;
            return Agent?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (RoleElement is not null) yield return new KeyValuePair<string,object>("role",RoleElement);
        if (What is not null) yield return new KeyValuePair<string,object>("what",What);
        if (Agent?.Any() == true) yield return new KeyValuePair<string,object>("agent",Agent);
      }

    }

    /// <summary>
    /// Target Reference(s) (usually version specific)
    /// </summary>
    [FhirElement("target", InSummary=true, Order=90)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Target
    {
      get { if(_Target==null) _Target = new List<Hl7.Fhir.Model.ResourceReference>(); return _Target; }
      set { _Target = value; OnPropertyChanged("Target"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Target;

    /// <summary>
    /// When the activity occurred
    /// </summary>
    [FhirElement("period", Order=100)]
    [DataMember]
    public Hl7.Fhir.Model.Period Period
    {
      get { return _Period; }
      set { _Period = value; OnPropertyChanged("Period"); }
    }

    private Hl7.Fhir.Model.Period _Period;

    /// <summary>
    /// When the activity was recorded / updated
    /// </summary>
    [FhirElement("recorded", InSummary=true, Order=110)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.Instant RecordedElement
    {
      get { return _RecordedElement; }
      set { _RecordedElement = value; OnPropertyChanged("RecordedElement"); }
    }

    private Hl7.Fhir.Model.Instant _RecordedElement;

    /// <summary>
    /// When the activity was recorded / updated
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public DateTimeOffset? Recorded
    {
      get { return RecordedElement != null ? RecordedElement.Value : null; }
      set
      {
        if (value == null)
          RecordedElement = null;
        else
          RecordedElement = new Hl7.Fhir.Model.Instant(value);
        OnPropertyChanged("Recorded");
      }
    }

    /// <summary>
    /// Policy or plan the activity was defined by
    /// </summary>
    [FhirElement("policy", Order=120)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.FhirUri> PolicyElement
    {
      get { if(_PolicyElement==null) _PolicyElement = new List<Hl7.Fhir.Model.FhirUri>(); return _PolicyElement; }
      set { _PolicyElement = value; OnPropertyChanged("PolicyElement"); }
    }

    private List<Hl7.Fhir.Model.FhirUri> _PolicyElement;

    /// <summary>
    /// Policy or plan the activity was defined by
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public IEnumerable<string> Policy
    {
      get { return PolicyElement != null ? PolicyElement.Select(elem => elem.Value) : null; }
      set
      {
        if (value == null)
          PolicyElement = null;
        else
          PolicyElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
        OnPropertyChanged("Policy");
      }
    }

    /// <summary>
    /// Where the activity occurred, if relevant
    /// </summary>
    [FhirElement("location", Order=130)]
    [CLSCompliant(false)]
    [References("Location")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Location
    {
      get { return _Location; }
      set { _Location = value; OnPropertyChanged("Location"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Location;

    /// <summary>
    /// Reason the activity is occurring
    /// </summary>
    [FhirElement("reason", Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Coding> Reason
    {
      get { if(_Reason==null) _Reason = new List<Hl7.Fhir.Model.Coding>(); return _Reason; }
      set { _Reason = value; OnPropertyChanged("Reason"); }
    }

    private List<Hl7.Fhir.Model.Coding> _Reason;

    /// <summary>
    /// Activity that occurred
    /// </summary>
    [FhirElement("activity", Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.Coding Activity
    {
      get { return _Activity; }
      set { _Activity = value; OnPropertyChanged("Activity"); }
    }

    private Hl7.Fhir.Model.Coding _Activity;

    /// <summary>
    /// Actor involved
    /// </summary>
    [FhirElement("agent", Order=160)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Provenance.AgentComponent> Agent
    {
      get { if(_Agent==null) _Agent = new List<Hl7.Fhir.Model.Provenance.AgentComponent>(); return _Agent; }
      set { _Agent = value; OnPropertyChanged("Agent"); }
    }

    private List<Hl7.Fhir.Model.Provenance.AgentComponent> _Agent;

    /// <summary>
    /// An entity used in this activity
    /// </summary>
    [FhirElement("entity", Order=170)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Provenance.EntityComponent> Entity
    {
      get { if(_Entity==null) _Entity = new List<Hl7.Fhir.Model.Provenance.EntityComponent>(); return _Entity; }
      set { _Entity = value; OnPropertyChanged("Entity"); }
    }

    private List<Hl7.Fhir.Model.Provenance.EntityComponent> _Entity;

    /// <summary>
    /// Signature on target
    /// </summary>
    [FhirElement("signature", Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Signature> Signature
    {
      get { if(_Signature==null) _Signature = new List<Hl7.Fhir.Model.Signature>(); return _Signature; }
      set { _Signature = value; OnPropertyChanged("Signature"); }
    }

    private List<Hl7.Fhir.Model.Signature> _Signature;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Provenance;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Target != null) dest.Target = new List<Hl7.Fhir.Model.ResourceReference>(Target.DeepCopy());
      if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
      if(RecordedElement != null) dest.RecordedElement = (Hl7.Fhir.Model.Instant)RecordedElement.DeepCopy();
      if(PolicyElement != null) dest.PolicyElement = new List<Hl7.Fhir.Model.FhirUri>(PolicyElement.DeepCopy());
      if(Location != null) dest.Location = (Hl7.Fhir.Model.ResourceReference)Location.DeepCopy();
      if(Reason != null) dest.Reason = new List<Hl7.Fhir.Model.Coding>(Reason.DeepCopy());
      if(Activity != null) dest.Activity = (Hl7.Fhir.Model.Coding)Activity.DeepCopy();
      if(Agent != null) dest.Agent = new List<Hl7.Fhir.Model.Provenance.AgentComponent>(Agent.DeepCopy());
      if(Entity != null) dest.Entity = new List<Hl7.Fhir.Model.Provenance.EntityComponent>(Entity.DeepCopy());
      if(Signature != null) dest.Signature = new List<Hl7.Fhir.Model.Signature>(Signature.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Provenance());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Provenance;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Target, otherT.Target)) return false;
      if( !DeepComparable.Matches(Period, otherT.Period)) return false;
      if( !DeepComparable.Matches(RecordedElement, otherT.RecordedElement)) return false;
      if( !DeepComparable.Matches(PolicyElement, otherT.PolicyElement)) return false;
      if( !DeepComparable.Matches(Location, otherT.Location)) return false;
      if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
      if( !DeepComparable.Matches(Activity, otherT.Activity)) return false;
      if( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
      if( !DeepComparable.Matches(Entity, otherT.Entity)) return false;
      if( !DeepComparable.Matches(Signature, otherT.Signature)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Provenance;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Target, otherT.Target)) return false;
      if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
      if( !DeepComparable.IsExactly(RecordedElement, otherT.RecordedElement)) return false;
      if( !DeepComparable.IsExactly(PolicyElement, otherT.PolicyElement)) return false;
      if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
      if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
      if( !DeepComparable.IsExactly(Activity, otherT.Activity)) return false;
      if( !DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
      if( !DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
      if( !DeepComparable.IsExactly(Signature, otherT.Signature)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Target) { if (elem != null) yield return elem; }
        if (Period != null) yield return Period;
        if (RecordedElement != null) yield return RecordedElement;
        foreach (var elem in PolicyElement) { if (elem != null) yield return elem; }
        if (Location != null) yield return Location;
        foreach (var elem in Reason) { if (elem != null) yield return elem; }
        if (Activity != null) yield return Activity;
        foreach (var elem in Agent) { if (elem != null) yield return elem; }
        foreach (var elem in Entity) { if (elem != null) yield return elem; }
        foreach (var elem in Signature) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", elem); }
        if (Period != null) yield return new ElementValue("period", Period);
        if (RecordedElement != null) yield return new ElementValue("recorded", RecordedElement);
        foreach (var elem in PolicyElement) { if (elem != null) yield return new ElementValue("policy", elem); }
        if (Location != null) yield return new ElementValue("location", Location);
        foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
        if (Activity != null) yield return new ElementValue("activity", Activity);
        foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", elem); }
        foreach (var elem in Entity) { if (elem != null) yield return new ElementValue("entity", elem); }
        foreach (var elem in Signature) { if (elem != null) yield return new ElementValue("signature", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "target":
          value = Target;
          return Target?.Any() == true;
        case "period":
          value = Period;
          return Period is not null;
        case "recorded":
          value = RecordedElement;
          return RecordedElement is not null;
        case "policy":
          value = PolicyElement;
          return PolicyElement?.Any() == true;
        case "location":
          value = Location;
          return Location is not null;
        case "reason":
          value = Reason;
          return Reason?.Any() == true;
        case "activity":
          value = Activity;
          return Activity is not null;
        case "agent":
          value = Agent;
          return Agent?.Any() == true;
        case "entity":
          value = Entity;
          return Entity?.Any() == true;
        case "signature":
          value = Signature;
          return Signature?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Target?.Any() == true) yield return new KeyValuePair<string,object>("target",Target);
      if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      if (RecordedElement is not null) yield return new KeyValuePair<string,object>("recorded",RecordedElement);
      if (PolicyElement?.Any() == true) yield return new KeyValuePair<string,object>("policy",PolicyElement);
      if (Location is not null) yield return new KeyValuePair<string,object>("location",Location);
      if (Reason?.Any() == true) yield return new KeyValuePair<string,object>("reason",Reason);
      if (Activity is not null) yield return new KeyValuePair<string,object>("activity",Activity);
      if (Agent?.Any() == true) yield return new KeyValuePair<string,object>("agent",Agent);
      if (Entity?.Any() == true) yield return new KeyValuePair<string,object>("entity",Entity);
      if (Signature?.Any() == true) yield return new KeyValuePair<string,object>("signature",Signature);
    }

  }

}

// end of file
