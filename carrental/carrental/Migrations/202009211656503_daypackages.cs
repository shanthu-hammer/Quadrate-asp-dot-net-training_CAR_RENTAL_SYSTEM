namespace carrental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class daypackages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DayPackages", "Pcost", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DayPackages", "Pcost");
        }
    }
}
