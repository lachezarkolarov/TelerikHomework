#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
using NorthwindFramework;
using Northwind.Model;


namespace Northwind.Model	
{
	[Table("Order Details")]
	[ConcurrencyControl(OptimisticConcurrencyControlStrategy.Changed)]
	[Serializable()]
	public partial class OrderDetail : NotificationObject
	{
		private int _orderID;
		[Column("OrderID", OpenAccessType = OpenAccessType.Int32, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "int")]
		[Storage("_orderID")]
		public virtual int OrderID 
		{ 
		    get
		    {
		        return this._orderID;
		    }
		    set
		    {
				if (this.OrderID == value)
				{
					return;
				}
		        this._orderID = value;
				this.RaisePropertyChanged("OrderID");
		    }
		}
		
		private int _productID;
		[Column("ProductID", OpenAccessType = OpenAccessType.Int32, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "int")]
		[Storage("_productID")]
		public virtual int ProductID 
		{ 
		    get
		    {
		        return this._productID;
		    }
		    set
		    {
				if (this.ProductID == value)
				{
					return;
				}
		        this._productID = value;
				this.RaisePropertyChanged("ProductID");
		    }
		}
		
		private decimal _unitPrice;
		[Column("UnitPrice", OpenAccessType = OpenAccessType.Currency, Length = 0, Scale = 0, SqlType = "money")]
		[Storage("_unitPrice")]
		public virtual decimal UnitPrice 
		{ 
		    get
		    {
		        return this._unitPrice;
		    }
		    set
		    {
				if (this.UnitPrice == value)
				{
					return;
				}
		        this._unitPrice = value;
				this.RaisePropertyChanged("UnitPrice");
		    }
		}
		
		private short _quantity;
		[Column("Quantity", OpenAccessType = OpenAccessType.Int16, Length = 0, Scale = 0, SqlType = "smallint")]
		[Storage("_quantity")]
		public virtual short Quantity 
		{ 
		    get
		    {
		        return this._quantity;
		    }
		    set
		    {
				if (this.Quantity == value)
				{
					return;
				}
		        this._quantity = value;
				this.RaisePropertyChanged("Quantity");
		    }
		}
		
		private float _discount;
		[Column("Discount", OpenAccessType = OpenAccessType.Real, Length = 0, Scale = 0, SqlType = "real")]
		[Storage("_discount")]
		public virtual float Discount 
		{ 
		    get
		    {
		        return this._discount;
		    }
		    set
		    {
				if (this.Discount == value)
				{
					return;
				}
		        this._discount = value;
				this.RaisePropertyChanged("Discount");
		    }
		}
		
		private Order _order;
		[ForeignKeyAssociation(ConstraintName = "FK_Order_Details_Orders", SharedFields = "OrderID", TargetFields = "OrderID")]
		[Storage("_order")]
		public virtual Order Order 
		{ 
		    get
		    {
		        return this._order;
		    }
		    set
		    {
				if (this.Order == value)
				{
					return;
				}
		        this._order = value;
				this.RaisePropertyChanged("Order");
		    }
		}
		
		private Product _product;
		[ForeignKeyAssociation(ConstraintName = "FK_Order_Details_Products", SharedFields = "ProductID", TargetFields = "ProductID")]
		[Storage("_product")]
		public virtual Product Product 
		{ 
		    get
		    {
		        return this._product;
		    }
		    set
		    {
				if (this.Product == value)
				{
					return;
				}
		        this._product = value;
				this.RaisePropertyChanged("Product");
		    }
		}
		
	}
}
