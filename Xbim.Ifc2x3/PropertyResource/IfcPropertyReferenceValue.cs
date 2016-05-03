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
using Xbim.Ifc2x3.PropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertyReferenceValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertyReferenceValue : IIfcSimpleProperty
	{
		IfcLabel? @UsageName { get; }
		IIfcObjectReferenceSelect @PropertyReference { get; }
	
	}
}

namespace Xbim.Ifc2x3.PropertyResource
{
	[ExpressType("IfcPropertyReferenceValue", 277)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyReferenceValue : IfcSimpleProperty, IInstantiableEntity, IIfcPropertyReferenceValue, IContainsEntityReferences, IEquatable<@IfcPropertyReferenceValue>
	{
		#region IIfcPropertyReferenceValue explicit implementation
		IfcLabel? IIfcPropertyReferenceValue.UsageName { get { return @UsageName; } }	
		IIfcObjectReferenceSelect IIfcPropertyReferenceValue.PropertyReference { get { return @PropertyReference; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyReferenceValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _usageName;
		private IfcObjectReferenceSelect _propertyReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcLabel? @UsageName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usageName;
				((IPersistEntity)this).Activate(false);
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcObjectReferenceSelect @PropertyReference 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _propertyReference;
				((IPersistEntity)this).Activate(false);
				return _propertyReference;
			} 
			set
			{
				SetValue( v =>  _propertyReference = v, _propertyReference, value,  "PropertyReference", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_usageName = value.StringVal;
					return;
				case 3: 
					_propertyReference = (IfcObjectReferenceSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyReferenceValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertyReferenceValue
            var root = (@IfcPropertyReferenceValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertyReferenceValue left, @IfcPropertyReferenceValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyReferenceValue left, @IfcPropertyReferenceValue right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@PropertyReference != null)
					yield return @PropertyReference;
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