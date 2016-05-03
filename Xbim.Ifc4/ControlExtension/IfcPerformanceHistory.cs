// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ControlExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPerformanceHistory
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPerformanceHistory : IIfcControl
	{
		IfcLabel @LifeCyclePhase { get; }
		IfcPerformanceHistoryTypeEnum? @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc4.ControlExtension
{
	[ExpressType("IfcPerformanceHistory", 710)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPerformanceHistory : IfcControl, IInstantiableEntity, IIfcPerformanceHistory, IContainsEntityReferences, IEquatable<@IfcPerformanceHistory>
	{
		#region IIfcPerformanceHistory explicit implementation
		IfcLabel IIfcPerformanceHistory.LifeCyclePhase { get { return @LifeCyclePhase; } }	
		IfcPerformanceHistoryTypeEnum? IIfcPerformanceHistory.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPerformanceHistory(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _lifeCyclePhase;
		private IfcPerformanceHistoryTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 19)]
		public IfcLabel @LifeCyclePhase 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lifeCyclePhase;
				((IPersistEntity)this).Activate(false);
				return _lifeCyclePhase;
			} 
			set
			{
				SetValue( v =>  _lifeCyclePhase = v, _lifeCyclePhase, value,  "LifeCyclePhase", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 20)]
		public IfcPerformanceHistoryTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 8);
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
					_lifeCyclePhase = value.StringVal;
					return;
				case 7: 
                    _predefinedType = (IfcPerformanceHistoryTypeEnum) System.Enum.Parse(typeof (IfcPerformanceHistoryTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPerformanceHistory other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPerformanceHistory
            var root = (@IfcPerformanceHistory)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPerformanceHistory left, @IfcPerformanceHistory right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPerformanceHistory left, @IfcPerformanceHistory right)
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