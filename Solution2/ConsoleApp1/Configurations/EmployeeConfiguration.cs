using ConsoleApp1.Models;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp1.Configurations
{
    public class EmployeeConfiguration:EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(p => p.EmployeeId);
            Property(p => p.LastName).IsRequired();
            Property(p => p.FirstName).IsRequired();
            Property(p => p.Title).IsRequired();
            Property(p => p.TitleOfCourtesy).IsRequired();
            Property(p => p.BirthDate).IsOptional();
            Property(p => p.HireDate).IsOptional();
            Property(p => p.Address).IsRequired();
            Property(p => p.City).IsRequired();
            Property(p => p.Region).IsRequired();
            Property(p => p.PostalCode).IsRequired();
            Property(p => p.Country).IsRequired();
            Property(p => p.Photo).IsRequired();
            Property(p => p.HomePage).IsRequired();
            Property(p => p.Extension).IsRequired();
            Property(p => p.Notes).IsRequired();
            Property(p => p.ReportsTo).IsOptional();
            Property(p => p.PhotoPath).IsRequired();
        }
    }
}
