using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Region
    {
        public Guid RegionId { get; set; }
        public string RegionDesc { get; set; }
        public virtual ICollection<Territory> Territories { get; set; }
        public Region()
        {
            Territories = new List<Territory>();
        }
    }
}
