namespace EntityFrameworkViewMigration.Models.Migrations
{
    using EntityFrameworkViewMigrations.PowerShellCommands.Migrations.Base;

    public partial class CreateTableSampleView : BaseDbMigration
    {
        public override void Up()
        {
            this.DatabaseSqlFile("TableSampleViewUp");
        }
        
        public override void Down()
        {
            this.DatabaseSqlFile("TableSampleViewDown");
        }
    }
}
