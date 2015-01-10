using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupCommentUserMap : EntityTypeConfiguration<GroupCommentUser>
    {
        public GroupCommentUserMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupCommentUserId);

            // Properties
            this.Property(t => t.UserId)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("GroupCommentUsers");
            this.Property(t => t.GroupCommentUserId).HasColumnName("GroupCommentUserId");
            this.Property(t => t.GroupCommentId).HasColumnName("GroupCommentId");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
