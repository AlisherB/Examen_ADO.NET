using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Territory
    {
        public Guid TerritoryId { get; set; }
        public string TerritoryDesc { get; set; }
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public Territory()
        {
            Employees = new List<Employee>();
        }
    }
}