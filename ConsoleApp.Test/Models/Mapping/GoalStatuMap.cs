using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GoalStatuMap : EntityTypeConfiguration<GoalStatu>
    {
        public GoalStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.GoalStatusId);

            // Properties
            this.Property(t => t.GoalStatusType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GoalStatus");
            this.Property(t => t.GoalStatusId).HasColumnName("GoalStatusId");
            this.Property(t => t.GoalStatusType).HasColumnName("GoalStatusType");
        }
    }
}
