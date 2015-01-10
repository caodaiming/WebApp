using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class UpdateMap : EntityTypeConfiguration<Update>
    {
        public UpdateMap()
        {
            // Primary Key
            this.HasKey(t => t.UpdateId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Updates");
            this.Property(t => t.UpdateId).HasColumnName("UpdateId");
            this.Property(t => t.Updatemsg).HasColumnName("Updatemsg");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.GoalId).HasColumnName("GoalId");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");

            // Relationships
            this.HasRequired(t => t.Goal)
                .WithMany(t => t.Updates)
                .HasForeignKey(d => d.GoalId);

        }
    }
}
