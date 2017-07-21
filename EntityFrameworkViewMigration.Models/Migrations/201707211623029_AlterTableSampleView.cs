namespace EntityFrameworkViewMigration.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using EntityFrameworkViewMigrations.PowerShellCommands.Migrations.Base;

    public partial class AlterTableSampleView : BaseDbMigration
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
