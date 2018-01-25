using ConsoleApp1.Models;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp1.Configurations
{
    public class TerritoryConfiguration:EntityTypeConfiguration<Territory>
    {
        public TerritoryConfiguration()
        {
            HasKey(p => p.TerritoryId );
            Property(p => p.TerritoryDesc).IsRequired();
            HasRequired(p => p.Region).WithMany(p => p.Territories).HasForeignKey(p => p.TerritoryId);
        }
    }
}
