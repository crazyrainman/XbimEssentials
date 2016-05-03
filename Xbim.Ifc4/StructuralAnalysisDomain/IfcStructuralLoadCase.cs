// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadCase
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadCase : IIfcStructuralLoadGroup
	{
		IEnumerable<IfcRatioMeasure> @SelfWeightCoefficients { get; }
	
	}
}

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[ExpressType("IfcStructuralLoadCase", 1281)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadCase : IfcStructuralLoadGroup, IInstantiableEntity, IIfcStructuralLoadCase, IContainsEntityReferences, IEquatable<@IfcStructuralLoadCase>
	{
		#region IIfcStructuralLoadCase explicit implementation
		IEnumerable<IfcRatioMeasure> IIfcStructuralLoadCase.SelfWeightCoefficients { get { return @SelfWeightCoefficients; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadCase(IModel model) : base(model) 		{ 
			Model = model; 
			_selfWeightCoefficients = new OptionalItemSet<IfcRatioMeasure>( this, 3,  11);
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcRatioMeasure> _selfWeightCoefficients;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 3, 3, 25)]
		public OptionalItemSet<IfcRatioMeasure> @SelfWeightCoefficients 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _selfWeightCoefficients;
				((IPersistEntity)this).Activate(false);
				return _selfWeightCoefficients;
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
				case 6: 
				case 7: 
				case 8: 
				case 9: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 10: 
					_selfWeightCoefficients.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadCase other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLoadCase
            var root = (@IfcStructuralLoadCase)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLoadCase left, @IfcStructuralLoadCase right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadCase left, @IfcStructuralLoadCase right)
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