using System;

namespace ConsoleApp1.Models
{
    public class Order_Details
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public decimal ? UnitPrice { get; set; }
        public int ? Quantity { get; set; }
        public float ? Discount { get; set; }
        public virtual Orders Order { get; set; }
        public virtual Products Products { get; set; }
    }
}