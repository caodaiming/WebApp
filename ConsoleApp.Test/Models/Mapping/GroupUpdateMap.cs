using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupUpdateMap : EntityTypeConfiguration<GroupUpdate>
    {
        public GroupUpdateMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupUpdateId);

            // Properties
            // Table & Column Mappings
            this.ToTable("GroupUpdates");
            this.Property(t => t.GroupUpdateId).HasColumnName("GroupUpdateId");
            this.Property(t => t.Updatemsg).HasColumnName("Updatemsg");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.GroupGoalId).HasColumnName("GroupGoalId");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");

            // Relationships
            this.HasRequired(t => t.GroupGoal)
                .WithMany(t => t.GroupUpdates)
                .HasForeignKey(d => d.GroupGoalId);

        }
    }
}
