using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class UpdateSupportMap : EntityTypeConfiguration<UpdateSupport>
    {
        public UpdateSupportMap()
        {
            // Primary Key
            this.HasKey(t => t.UpdateSupportId);

            // Properties
            // Table & Column Mappings
            this.ToTable("UpdateSupports");
            this.Property(t => t.UpdateSupportId).HasColumnName("UpdateSupportId");
            this.Property(t => t.UpdateId).HasColumnName("UpdateId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UpdateSupportedDate).HasColumnName("UpdateSupportedDate");

            // Relationships
            this.HasRequired(t => t.Update)
                .WithMany(t => t.UpdateSupports)
                .HasForeignKey(d => d.UpdateId);

        }
    }
}
