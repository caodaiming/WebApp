using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class SupportInvitationMap : EntityTypeConfiguration<SupportInvitation>
    {
        public SupportInvitationMap()
        {
            // Primary Key
            this.HasKey(t => t.SupportInvitationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SupportInvitations");
            this.Property(t => t.SupportInvitationId).HasColumnName("SupportInvitationId");
            this.Property(t => t.FromUserId).HasColumnName("FromUserId");
            this.Property(t => t.GoalId).HasColumnName("GoalId");
            this.Property(t => t.ToUserId).HasColumnName("ToUserId");
            this.Property(t => t.SentDate).HasColumnName("SentDate");
            this.Property(t => t.Accepted).HasColumnName("Accepted");

            // Relationships
            this.HasRequired(t => t.Goal)
                .WithMany(t => t.SupportInvitations)
                .HasForeignKey(d => d.GoalId);

        }
    }
}
