using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GoalMap : EntityTypeConfiguration<Goal>
    {
        public GoalMap()
        {
            // Primary Key
            this.HasKey(t => t.GoalId);

            // Properties
            this.Property(t => t.GoalName)
                .IsRequired()
                .HasMaxLength(55);

            this.Property(t => t.Desc)
                .HasMaxLength(100);

            this.Property(t => t.UserId)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Goals");
            this.Property(t => t.GoalId).HasColumnName("GoalId");
            this.Property(t => t.GoalName).HasColumnName("GoalName");
            this.Property(t => t.Desc).HasColumnName("Desc");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Target).HasColumnName("Target");
            this.Property(t => t.GoalType).HasColumnName("GoalType");
            this.Property(t => t.MetricId).HasColumnName("MetricId");
            this.Property(t => t.GoalStatusId).HasColumnName("GoalStatusId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");

            // Relationships
            this.HasOptional(t => t.AspNetUser)
                .WithMany(t => t.Goals)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.GoalStatu)
                .WithMany(t => t.Goals)
                .HasForeignKey(d => d.GoalStatusId);
            this.HasOptional(t => t.Metric)
                .WithMany(t => t.Goals)
                .HasForeignKey(d => d.MetricId);

        }
    }
}
