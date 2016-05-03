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
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.TopologyResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOpenShell
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOpenShell : IIfcConnectedFaceSet, IfcShell
	{
	
	}
}

namespace Xbim.Ifc2x3.TopologyResource
{
	[ExpressType("IfcOpenShell", 488)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOpenShell : IfcConnectedFaceSet, IInstantiableEntity, IIfcOpenShell, IContainsEntityReferences, IEquatable<@IfcOpenShell>
	{
		#region IIfcOpenShell explicit implementation
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOpenShell(IModel model) : base(model) 		{ 
			Model = model; 
		}






		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOpenShell other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOpenShell
            var root = (@IfcOpenShell)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOpenShell left, @IfcOpenShell right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcOpenShell left, @IfcOpenShell right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcOpenShell left, IfcShell right)
		{
			return left == right as @IfcOpenShell;
		}

		public static bool operator !=(@IfcOpenShell left, IfcShell right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @CfsFaces)
					yield return entity;
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