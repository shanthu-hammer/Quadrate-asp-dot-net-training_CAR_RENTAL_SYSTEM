namespace carrental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BasicCharges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.basicCharges",
                c => new
                    {
                        StdChrgId = c.Int(nullable: false, identity: true),
                        PackageId = c.Int(nullable: false),
                        VehicleId = c.Int(),
                        OvernightStayCharge = c.Int(nullable: false),
                        ExtraKmCharge = c.Int(nullable: false),
                        DriverCharge = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StdChrgId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.basicCharges");
        }
    }
}
