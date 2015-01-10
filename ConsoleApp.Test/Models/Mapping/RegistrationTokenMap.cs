using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class RegistrationTokenMap : EntityTypeConfiguration<RegistrationToken>
    {
        public RegistrationTokenMap()
        {
            // Primary Key
            this.HasKey(t => t.RegistrationTokenId);

            // Properties
            this.Property(t => t.Role)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RegistrationTokens");
            this.Property(t => t.RegistrationTokenId).HasColumnName("RegistrationTokenId");
            this.Property(t => t.Token).HasColumnName("Token");
            this.Property(t => t.Role).HasColumnName("Role");
        }
    }
}
