namespace carrental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingvalues : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.vehicles", "RatePerhour", c => c.Int(nullable: false));
            DropColumn("dbo.vehicles", "RatePerDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.vehicles", "RatePerDay", c => c.Int(nullable: false));
            DropColumn("dbo.vehicles", "RatePerhour");
        }
    }
}
