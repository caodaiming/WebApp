using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupRequestMap : EntityTypeConfiguration<GroupRequest>
    {
        public GroupRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupRequestId);

            // Properties
            this.Property(t => t.UserId)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("GroupRequests");
            this.Property(t => t.GroupRequestId).HasColumnName("GroupRequestId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Accepted).HasColumnName("Accepted");

            // Relationships
            this.HasOptional(t => t.AspNetUser)
                .WithMany(t => t.GroupRequests)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.Group)
                .WithMany(t => t.GroupRequests)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
