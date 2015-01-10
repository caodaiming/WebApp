using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class SecurityTokenMap : EntityTypeConfiguration<SecurityToken>
    {
        public SecurityTokenMap()
        {
            // Primary Key
            this.HasKey(t => t.SecurityTokenId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecurityTokens");
            this.Property(t => t.SecurityTokenId).HasColumnName("SecurityTokenId");
            this.Property(t => t.Token).HasColumnName("Token");
            this.Property(t => t.ActualID).HasColumnName("ActualID");
        }
    }
}
