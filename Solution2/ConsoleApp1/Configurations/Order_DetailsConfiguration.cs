using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configurations
{

    public class Order_DetailsConfiguration : EntityTypeConfiguration<Order_Details>
    {
        public Order_DetailsConfiguration()
        {
            HasKey(p => new { p.OrderId, p.ProductId });
            Property(p => p.UnitPrice).IsOptional();
            Property(p => p.Quantity).IsOptional();
            Property(p => p.Discount).IsOptional();
            HasRequired(p => p.Order).WithMany(p => p.Order_Details).HasForeignKey(p => p.OrderId);
            HasRequired(p => p.Products).WithMany(p => p.Order_Details).HasForeignKey(p => p.ProductId);
        }
        
    }
}
