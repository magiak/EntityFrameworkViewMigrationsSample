using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkViewMigration.Models
{
    public class EntityFrameworkViewMigrationDbContext : DbContext
    {
        /// <summary>
        /// The DefaultConnectionStringName constant
        /// </summary>
        public const string DefaultConnectionStringName = "DefaultConnection";

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityFrameworkViewMigrationDbContext" /> class.
        /// </summary>
        /// <param name="connectionName">The connectionName parameter</param>
        public EntityFrameworkViewMigrationDbContext(string connectionName)
            : base(connectionName)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityFrameworkViewMigrationDbContext" /> class.
        /// </summary>
        public EntityFrameworkViewMigrationDbContext()
            : base(DefaultConnectionStringName)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<TableSample> TableSamples { get; set; }

        /// <summary>
        /// The OnModelCreating method
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder parameter</param>
        /// <remarks>Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuilder, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the <see cref="DbModelBuilder"/> and
        /// <see cref="DbContextFactory"/> classes directly.</remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
