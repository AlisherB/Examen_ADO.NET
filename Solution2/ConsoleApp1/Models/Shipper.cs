using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Shipper
    {
        public Guid ShippedId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public Shipper()
        {
            Orders = new List<Orders>();
        }
    }
}