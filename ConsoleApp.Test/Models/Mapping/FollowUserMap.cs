using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class FollowUserMap : EntityTypeConfiguration<FollowUser>
    {
        public FollowUserMap()
        {
            // Primary Key
            this.HasKey(t => t.FollowUserId);

            // Properties
            this.Property(t => t.ToUserId)
                .HasMaxLength(128);

            this.Property(t => t.FromUserId)
                .HasMaxLength(128);

            this.Property(t => t.ApplicationUser_Id)
                .HasMaxLength(128);

            this.Property(t => t.ApplicationUser_Id1)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("FollowUsers");
            this.Property(t => t.FollowUserId).HasColumnName("FollowUserId");
            this.Property(t => t.ToUserId).HasColumnName("ToUserId");
            this.Property(t => t.FromUserId).HasColumnName("FromUserId");
            this.Property(t => t.Accepted).HasColumnName("Accepted");
            this.Property(t => t.AddedDate).HasColumnName("AddedDate");
            this.Property(t => t.ApplicationUser_Id).HasColumnName("ApplicationUser_Id");
            this.Property(t => t.ApplicationUser_Id1).HasColumnName("ApplicationUser_Id1");

            // Relationships
            this.HasOptional(t => t.AspNetUser)
                .WithMany(t => t.FollowUsers)
                .HasForeignKey(d => d.ApplicationUser_Id);
            this.HasOptional(t => t.AspNetUser1)
                .WithMany(t => t.FollowUsers1)
                .HasForeignKey(d => d.ApplicationUser_Id1);
            this.HasOptional(t => t.AspNetUser2)
                .WithMany(t => t.FollowUsers2)
                .HasForeignKey(d => d.FromUserId);
            this.HasOptional(t => t.AspNetUser3)
                .WithMany(t => t.FollowUsers3)
                .HasForeignKey(d => d.ToUserId);

        }
    }
}
