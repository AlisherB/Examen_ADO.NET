using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configurations
{
    public class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration()
        {
            HasKey(p => p.SupplierId);
            Property(p => p.CompanyName).IsRequired();
            Property(p => p.ContactName).IsRequired();
            Property(p => p.ContactTitle).IsRequired();
            Property(p => p.Address).IsRequired();
            Property(p => p.City).IsRequired();
            Property(p => p.Region).IsRequired();
            Property(p => p.PostalCode).IsRequired();
            Property(p => p.Country).IsRequired();
            Property(p => p.Phone).IsRequired();
            Property(p => p.Fax).IsRequired();
            Property(p => p.HomePage).IsRequired();
        }
    }
}
