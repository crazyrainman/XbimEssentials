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
using Xbim.Ifc4.CostResource;
using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedFacilitiesElements;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAsset
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAsset : IIfcGroup
	{
		IfcIdentifier? @Identification { get; }
		IIfcCostValue @OriginalValue { get; }
		IIfcCostValue @CurrentValue { get; }
		IIfcCostValue @TotalReplacementCost { get; }
		IIfcActorSelect @Owner { get; }
		IIfcActorSelect @User { get; }
		IIfcPerson @ResponsiblePerson { get; }
		IfcDate? @IncorporationDate { get; }
		IIfcCostValue @DepreciatedValue { get; }
	
	}
}

namespace Xbim.Ifc4.SharedFacilitiesElements
{
	[ExpressType("IfcAsset", 767)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAsset : IfcGroup, IInstantiableEntity, IIfcAsset, IContainsEntityReferences, IEquatable<@IfcAsset>
	{
		#region IIfcAsset explicit implementation
		IfcIdentifier? IIfcAsset.Identification { get { return @Identification; } }	
		IIfcCostValue IIfcAsset.OriginalValue { get { return @OriginalValue; } }	
		IIfcCostValue IIfcAsset.CurrentValue { get { return @CurrentValue; } }	
		IIfcCostValue IIfcAsset.TotalReplacementCost { get { return @TotalReplacementCost; } }	
		IIfcActorSelect IIfcAsset.Owner { get { return @Owner; } }	
		IIfcActorSelect IIfcAsset.User { get { return @User; } }	
		IIfcPerson IIfcAsset.ResponsiblePerson { get { return @ResponsiblePerson; } }	
		IfcDate? IIfcAsset.IncorporationDate { get { return @IncorporationDate; } }	
		IIfcCostValue IIfcAsset.DepreciatedValue { get { return @DepreciatedValue; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAsset(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcCostValue _originalValue;
		private IfcCostValue _currentValue;
		private IfcCostValue _totalReplacementCost;
		private IfcActorSelect _owner;
		private IfcActorSelect _user;
		private IfcPerson _responsiblePerson;
		private IfcDate? _incorporationDate;
		private IfcCostValue _depreciatedValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 18)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _identification;
				((IPersistEntity)this).Activate(false);
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _originalValue;
				((IPersistEntity)this).Activate(false);
				return _originalValue;
			} 
			set
			{
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _currentValue;
				((IPersistEntity)this).Activate(false);
				return _currentValue;
			} 
			set
			{
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 21)]
		public IfcCostValue @TotalReplacementCost 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _totalReplacementCost;
				((IPersistEntity)this).Activate(false);
				return _totalReplacementCost;
			} 
			set
			{
				SetValue( v =>  _totalReplacementCost = v, _totalReplacementCost, value,  "TotalReplacementCost", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 22)]
		public IfcActorSelect @Owner 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _owner;
				((IPersistEntity)this).Activate(false);
				return _owner;
			} 
			set
			{
				SetValue( v =>  _owner = v, _owner, value,  "Owner", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 23)]
		public IfcActorSelect @User 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _user;
				((IPersistEntity)this).Activate(false);
				return _user;
			} 
			set
			{
				SetValue( v =>  _user = v, _user, value,  "User", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 24)]
		public IfcPerson @ResponsiblePerson 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _responsiblePerson;
				((IPersistEntity)this).Activate(false);
				return _responsiblePerson;
			} 
			set
			{
				SetValue( v =>  _responsiblePerson = v, _responsiblePerson, value,  "ResponsiblePerson", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 25)]
		public IfcDate? @IncorporationDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _incorporationDate;
				((IPersistEntity)this).Activate(false);
				return _incorporationDate;
			} 
			set
			{
				SetValue( v =>  _incorporationDate = v, _incorporationDate, value,  "IncorporationDate", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 26)]
		public IfcCostValue @DepreciatedValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _depreciatedValue;
				((IPersistEntity)this).Activate(false);
				return _depreciatedValue;
			} 
			set
			{
				SetValue( v =>  _depreciatedValue = v, _depreciatedValue, value,  "DepreciatedValue", 14);
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
					_identification = value.StringVal;
					return;
				case 6: 
					_originalValue = (IfcCostValue)(value.EntityVal);
					return;
				case 7: 
					_currentValue = (IfcCostValue)(value.EntityVal);
					return;
				case 8: 
					_totalReplacementCost = (IfcCostValue)(value.EntityVal);
					return;
				case 9: 
					_owner = (IfcActorSelect)(value.EntityVal);
					return;
				case 10: 
					_user = (IfcActorSelect)(value.EntityVal);
					return;
				case 11: 
					_responsiblePerson = (IfcPerson)(value.EntityVal);
					return;
				case 12: 
					_incorporationDate = value.StringVal;
					return;
				case 13: 
					_depreciatedValue = (IfcCostValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAsset other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAsset
            var root = (@IfcAsset)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAsset left, @IfcAsset right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAsset left, @IfcAsset right)
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
				if (@OriginalValue != null)
					yield return @OriginalValue;
				if (@CurrentValue != null)
					yield return @CurrentValue;
				if (@TotalReplacementCost != null)
					yield return @TotalReplacementCost;
				if (@Owner != null)
					yield return @Owner;
				if (@User != null)
					yield return @User;
				if (@ResponsiblePerson != null)
					yield return @ResponsiblePerson;
				if (@DepreciatedValue != null)
					yield return @DepreciatedValue;
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