using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkViewMigration.Models
{
    public class TableSample
    {
        public int Id { get; set; }

        public string Description { get; set; }
    }

    public class TableSampleDbConfiguration : EntityTypeConfiguration<TableSample>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableSampleDbConfiguration"/> class.
        /// </summary>
        public TableSampleDbConfiguration()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.Description).HasMaxLength(120);
        }
    }
}
