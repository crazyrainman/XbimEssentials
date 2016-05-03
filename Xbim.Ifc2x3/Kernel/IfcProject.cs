// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProject : IIfcObject
	{
		IfcLabel? @LongName { get; }
		IfcLabel? @Phase { get; }
		IEnumerable<IIfcRepresentationContext> @RepresentationContexts { get; }
		IIfcUnitAssignment @UnitsInContext { get; }
	
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcProject", 204)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProject : IfcObject, IInstantiableEntity, IIfcProject, IContainsEntityReferences, IEquatable<@IfcProject>
	{
		#region IIfcProject explicit implementation
		IfcLabel? IIfcProject.LongName { get { return @LongName; } }	
		IfcLabel? IIfcProject.Phase { get { return @Phase; } }	
		IEnumerable<IIfcRepresentationContext> IIfcProject.RepresentationContexts { get { return @RepresentationContexts; } }	
		IIfcUnitAssignment IIfcProject.UnitsInContext { get { return @UnitsInContext; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProject(IModel model) : base(model) 		{ 
			Model = model; 
			_representationContexts = new ItemSet<IfcRepresentationContext>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		private IfcLabel? _phase;
		private ItemSet<IfcRepresentationContext> _representationContexts;
		private IfcUnitAssignment _unitsInContext;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longName;
				((IPersistEntity)this).Activate(false);
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcLabel? @Phase 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _phase;
				((IPersistEntity)this).Activate(false);
				return _phase;
			} 
			set
			{
				SetValue( v =>  _phase = v, _phase, value,  "Phase", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 13)]
		public ItemSet<IfcRepresentationContext> @RepresentationContexts 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _representationContexts;
				((IPersistEntity)this).Activate(false);
				return _representationContexts;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public IfcUnitAssignment @UnitsInContext 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unitsInContext;
				((IPersistEntity)this).Activate(false);
				return _unitsInContext;
			} 
			set
			{
				SetValue( v =>  _unitsInContext = v, _unitsInContext, value,  "UnitsInContext", 9);
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
					_longName = value.StringVal;
					return;
				case 6: 
					_phase = value.StringVal;
					return;
				case 7: 
					_representationContexts.InternalAdd((IfcRepresentationContext)value.EntityVal);
					return;
				case 8: 
					_unitsInContext = (IfcUnitAssignment)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProject other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProject
            var root = (@IfcProject)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProject left, @IfcProject right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProject left, @IfcProject right)
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
				foreach(var entity in @RepresentationContexts)
					yield return entity;
				if (@UnitsInContext != null)
					yield return @UnitsInContext;
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