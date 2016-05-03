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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDeclares
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDeclares : IIfcRelationship
	{
		IIfcContext @RelatingContext { get; }
		IEnumerable<IIfcDefinitionSelect> @RelatedDefinitions { get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcRelDeclares", 1249)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDeclares : IfcRelationship, IInstantiableEntity, IIfcRelDeclares, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelDeclares>
	{
		#region IIfcRelDeclares explicit implementation
		IIfcContext IIfcRelDeclares.RelatingContext { get { return @RelatingContext; } }	
		IEnumerable<IIfcDefinitionSelect> IIfcRelDeclares.RelatedDefinitions { get { return @RelatedDefinitions; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDeclares(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedDefinitions = new ItemSet<IfcDefinitionSelect>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcContext _relatingContext;
		private ItemSet<IfcDefinitionSelect> _relatedDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcContext @RelatingContext 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingContext;
				((IPersistEntity)this).Activate(false);
				return _relatingContext;
			} 
			set
			{
				SetValue( v =>  _relatingContext = v, _relatingContext, value,  "RelatingContext", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 6)]
		public ItemSet<IfcDefinitionSelect> @RelatedDefinitions 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedDefinitions;
				((IPersistEntity)this).Activate(false);
				return _relatedDefinitions;
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
					_relatingContext = (IfcContext)(value.EntityVal);
					return;
				case 5: 
					_relatedDefinitions.InternalAdd((IfcDefinitionSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelDeclares other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelDeclares
            var root = (@IfcRelDeclares)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelDeclares left, @IfcRelDeclares right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelDeclares left, @IfcRelDeclares right)
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
				if (@RelatingContext != null)
					yield return @RelatingContext;
				foreach(var entity in @RelatedDefinitions)
					yield return entity;
				yield break;	
			}
		}
		#endregion

		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingContext != null)
					yield return @RelatingContext;
				foreach(var entity in @RelatedDefinitions)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}