using ConsoleApp1.Models;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp1.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Orders>
    {
        public OrderConfiguration()
        {
            HasKey(p => p.OrderId);
            Property(p => p.OrderDate).IsOptional();
            Property(p => p.RequiredDate).IsOptional();
            Property(p => p.ShippedDate).IsOptional();
            Property(p => p.ShipVia).IsOptional();
            Property(p => p.Freight).IsOptional();
            Property(p => p.ShipName).IsRequired();
            Property(p => p.ShipAddress).IsRequired();
            Property(p => p.ShipCity).IsRequired();
            Property(p => p.ShipCountry).IsRequired();
            Property(p => p.ShipPostalCode).IsRequired();
            Property(p => p.ShipRegion).IsRequired();
            HasRequired(p => p.Customer).WithMany(p => p.Orders).HasForeignKey(p => p.CustomerId);
            HasRequired(p => p.Employee).WithMany(p => p.Orders).HasForeignKey(p => p.EmployeeId);
        }
    }
}
