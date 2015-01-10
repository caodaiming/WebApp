using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class FollowRequestMap : EntityTypeConfiguration<FollowRequest>
    {
        public FollowRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.FollowRequestId);

            // Properties
            this.Property(t => t.FromUserId)
                .IsRequired();

            this.Property(t => t.ToUserId)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("FollowRequests");
            this.Property(t => t.FollowRequestId).HasColumnName("FollowRequestId");
            this.Property(t => t.FromUserId).HasColumnName("FromUserId");
            this.Property(t => t.ToUserId).HasColumnName("ToUserId");
            this.Property(t => t.Accepted).HasColumnName("Accepted");
        }
    }
}
