using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupCommentMap : EntityTypeConfiguration<GroupComment>
    {
        public GroupCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupCommentId);

            // Properties
            // Table & Column Mappings
            this.ToTable("GroupComments");
            this.Property(t => t.GroupCommentId).HasColumnName("GroupCommentId");
            this.Property(t => t.CommentText).HasColumnName("CommentText");
            this.Property(t => t.GroupUpdateId).HasColumnName("GroupUpdateId");
            this.Property(t => t.CommentDate).HasColumnName("CommentDate");

            // Relationships
            this.HasRequired(t => t.GroupUpdate)
                .WithMany(t => t.GroupComments)
                .HasForeignKey(d => d.GroupUpdateId);

        }
    }
}
