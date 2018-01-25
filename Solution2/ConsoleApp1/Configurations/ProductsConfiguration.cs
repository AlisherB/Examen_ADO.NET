using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configurations
{
    public class ProductsConfiguration : EntityTypeConfiguration<Products>
    {
        public ProductsConfiguration()
        {
            HasKey(p => p.ProductId);
            Property(p => p.ProductName).IsRequired();
            Property(p => p.QuantityPerUnit).IsOptional();
            Property(p => p.UnitPrice).IsOptional();
            Property(p => p.UnitsInStock).IsOptional();
            Property(p => p.UnitsOnOrder).IsOptional();
            Property(p => p.ReorderLevel).IsOptional();
            Property(p => p.Discontinued).IsRequired();
            HasRequired(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId);
            HasRequired(p => p.Supplier).WithMany(p => p.Products).HasForeignKey(p => p.SupplierId);

        }
    }
}
