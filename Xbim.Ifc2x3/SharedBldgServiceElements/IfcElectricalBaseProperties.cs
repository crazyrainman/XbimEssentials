// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgServiceElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcElectricalBaseProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcElectricalBaseProperties : IIfcEnergyProperties
	{
		IfcElectricCurrentEnum? @ElectricCurrentType { get; }
		IfcElectricVoltageMeasure @InputVoltage { get; }
		IfcFrequencyMeasure @InputFrequency { get; }
		IfcElectricCurrentMeasure? @FullLoadCurrent { get; }
		IfcElectricCurrentMeasure? @MinimumCircuitCurrent { get; }
		IfcPowerMeasure? @MaximumPowerInput { get; }
		IfcPowerMeasure? @RatedPowerInput { get; }
		long @InputPhase { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IfcElectricalBaseProperties", 177)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElectricalBaseProperties : IfcEnergyProperties, IInstantiableEntity, IIfcElectricalBaseProperties, IContainsEntityReferences, IEquatable<@IfcElectricalBaseProperties>
	{
		#region IIfcElectricalBaseProperties explicit implementation
		IfcElectricCurrentEnum? IIfcElectricalBaseProperties.ElectricCurrentType { get { return @ElectricCurrentType; } }	
		IfcElectricVoltageMeasure IIfcElectricalBaseProperties.InputVoltage { get { return @InputVoltage; } }	
		IfcFrequencyMeasure IIfcElectricalBaseProperties.InputFrequency { get { return @InputFrequency; } }	
		IfcElectricCurrentMeasure? IIfcElectricalBaseProperties.FullLoadCurrent { get { return @FullLoadCurrent; } }	
		IfcElectricCurrentMeasure? IIfcElectricalBaseProperties.MinimumCircuitCurrent { get { return @MinimumCircuitCurrent; } }	
		IfcPowerMeasure? IIfcElectricalBaseProperties.MaximumPowerInput { get { return @MaximumPowerInput; } }	
		IfcPowerMeasure? IIfcElectricalBaseProperties.RatedPowerInput { get { return @RatedPowerInput; } }	
		long IIfcElectricalBaseProperties.InputPhase { get { return @InputPhase; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElectricalBaseProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElectricCurrentEnum? _electricCurrentType;
		private IfcElectricVoltageMeasure _inputVoltage;
		private IfcFrequencyMeasure _inputFrequency;
		private IfcElectricCurrentMeasure? _fullLoadCurrent;
		private IfcElectricCurrentMeasure? _minimumCircuitCurrent;
		private IfcPowerMeasure? _maximumPowerInput;
		private IfcPowerMeasure? _ratedPowerInput;
		private long _inputPhase;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 10)]
		public IfcElectricCurrentEnum? @ElectricCurrentType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _electricCurrentType;
				((IPersistEntity)this).Activate(false);
				return _electricCurrentType;
			} 
			set
			{
				SetValue( v =>  _electricCurrentType = v, _electricCurrentType, value,  "ElectricCurrentType", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcElectricVoltageMeasure @InputVoltage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _inputVoltage;
				((IPersistEntity)this).Activate(false);
				return _inputVoltage;
			} 
			set
			{
				SetValue( v =>  _inputVoltage = v, _inputVoltage, value,  "InputVoltage", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcFrequencyMeasure @InputFrequency 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _inputFrequency;
				((IPersistEntity)this).Activate(false);
				return _inputFrequency;
			} 
			set
			{
				SetValue( v =>  _inputFrequency = v, _inputFrequency, value,  "InputFrequency", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public IfcElectricCurrentMeasure? @FullLoadCurrent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _fullLoadCurrent;
				((IPersistEntity)this).Activate(false);
				return _fullLoadCurrent;
			} 
			set
			{
				SetValue( v =>  _fullLoadCurrent = v, _fullLoadCurrent, value,  "FullLoadCurrent", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcElectricCurrentMeasure? @MinimumCircuitCurrent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _minimumCircuitCurrent;
				((IPersistEntity)this).Activate(false);
				return _minimumCircuitCurrent;
			} 
			set
			{
				SetValue( v =>  _minimumCircuitCurrent = v, _minimumCircuitCurrent, value,  "MinimumCircuitCurrent", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public IfcPowerMeasure? @MaximumPowerInput 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _maximumPowerInput;
				((IPersistEntity)this).Activate(false);
				return _maximumPowerInput;
			} 
			set
			{
				SetValue( v =>  _maximumPowerInput = v, _maximumPowerInput, value,  "MaximumPowerInput", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public IfcPowerMeasure? @RatedPowerInput 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _ratedPowerInput;
				((IPersistEntity)this).Activate(false);
				return _ratedPowerInput;
			} 
			set
			{
				SetValue( v =>  _ratedPowerInput = v, _ratedPowerInput, value,  "RatedPowerInput", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public long @InputPhase 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _inputPhase;
				((IPersistEntity)this).Activate(false);
				return _inputPhase;
			} 
			set
			{
				SetValue( v =>  _inputPhase = v, _inputPhase, value,  "InputPhase", 14);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
                    _electricCurrentType = (IfcElectricCurrentEnum) System.Enum.Parse(typeof (IfcElectricCurrentEnum), value.EnumVal, true);
					return;
				case 7: 
					_inputVoltage = value.RealVal;
					return;
				case 8: 
					_inputFrequency = value.RealVal;
					return;
				case 9: 
					_fullLoadCurrent = value.RealVal;
					return;
				case 10: 
					_minimumCircuitCurrent = value.RealVal;
					return;
				case 11: 
					_maximumPowerInput = value.RealVal;
					return;
				case 12: 
					_ratedPowerInput = value.RealVal;
					return;
				case 13: 
					_inputPhase = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcElectricalBaseProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcElectricalBaseProperties
            var root = (@IfcElectricalBaseProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcElectricalBaseProperties left, @IfcElectricalBaseProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcElectricalBaseProperties left, @IfcElectricalBaseProperties right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
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