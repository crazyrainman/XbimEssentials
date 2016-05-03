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
using Xbim.Ifc2x3.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLShapeProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @Depth { get; }
		IfcPositiveLengthMeasure? @Width { get; }
		IfcPositiveLengthMeasure @Thickness { get; }
		IfcPositiveLengthMeasure? @FilletRadius { get; }
		IfcPositiveLengthMeasure? @EdgeRadius { get; }
		IfcPlaneAngleMeasure? @LegSlope { get; }
		IfcPositiveLengthMeasure? @CentreOfGravityInX { get; }
		IfcPositiveLengthMeasure? @CentreOfGravityInY { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IfcLShapeProfileDef", 284)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcLShapeProfileDef, IContainsEntityReferences, IEquatable<@IfcLShapeProfileDef>
	{
		#region IIfcLShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcLShapeProfileDef.Depth { get { return @Depth; } }	
		IfcPositiveLengthMeasure? IIfcLShapeProfileDef.Width { get { return @Width; } }	
		IfcPositiveLengthMeasure IIfcLShapeProfileDef.Thickness { get { return @Thickness; } }	
		IfcPositiveLengthMeasure? IIfcLShapeProfileDef.FilletRadius { get { return @FilletRadius; } }	
		IfcPositiveLengthMeasure? IIfcLShapeProfileDef.EdgeRadius { get { return @EdgeRadius; } }	
		IfcPlaneAngleMeasure? IIfcLShapeProfileDef.LegSlope { get { return @LegSlope; } }	
		IfcPositiveLengthMeasure? IIfcLShapeProfileDef.CentreOfGravityInX { get { return @CentreOfGravityInX; } }	
		IfcPositiveLengthMeasure? IIfcLShapeProfileDef.CentreOfGravityInY { get { return @CentreOfGravityInY; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure? _width;
		private IfcPositiveLengthMeasure _thickness;
		private IfcPositiveLengthMeasure? _filletRadius;
		private IfcPositiveLengthMeasure? _edgeRadius;
		private IfcPlaneAngleMeasure? _legSlope;
		private IfcPositiveLengthMeasure? _centreOfGravityInX;
		private IfcPositiveLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _depth;
				((IPersistEntity)this).Activate(false);
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure? @Width 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _width;
				((IPersistEntity)this).Activate(false);
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure @Thickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thickness;
				((IPersistEntity)this).Activate(false);
				return _thickness;
			} 
			set
			{
				SetValue( v =>  _thickness = v, _thickness, value,  "Thickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcPositiveLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _filletRadius;
				((IPersistEntity)this).Activate(false);
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcPositiveLengthMeasure? @EdgeRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _edgeRadius;
				((IPersistEntity)this).Activate(false);
				return _edgeRadius;
			} 
			set
			{
				SetValue( v =>  _edgeRadius = v, _edgeRadius, value,  "EdgeRadius", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcPlaneAngleMeasure? @LegSlope 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _legSlope;
				((IPersistEntity)this).Activate(false);
				return _legSlope;
			} 
			set
			{
				SetValue( v =>  _legSlope = v, _legSlope, value,  "LegSlope", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _centreOfGravityInX;
				((IPersistEntity)this).Activate(false);
				return _centreOfGravityInX;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInX = v, _centreOfGravityInX, value,  "CentreOfGravityInX", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _centreOfGravityInY;
				((IPersistEntity)this).Activate(false);
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY", 11);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_depth = value.RealVal;
					return;
				case 4: 
					_width = value.RealVal;
					return;
				case 5: 
					_thickness = value.RealVal;
					return;
				case 6: 
					_filletRadius = value.RealVal;
					return;
				case 7: 
					_edgeRadius = value.RealVal;
					return;
				case 8: 
					_legSlope = value.RealVal;
					return;
				case 9: 
					_centreOfGravityInX = value.RealVal;
					return;
				case 10: 
					_centreOfGravityInY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLShapeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLShapeProfileDef
            var root = (@IfcLShapeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLShapeProfileDef left, @IfcLShapeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLShapeProfileDef left, @IfcLShapeProfileDef right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
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