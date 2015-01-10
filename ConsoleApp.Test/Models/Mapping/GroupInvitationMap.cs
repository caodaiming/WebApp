using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupInvitationMap : EntityTypeConfiguration<GroupInvitation>
    {
        public GroupInvitationMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupInvitationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("GroupInvitations");
            this.Property(t => t.GroupInvitationId).HasColumnName("GroupInvitationId");
            this.Property(t => t.FromUserId).HasColumnName("FromUserId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.ToUserId).HasColumnName("ToUserId");
            this.Property(t => t.SentDate).HasColumnName("SentDate");
            this.Property(t => t.Accepted).HasColumnName("Accepted");

            // Relationships
            this.HasRequired(t => t.Group)
                .WithMany(t => t.GroupInvitations)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
