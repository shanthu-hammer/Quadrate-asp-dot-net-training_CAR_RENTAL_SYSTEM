namespace carrental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Daypackage1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DayPackages",
                c => new
                    {
                        PackageId = c.Int(nullable: false, identity: true),
                        PName = c.String(),
                        PDistance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PackageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DayPackages");
        }
    }
}
