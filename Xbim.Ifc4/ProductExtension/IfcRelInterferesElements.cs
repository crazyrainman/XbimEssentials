// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelInterferesElements
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelInterferesElements : IIfcRelConnects
	{
		IIfcElement @RelatingElement { get; }
		IIfcElement @RelatedElement { get; }
		IIfcConnectionGeometry @InterferenceGeometry { get; }
		IfcIdentifier? @InterferenceType { get; }
		bool? @ImpliedOrder { get; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcRelInterferesElements", 1252)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelInterferesElements : IfcRelConnects, IInstantiableEntity, IIfcRelInterferesElements, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelInterferesElements>
	{
		#region IIfcRelInterferesElements explicit implementation
		IIfcElement IIfcRelInterferesElements.RelatingElement { get { return @RelatingElement; } }	
		IIfcElement IIfcRelInterferesElements.RelatedElement { get { return @RelatedElement; } }	
		IIfcConnectionGeometry IIfcRelInterferesElements.InterferenceGeometry { get { return @InterferenceGeometry; } }	
		IfcIdentifier? IIfcRelInterferesElements.InterferenceType { get { return @InterferenceType; } }	
		bool? IIfcRelInterferesElements.ImpliedOrder { get { return @ImpliedOrder; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelInterferesElements(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElement _relatingElement;
		private IfcElement _relatedElement;
		private IfcConnectionGeometry _interferenceGeometry;
		private IfcIdentifier? _interferenceType;
		private bool? _impliedOrder;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcElement @RelatingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingElement;
				((IPersistEntity)this).Activate(false);
				return _relatingElement;
			} 
			set
			{
				SetValue( v =>  _relatingElement = v, _relatingElement, value,  "RelatingElement", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcElement @RelatedElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedElement;
				((IPersistEntity)this).Activate(false);
				return _relatedElement;
			} 
			set
			{
				SetValue( v =>  _relatedElement = v, _relatedElement, value,  "RelatedElement", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcConnectionGeometry @InterferenceGeometry 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _interferenceGeometry;
				((IPersistEntity)this).Activate(false);
				return _interferenceGeometry;
			} 
			set
			{
				SetValue( v =>  _interferenceGeometry = v, _interferenceGeometry, value,  "InterferenceGeometry", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcIdentifier? @InterferenceType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _interferenceType;
				((IPersistEntity)this).Activate(false);
				return _interferenceType;
			} 
			set
			{
				SetValue( v =>  _interferenceType = v, _interferenceType, value,  "InterferenceType", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public bool? @ImpliedOrder 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impliedOrder;
				((IPersistEntity)this).Activate(false);
				return _impliedOrder;
			} 
			set
			{
				SetValue( v =>  _impliedOrder = v, _impliedOrder, value,  "ImpliedOrder", 9);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					_relatedElement = (IfcElement)(value.EntityVal);
					return;
				case 6: 
					_interferenceGeometry = (IfcConnectionGeometry)(value.EntityVal);
					return;
				case 7: 
					_interferenceType = value.StringVal;
					return;
				case 8: 
					_impliedOrder = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelInterferesElements other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelInterferesElements
            var root = (@IfcRelInterferesElements)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelInterferesElements left, @IfcRelInterferesElements right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelInterferesElements left, @IfcRelInterferesElements right)
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
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedElement != null)
					yield return @RelatedElement;
				if (@InterferenceGeometry != null)
					yield return @InterferenceGeometry;
				yield break;	
			}
		}
		#endregion

		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedElement != null)
					yield return @RelatedElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}