using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupGoalMap : EntityTypeConfiguration<GroupGoal>
    {
        public GroupGoalMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupGoalId);

            // Properties
            this.Property(t => t.GoalName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GroupGoals");
            this.Property(t => t.GroupGoalId).HasColumnName("GroupGoalId");
            this.Property(t => t.GoalName).HasColumnName("GoalName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Target).HasColumnName("Target");
            this.Property(t => t.MetricId).HasColumnName("MetricId");
            this.Property(t => t.FocusId).HasColumnName("FocusId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.GoalStatusId).HasColumnName("GoalStatusId");
            this.Property(t => t.GroupUserId).HasColumnName("GroupUserId");
            this.Property(t => t.AssignedGroupUserId).HasColumnName("AssignedGroupUserId");
            this.Property(t => t.AssignedTo).HasColumnName("AssignedTo");
            this.Property(t => t.GroupId).HasColumnName("GroupId");

            // Relationships
            this.HasOptional(t => t.Focus)
                .WithMany(t => t.GroupGoals)
                .HasForeignKey(d => d.FocusId);
            this.HasRequired(t => t.GoalStatu)
                .WithMany(t => t.GroupGoals)
                .HasForeignKey(d => d.GoalStatusId);
            this.HasRequired(t => t.Group)
                .WithMany(t => t.GroupGoals)
                .HasForeignKey(d => d.GroupId);
            this.HasRequired(t => t.GroupUser)
                .WithMany(t => t.GroupGoals)
                .HasForeignKey(d => d.GroupUserId);
            this.HasOptional(t => t.Metric)
                .WithMany(t => t.GroupGoals)
                .HasForeignKey(d => d.MetricId);

        }
    }
}
