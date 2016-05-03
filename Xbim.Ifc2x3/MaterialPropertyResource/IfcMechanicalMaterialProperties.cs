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
using Xbim.Ifc2x3.MaterialPropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMechanicalMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMechanicalMaterialProperties : IIfcMaterialProperties
	{
		IfcDynamicViscosityMeasure? @DynamicViscosity { get; }
		IfcModulusOfElasticityMeasure? @YoungModulus { get; }
		IfcModulusOfElasticityMeasure? @ShearModulus { get; }
		IfcPositiveRatioMeasure? @PoissonRatio { get; }
		IfcThermalExpansionCoefficientMeasure? @ThermalExpansionCoefficient { get; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcMechanicalMaterialProperties", 436)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMechanicalMaterialProperties : IfcMaterialProperties, IInstantiableEntity, IIfcMechanicalMaterialProperties, IContainsEntityReferences, IEquatable<@IfcMechanicalMaterialProperties>
	{
		#region IIfcMechanicalMaterialProperties explicit implementation
		IfcDynamicViscosityMeasure? IIfcMechanicalMaterialProperties.DynamicViscosity { get { return @DynamicViscosity; } }	
		IfcModulusOfElasticityMeasure? IIfcMechanicalMaterialProperties.YoungModulus { get { return @YoungModulus; } }	
		IfcModulusOfElasticityMeasure? IIfcMechanicalMaterialProperties.ShearModulus { get { return @ShearModulus; } }	
		IfcPositiveRatioMeasure? IIfcMechanicalMaterialProperties.PoissonRatio { get { return @PoissonRatio; } }	
		IfcThermalExpansionCoefficientMeasure? IIfcMechanicalMaterialProperties.ThermalExpansionCoefficient { get { return @ThermalExpansionCoefficient; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDynamicViscosityMeasure? _dynamicViscosity;
		private IfcModulusOfElasticityMeasure? _youngModulus;
		private IfcModulusOfElasticityMeasure? _shearModulus;
		private IfcPositiveRatioMeasure? _poissonRatio;
		private IfcThermalExpansionCoefficientMeasure? _thermalExpansionCoefficient;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcDynamicViscosityMeasure? @DynamicViscosity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _dynamicViscosity;
				((IPersistEntity)this).Activate(false);
				return _dynamicViscosity;
			} 
			set
			{
				SetValue( v =>  _dynamicViscosity = v, _dynamicViscosity, value,  "DynamicViscosity", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcModulusOfElasticityMeasure? @YoungModulus 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _youngModulus;
				((IPersistEntity)this).Activate(false);
				return _youngModulus;
			} 
			set
			{
				SetValue( v =>  _youngModulus = v, _youngModulus, value,  "YoungModulus", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcModulusOfElasticityMeasure? @ShearModulus 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shearModulus;
				((IPersistEntity)this).Activate(false);
				return _shearModulus;
			} 
			set
			{
				SetValue( v =>  _shearModulus = v, _shearModulus, value,  "ShearModulus", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveRatioMeasure? @PoissonRatio 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _poissonRatio;
				((IPersistEntity)this).Activate(false);
				return _poissonRatio;
			} 
			set
			{
				SetValue( v =>  _poissonRatio = v, _poissonRatio, value,  "PoissonRatio", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcThermalExpansionCoefficientMeasure? @ThermalExpansionCoefficient 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thermalExpansionCoefficient;
				((IPersistEntity)this).Activate(false);
				return _thermalExpansionCoefficient;
			} 
			set
			{
				SetValue( v =>  _thermalExpansionCoefficient = v, _thermalExpansionCoefficient, value,  "ThermalExpansionCoefficient", 6);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_dynamicViscosity = value.RealVal;
					return;
				case 2: 
					_youngModulus = value.RealVal;
					return;
				case 3: 
					_shearModulus = value.RealVal;
					return;
				case 4: 
					_poissonRatio = value.RealVal;
					return;
				case 5: 
					_thermalExpansionCoefficient = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMechanicalMaterialProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMechanicalMaterialProperties
            var root = (@IfcMechanicalMaterialProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMechanicalMaterialProperties left, @IfcMechanicalMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMechanicalMaterialProperties left, @IfcMechanicalMaterialProperties right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
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