// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTelecomAddress
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTelecomAddress : IIfcAddress
	{
		IEnumerable<IfcLabel> @TelephoneNumbers { get; }
		IEnumerable<IfcLabel> @FacsimileNumbers { get; }
		IfcLabel? @PagerNumber { get; }
		IEnumerable<IfcLabel> @ElectronicMailAddresses { get; }
		IfcURIReference? @WWWHomePageURL { get; }
		IEnumerable<IfcURIReference> @MessagingIDs { get; }
	
	}
}

namespace Xbim.Ifc4.ActorResource
{
	[ExpressType("IfcTelecomAddress", 553)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTelecomAddress : IfcAddress, IInstantiableEntity, IIfcTelecomAddress, IContainsEntityReferences, IEquatable<@IfcTelecomAddress>
	{
		#region IIfcTelecomAddress explicit implementation
		IEnumerable<IfcLabel> IIfcTelecomAddress.TelephoneNumbers { get { return @TelephoneNumbers; } }	
		IEnumerable<IfcLabel> IIfcTelecomAddress.FacsimileNumbers { get { return @FacsimileNumbers; } }	
		IfcLabel? IIfcTelecomAddress.PagerNumber { get { return @PagerNumber; } }	
		IEnumerable<IfcLabel> IIfcTelecomAddress.ElectronicMailAddresses { get { return @ElectronicMailAddresses; } }	
		IfcURIReference? IIfcTelecomAddress.WWWHomePageURL { get { return @WWWHomePageURL; } }	
		IEnumerable<IfcURIReference> IIfcTelecomAddress.MessagingIDs { get { return @MessagingIDs; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTelecomAddress(IModel model) : base(model) 		{ 
			Model = model; 
			_telephoneNumbers = new OptionalItemSet<IfcLabel>( this, 0,  4);
			_facsimileNumbers = new OptionalItemSet<IfcLabel>( this, 0,  5);
			_electronicMailAddresses = new OptionalItemSet<IfcLabel>( this, 0,  7);
			_messagingIDs = new OptionalItemSet<IfcURIReference>( this, 0,  9);
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcLabel> _telephoneNumbers;
		private OptionalItemSet<IfcLabel> _facsimileNumbers;
		private IfcLabel? _pagerNumber;
		private OptionalItemSet<IfcLabel> _electronicMailAddresses;
		private IfcURIReference? _wWWHomePageURL;
		private OptionalItemSet<IfcURIReference> _messagingIDs;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 6)]
		public OptionalItemSet<IfcLabel> @TelephoneNumbers 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _telephoneNumbers;
				((IPersistEntity)this).Activate(false);
				return _telephoneNumbers;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 7)]
		public OptionalItemSet<IfcLabel> @FacsimileNumbers 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _facsimileNumbers;
				((IPersistEntity)this).Activate(false);
				return _facsimileNumbers;
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcLabel? @PagerNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pagerNumber;
				((IPersistEntity)this).Activate(false);
				return _pagerNumber;
			} 
			set
			{
				SetValue( v =>  _pagerNumber = v, _pagerNumber, value,  "PagerNumber", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 9)]
		public OptionalItemSet<IfcLabel> @ElectronicMailAddresses 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _electronicMailAddresses;
				((IPersistEntity)this).Activate(false);
				return _electronicMailAddresses;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcURIReference? @WWWHomePageURL 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _wWWHomePageURL;
				((IPersistEntity)this).Activate(false);
				return _wWWHomePageURL;
			} 
			set
			{
				SetValue( v =>  _wWWHomePageURL = v, _wWWHomePageURL, value,  "WWWHomePageURL", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 11)]
		public OptionalItemSet<IfcURIReference> @MessagingIDs 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _messagingIDs;
				((IPersistEntity)this).Activate(false);
				return _messagingIDs;
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
					_telephoneNumbers.InternalAdd(value.StringVal);
					return;
				case 4: 
					_facsimileNumbers.InternalAdd(value.StringVal);
					return;
				case 5: 
					_pagerNumber = value.StringVal;
					return;
				case 6: 
					_electronicMailAddresses.InternalAdd(value.StringVal);
					return;
				case 7: 
					_wWWHomePageURL = value.StringVal;
					return;
				case 8: 
					_messagingIDs.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTelecomAddress other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTelecomAddress
            var root = (@IfcTelecomAddress)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTelecomAddress left, @IfcTelecomAddress right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTelecomAddress left, @IfcTelecomAddress right)
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