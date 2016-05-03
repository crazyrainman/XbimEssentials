// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRationalBezierCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRationalBezierCurve : IIfcBezierCurve
	{
		IEnumerable<double> @WeightsData { get; }
		List<double> @Weights  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcRationalBezierCurve", 546)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRationalBezierCurve : IfcBezierCurve, IInstantiableEntity, IIfcRationalBezierCurve, IContainsEntityReferences, IEquatable<@IfcRationalBezierCurve>
	{
		#region IIfcRationalBezierCurve explicit implementation
		IEnumerable<double> IIfcRationalBezierCurve.WeightsData { get { return @WeightsData; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRationalBezierCurve(IModel model) : base(model) 		{ 
			Model = model; 
			_weightsData = new ItemSet<double>( this, 0,  6);
		}

		#region Explicit attribute fields
		private ItemSet<double> _weightsData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1, 8)]
		public ItemSet<double> @WeightsData 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _weightsData;
				((IPersistEntity)this).Activate(false);
				return _weightsData;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Array, EntityAttributeType.None, 0, 255, 0)]
		public List<double> @Weights 
		{
			get 
			{
				//## Getter for Weights
			    return WeightsData.ToList();
			    //##
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_weightsData.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRationalBezierCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRationalBezierCurve
            var root = (@IfcRationalBezierCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRationalBezierCurve left, @IfcRationalBezierCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRationalBezierCurve left, @IfcRationalBezierCurve right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @ControlPointsList)
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