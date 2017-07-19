namespace EntityFrameworkViewMigration.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableSample : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.TableSamples",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            this.DropTable("dbo.TableSamples");
        }
    }
}
