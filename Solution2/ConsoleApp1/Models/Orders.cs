﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Orders
    {
        public Guid OrderId { get; set; }
        public int ? CustomerId { get; set; }
        public int ? EmployeeId { get; set; }
        public DateTime ? OrderDate { get; set; }
        public DateTime ? RequiredDate { get; set; }
        public DateTime ? ShippedDate { get; set; }
        public int ? ShipVia { get; set; }
        public double ? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public Orders()
        {
            Order_Details = new List<Order_Details>();
        }
    }
}
