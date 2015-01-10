using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class FocusMap : EntityTypeConfiguration<Focus>
    {
        public FocusMap()
        {
            // Primary Key
            this.HasKey(t => t.FocusId);

            // Properties
            this.Property(t => t.FocusName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Foci");
            this.Property(t => t.FocusId).HasColumnName("FocusId");
            this.Property(t => t.FocusName).HasColumnName("FocusName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");

            // Relationships
            this.HasRequired(t => t.Group)
                .WithMany(t => t.Foci)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
