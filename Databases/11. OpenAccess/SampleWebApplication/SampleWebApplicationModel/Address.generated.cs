#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using SampleWebApplicationModel;

namespace SampleWebApplicationModel	
{
	public partial class Address
	{
		private int _addressID;
		public virtual int AddressID
		{
			get
			{
				return this._addressID;
			}
			set
			{
				this._addressID = value;
			}
		}
		
		private string _addressText;
		public virtual string AddressText
		{
			get
			{
				return this._addressText;
			}
			set
			{
				this._addressText = value;
			}
		}
		
		private int? _townID;
		public virtual int? TownID
		{
			get
			{
				return this._townID;
			}
			set
			{
				this._townID = value;
			}
		}
		
		private Town _town;
		public virtual Town Town
		{
			get
			{
				return this._town;
			}
			set
			{
				this._town = value;
			}
		}
		
		private IList<Employee> _employees = new List<Employee>();
		public virtual IList<Employee> Employees
		{
			get
			{
				return this._employees;
			}
		}
		
	}
}
#pragma warning restore 1591