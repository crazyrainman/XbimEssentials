// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.GeometricModelResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcIndexedColourMap
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcIndexedColourMap : IIfcPresentationItem
	{
		IIfcTessellatedFaceSet @MappedTo { get; }
		IfcNormalisedRatioMeasure? @Opacity { get; }
		IIfcColourRgbList @Colours { get; }
		IEnumerable<IfcPositiveInteger> @ColourIndex { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcIndexedColourMap", 1189)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIndexedColourMap : IfcPresentationItem, IInstantiableEntity, IIfcIndexedColourMap, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcIndexedColourMap>
	{
		#region IIfcIndexedColourMap explicit implementation
		IIfcTessellatedFaceSet IIfcIndexedColourMap.MappedTo { get { return @MappedTo; } }	
		IfcNormalisedRatioMeasure? IIfcIndexedColourMap.Opacity { get { return @Opacity; } }	
		IIfcColourRgbList IIfcIndexedColourMap.Colours { get { return @Colours; } }	
		IEnumerable<IfcPositiveInteger> IIfcIndexedColourMap.ColourIndex { get { return @ColourIndex; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIndexedColourMap(IModel model) : base(model) 		{ 
			Model = model; 
			_colourIndex = new ItemSet<IfcPositiveInteger>( this, 0,  4);
		}

		#region Explicit attribute fields
		private IfcTessellatedFaceSet _mappedTo;
		private IfcNormalisedRatioMeasure? _opacity;
		private IfcColourRgbList _colours;
		private ItemSet<IfcPositiveInteger> _colourIndex;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcTessellatedFaceSet @MappedTo 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mappedTo;
				((IPersistEntity)this).Activate(false);
				return _mappedTo;
			} 
			set
			{
				SetValue( v =>  _mappedTo = v, _mappedTo, value,  "MappedTo", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcNormalisedRatioMeasure? @Opacity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _opacity;
				((IPersistEntity)this).Activate(false);
				return _opacity;
			} 
			set
			{
				SetValue( v =>  _opacity = v, _opacity, value,  "Opacity", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcColourRgbList @Colours 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _colours;
				((IPersistEntity)this).Activate(false);
				return _colours;
			} 
			set
			{
				SetValue( v =>  _colours = v, _colours, value,  "Colours", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 4)]
		public ItemSet<IfcPositiveInteger> @ColourIndex 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _colourIndex;
				((IPersistEntity)this).Activate(false);
				return _colourIndex;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_mappedTo = (IfcTessellatedFaceSet)(value.EntityVal);
					return;
				case 1: 
					_opacity = value.RealVal;
					return;
				case 2: 
					_colours = (IfcColourRgbList)(value.EntityVal);
					return;
				case 3: 
					_colourIndex.InternalAdd(value.IntegerVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIndexedColourMap other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcIndexedColourMap
            var root = (@IfcIndexedColourMap)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcIndexedColourMap left, @IfcIndexedColourMap right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcIndexedColourMap left, @IfcIndexedColourMap right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@MappedTo != null)
					yield return @MappedTo;
				if (@Colours != null)
					yield return @Colours;
				yield break;	
			}
		}
		#endregion

		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@MappedTo != null)
					yield return @MappedTo;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}