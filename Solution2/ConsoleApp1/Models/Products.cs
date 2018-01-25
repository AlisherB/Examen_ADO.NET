using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Products
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int ? SupplierId { get; set; }
        public int ? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal ? UnitPrice { get; set; }
        public int ? UnitsInStock { get; set; }
        public int ? UnitsOnOrder { get; set; }
        public int ? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public Products()
        {
            Order_Details = new List<Order_Details>();
        }
    }
}