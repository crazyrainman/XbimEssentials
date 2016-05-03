// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
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
    /// Readonly interface for IfcRelConnectsPortToElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsPortToElement : IIfcRelConnects
	{
		IIfcPort @RelatingPort { get; }
		IIfcDistributionElement @RelatedElement { get; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcRelConnectsPortToElement", 633)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsPortToElement : IfcRelConnects, IInstantiableEntity, IIfcRelConnectsPortToElement, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsPortToElement>
	{
		#region IIfcRelConnectsPortToElement explicit implementation
		IIfcPort IIfcRelConnectsPortToElement.RelatingPort { get { return @RelatingPort; } }	
		IIfcDistributionElement IIfcRelConnectsPortToElement.RelatedElement { get { return @RelatedElement; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsPortToElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPort _relatingPort;
		private IfcDistributionElement _relatedElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcPort @RelatingPort 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingPort;
				((IPersistEntity)this).Activate(false);
				return _relatingPort;
			} 
			set
			{
				SetValue( v =>  _relatingPort = v, _relatingPort, value,  "RelatingPort", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcDistributionElement @RelatedElement 
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
					_relatingPort = (IfcPort)(value.EntityVal);
					return;
				case 5: 
					_relatedElement = (IfcDistributionElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsPortToElement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelConnectsPortToElement
            var root = (@IfcRelConnectsPortToElement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelConnectsPortToElement left, @IfcRelConnectsPortToElement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelConnectsPortToElement left, @IfcRelConnectsPortToElement right)
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
				if (@RelatingPort != null)
					yield return @RelatingPort;
				if (@RelatedElement != null)
					yield return @RelatedElement;
				yield break;	
			}
		}
		#endregion

		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingPort != null)
					yield return @RelatingPort;
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