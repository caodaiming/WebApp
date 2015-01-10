using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupUserMap : EntityTypeConfiguration<GroupUser>
    {
        public GroupUserMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupUserId);

            // Properties
            this.Property(t => t.UserId)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("GroupUsers");
            this.Property(t => t.GroupUserId).HasColumnName("GroupUserId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Admin).HasColumnName("Admin");
            this.Property(t => t.AddedDate).HasColumnName("AddedDate");
        }
    }
}
