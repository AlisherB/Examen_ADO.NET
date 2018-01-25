using ConsoleApp1.Models;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp1.Configurations
{
    public class ShipperConfiguration : EntityTypeConfiguration<Shipper>
    {
        public ShipperConfiguration()
        {
            HasKey(p => p.ShippedId);
            Property(p => p.CompanyName).HasMaxLength(100).IsRequired();
            Property(p => p.Phone).HasMaxLength(20).IsRequired();
        }
    }
}
