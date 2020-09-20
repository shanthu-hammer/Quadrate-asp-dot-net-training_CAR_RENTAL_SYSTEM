namespace carrental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vehicle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        VehicleName = c.String(),
                        RatePerDay = c.Int(nullable: false),
                        RatePerWeek = c.Int(nullable: false),
                        RatePerMonth = c.Int(nullable: false),
                        RatePerNightPark = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.vehicles");
        }
    }
}
