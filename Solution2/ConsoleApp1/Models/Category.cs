using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp1.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public Category()
        {
            Products = new List<Products>();
        }
    }
}