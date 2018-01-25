using ConsoleApp1.Models;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp1.Configurations
{
    public class CustomerConfigurationusing:EntityTypeConfiguration<Customer>
    {
        public CustomerConfigurationusing()
        {
            HasKey(p => p.CustomerId);
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
        }
    }
}
