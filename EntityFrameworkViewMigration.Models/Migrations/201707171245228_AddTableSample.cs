namespace EntityFrameworkViewMigration.Models.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddTableSample : DbMigration
    {
        public override void Up()
        {
            CreateTable(
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
            DropTable("dbo.TableSamples");
        }
    }
}
