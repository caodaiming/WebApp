using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class GroupUpdateUserMap : EntityTypeConfiguration<GroupUpdateUser>
    {
        public GroupUpdateUserMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupUpdateUserId);

            // Properties
            this.Property(t => t.UserId)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("GroupUpdateUsers");
            this.Property(t => t.GroupUpdateUserId).HasColumnName("GroupUpdateUserId");
            this.Property(t => t.GroupUpdateId).HasColumnName("GroupUpdateId");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
