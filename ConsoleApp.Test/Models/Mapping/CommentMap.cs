using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.CommentId);

            // Properties
            this.Property(t => t.CommentText)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Comments");
            this.Property(t => t.CommentId).HasColumnName("CommentId");
            this.Property(t => t.CommentText).HasColumnName("CommentText");
            this.Property(t => t.UpdateId).HasColumnName("UpdateId");
            this.Property(t => t.CommentDate).HasColumnName("CommentDate");

            // Relationships
            this.HasRequired(t => t.Update)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.UpdateId);

        }
    }
}
