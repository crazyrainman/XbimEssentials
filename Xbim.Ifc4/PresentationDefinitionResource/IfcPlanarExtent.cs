// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationDefinitionResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPlanarExtent
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPlanarExtent : IIfcGeometricRepresentationItem
	{
		IfcLengthMeasure @SizeInX { get; }
		IfcLengthMeasure @SizeInY { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationDefinitionResource
{
	[ExpressType("IfcPlanarExtent", 469)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPlanarExtent : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcPlanarExtent, IContainsEntityReferences, IEquatable<@IfcPlanarExtent>
	{
		#region IIfcPlanarExtent explicit implementation
		IfcLengthMeasure IIfcPlanarExtent.SizeInX { get { return @SizeInX; } }	
		IfcLengthMeasure IIfcPlanarExtent.SizeInY { get { return @SizeInY; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPlanarExtent(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _sizeInX;
		private IfcLengthMeasure _sizeInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLengthMeasure @SizeInX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sizeInX;
				((IPersistEntity)this).Activate(false);
				return _sizeInX;
			} 
			set
			{
				SetValue( v =>  _sizeInX = v, _sizeInX, value,  "SizeInX", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLengthMeasure @SizeInY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sizeInY;
				((IPersistEntity)this).Activate(false);
				return _sizeInY;
			} 
			set
			{
				SetValue( v =>  _sizeInY = v, _sizeInY, value,  "SizeInY", 2);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_sizeInX = value.RealVal;
					return;
				case 1: 
					_sizeInY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPlanarExtent other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPlanarExtent
            var root = (@IfcPlanarExtent)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPlanarExtent left, @IfcPlanarExtent right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPlanarExtent left, @IfcPlanarExtent right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
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