using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupUpdateSupportMap : EntityTypeConfiguration<GroupUpdateSupport>
    {
        public GroupUpdateSupportMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupUpdateSupportId);

            // Properties
            // Table & Column Mappings
            this.ToTable("GroupUpdateSupports");
            this.Property(t => t.GroupUpdateSupportId).HasColumnName("GroupUpdateSupportId");
            this.Property(t => t.GroupUpdateId).HasColumnName("GroupUpdateId");
            this.Property(t => t.GroupUserId).HasColumnName("GroupUserId");
            this.Property(t => t.UpdateSupportedDate).HasColumnName("UpdateSupportedDate");

            // Relationships
            this.HasRequired(t => t.GroupUpdate)
                .WithMany(t => t.GroupUpdateSupports)
                .HasForeignKey(d => d.GroupUpdateId);

        }
    }
}
