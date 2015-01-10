using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class SupportMap : EntityTypeConfiguration<Support>
    {
        public SupportMap()
        {
            // Primary Key
            this.HasKey(t => t.SupportId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Supports");
            this.Property(t => t.SupportId).HasColumnName("SupportId");
            this.Property(t => t.GoalId).HasColumnName("GoalId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.SupportedDate).HasColumnName("SupportedDate");

            // Relationships
            this.HasRequired(t => t.Goal)
                .WithMany(t => t.Supports)
                .HasForeignKey(d => d.GoalId);

        }
    }
}
