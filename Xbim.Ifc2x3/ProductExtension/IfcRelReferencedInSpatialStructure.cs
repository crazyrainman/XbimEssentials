// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelReferencedInSpatialStructure
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelReferencedInSpatialStructure : IIfcRelConnects
	{
		IEnumerable<IIfcProduct> @RelatedElements { get; }
		IIfcSpatialStructureElement @RelatingStructure { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IfcRelReferencedInSpatialStructure", 455)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelReferencedInSpatialStructure : IfcRelConnects, IInstantiableEntity, IIfcRelReferencedInSpatialStructure, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelReferencedInSpatialStructure>
	{
		#region IIfcRelReferencedInSpatialStructure explicit implementation
		IEnumerable<IIfcProduct> IIfcRelReferencedInSpatialStructure.RelatedElements { get { return @RelatedElements; } }	
		IIfcSpatialStructureElement IIfcRelReferencedInSpatialStructure.RelatingStructure { get { return @RelatingStructure; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelReferencedInSpatialStructure(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedElements = new ItemSet<IfcProduct>( this, 0,  5);
		}

		#region Explicit attribute fields
		private ItemSet<IfcProduct> _relatedElements;
		private IfcSpatialStructureElement _relatingStructure;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 5)]
		public ItemSet<IfcProduct> @RelatedElements 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedElements;
				((IPersistEntity)this).Activate(false);
				return _relatedElements;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcSpatialStructureElement @RelatingStructure 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingStructure;
				((IPersistEntity)this).Activate(false);
				return _relatingStructure;
			} 
			set
			{
				SetValue( v =>  _relatingStructure = v, _relatingStructure, value,  "RelatingStructure", 6);
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
					_relatedElements.InternalAdd((IfcProduct)value.EntityVal);
					return;
				case 5: 
					_relatingStructure = (IfcSpatialStructureElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelReferencedInSpatialStructure other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelReferencedInSpatialStructure
            var root = (@IfcRelReferencedInSpatialStructure)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelReferencedInSpatialStructure left, @IfcRelReferencedInSpatialStructure right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelReferencedInSpatialStructure left, @IfcRelReferencedInSpatialStructure right)
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
				foreach(var entity in @RelatedElements)
					yield return entity;
				if (@RelatingStructure != null)
					yield return @RelatingStructure;
				yield break;	
			}
		}
		#endregion

		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedElements)
					yield return entity;
				if (@RelatingStructure != null)
					yield return @RelatingStructure;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}