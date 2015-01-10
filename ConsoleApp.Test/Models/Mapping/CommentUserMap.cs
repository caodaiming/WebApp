using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class CommentUserMap : EntityTypeConfiguration<CommentUser>
    {
        public CommentUserMap()
        {
            // Primary Key
            this.HasKey(t => t.CommentUserId);

            // Properties
            this.Property(t => t.UserId)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("CommentUsers");
            this.Property(t => t.CommentUserId).HasColumnName("CommentUserId");
            this.Property(t => t.CommentId).HasColumnName("CommentId");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
