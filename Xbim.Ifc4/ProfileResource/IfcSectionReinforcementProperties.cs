// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSectionReinforcementProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSectionReinforcementProperties : IIfcPreDefinedProperties
	{
		IfcLengthMeasure @LongitudinalStartPosition { get; }
		IfcLengthMeasure @LongitudinalEndPosition { get; }
		IfcLengthMeasure? @TransversePosition { get; }
		IfcReinforcingBarRoleEnum @ReinforcementRole { get; }
		IIfcSectionProperties @SectionDefinition { get; }
		IEnumerable<IIfcReinforcementBarProperties> @CrossSectionReinforcementDefinitions { get; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IfcSectionReinforcementProperties", 508)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionReinforcementProperties : IfcPreDefinedProperties, IInstantiableEntity, IIfcSectionReinforcementProperties, IContainsEntityReferences, IEquatable<@IfcSectionReinforcementProperties>
	{
		#region IIfcSectionReinforcementProperties explicit implementation
		IfcLengthMeasure IIfcSectionReinforcementProperties.LongitudinalStartPosition { get { return @LongitudinalStartPosition; } }	
		IfcLengthMeasure IIfcSectionReinforcementProperties.LongitudinalEndPosition { get { return @LongitudinalEndPosition; } }	
		IfcLengthMeasure? IIfcSectionReinforcementProperties.TransversePosition { get { return @TransversePosition; } }	
		IfcReinforcingBarRoleEnum IIfcSectionReinforcementProperties.ReinforcementRole { get { return @ReinforcementRole; } }	
		IIfcSectionProperties IIfcSectionReinforcementProperties.SectionDefinition { get { return @SectionDefinition; } }	
		IEnumerable<IIfcReinforcementBarProperties> IIfcSectionReinforcementProperties.CrossSectionReinforcementDefinitions { get { return @CrossSectionReinforcementDefinitions; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionReinforcementProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_crossSectionReinforcementDefinitions = new ItemSet<IfcReinforcementBarProperties>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _longitudinalStartPosition;
		private IfcLengthMeasure _longitudinalEndPosition;
		private IfcLengthMeasure? _transversePosition;
		private IfcReinforcingBarRoleEnum _reinforcementRole;
		private IfcSectionProperties _sectionDefinition;
		private ItemSet<IfcReinforcementBarProperties> _crossSectionReinforcementDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLengthMeasure @LongitudinalStartPosition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalStartPosition;
				((IPersistEntity)this).Activate(false);
				return _longitudinalStartPosition;
			} 
			set
			{
				SetValue( v =>  _longitudinalStartPosition = v, _longitudinalStartPosition, value,  "LongitudinalStartPosition", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLengthMeasure @LongitudinalEndPosition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalEndPosition;
				((IPersistEntity)this).Activate(false);
				return _longitudinalEndPosition;
			} 
			set
			{
				SetValue( v =>  _longitudinalEndPosition = v, _longitudinalEndPosition, value,  "LongitudinalEndPosition", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLengthMeasure? @TransversePosition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transversePosition;
				((IPersistEntity)this).Activate(false);
				return _transversePosition;
			} 
			set
			{
				SetValue( v =>  _transversePosition = v, _transversePosition, value,  "TransversePosition", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 5)]
		public IfcReinforcingBarRoleEnum @ReinforcementRole 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _reinforcementRole;
				((IPersistEntity)this).Activate(false);
				return _reinforcementRole;
			} 
			set
			{
				SetValue( v =>  _reinforcementRole = v, _reinforcementRole, value,  "ReinforcementRole", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcSectionProperties @SectionDefinition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sectionDefinition;
				((IPersistEntity)this).Activate(false);
				return _sectionDefinition;
			} 
			set
			{
				SetValue( v =>  _sectionDefinition = v, _sectionDefinition, value,  "SectionDefinition", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 7)]
		public ItemSet<IfcReinforcementBarProperties> @CrossSectionReinforcementDefinitions 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _crossSectionReinforcementDefinitions;
				((IPersistEntity)this).Activate(false);
				return _crossSectionReinforcementDefinitions;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_longitudinalStartPosition = value.RealVal;
					return;
				case 1: 
					_longitudinalEndPosition = value.RealVal;
					return;
				case 2: 
					_transversePosition = value.RealVal;
					return;
				case 3: 
                    _reinforcementRole = (IfcReinforcingBarRoleEnum) System.Enum.Parse(typeof (IfcReinforcingBarRoleEnum), value.EnumVal, true);
					return;
				case 4: 
					_sectionDefinition = (IfcSectionProperties)(value.EntityVal);
					return;
				case 5: 
					_crossSectionReinforcementDefinitions.InternalAdd((IfcReinforcementBarProperties)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionReinforcementProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSectionReinforcementProperties
            var root = (@IfcSectionReinforcementProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSectionReinforcementProperties left, @IfcSectionReinforcementProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSectionReinforcementProperties left, @IfcSectionReinforcementProperties right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SectionDefinition != null)
					yield return @SectionDefinition;
				foreach(var entity in @CrossSectionReinforcementDefinitions)
					yield return entity;
				yield break;	
			}
		}
		#endregion
		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}