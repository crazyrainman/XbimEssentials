// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ControlExtension
{
	public partial class @IfcRelAssociatesApproval : IIfcRelAssociatesApproval
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssociatesApproval), 6)]
		IIfcApproval IIfcRelAssociatesApproval.RelatingApproval 
		{ 
			get
			{
				return RelatingApproval;
			} 
			set
			{
				RelatingApproval = value as ApprovalResource.IfcApproval;
				
			}
		}
	//## Custom code
	//##
	}
}