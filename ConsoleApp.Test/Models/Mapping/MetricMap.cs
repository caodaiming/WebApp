using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConsoleApp.Test.Models.Mapping
{
    public class MetricMap : EntityTypeConfiguration<Metric>
    {
        public MetricMap()
        {
            // Primary Key
            this.HasKey(t => t.MetricId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Metrics");
            this.Property(t => t.MetricId).HasColumnName("MetricId");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
