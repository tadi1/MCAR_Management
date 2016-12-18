namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCatVettingsContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CatVettings",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                        MicrochipNumber = c.Long(nullable: false),
                        MicrochipLocationId = c.Int(),
                        MicrochipManufacturerId = c.Int(),
                        Sterilized = c.Boolean(nullable: false),
                        SterilizationDate = c.DateTime(),
                        SterilizationLocationId = c.Int(),
                        Rabies = c.Boolean(nullable: false),
                        RabiesDate = c.DateTime(),
                        RabiesLocationId = c.Int(),
                        FVRCP1 = c.Boolean(nullable: false),
                        FVRCP1Date = c.DateTime(),
                        FVRCP1LocationId = c.Int(),
                        FVRCP2 = c.Boolean(nullable: false),
                        FVRCP2Date = c.DateTime(),
                        FVRCP2LocationId = c.Int(),
                        FVRCP3 = c.Boolean(nullable: false),
                        FVRCP3Date = c.DateTime(),
                        FVRCP3LocationId = c.Int(),
                        FVRCP3Due = c.DateTime(),
                        DewormerDate = c.DateTime(),
                        DewormerLocationId = c.Int(),
                        FleaTickDate = c.DateTime(),
                        FleaTickLocationId = c.Int(),
                        FEVLeukTested = c.Boolean(nullable: false),
                        FEVLeukDate = c.DateTime(),
                        FEVLeukId = c.Int(),
                        FEVLeukResult = c.Boolean(nullable: false),
                        AddtlVetting = c.Boolean(nullable: false),
                        VetDiagnosis = c.String(),
                        VetDiagnosisDate = c.DateTime(),
                        MedicationsGiven = c.String(),
                        NextVet = c.DateTime(nullable: false),
                        VettingCompleted = c.DateTime(nullable: false),
                        AdtlComments = c.String(),
                        Dewormer_id = c.Short(),
                        FEVLeukLocation_id = c.Int(),
                        FleaTick_id = c.Short(),
                        MicrochipManufacturer_id = c.Short(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Animals", t => t.AnimalId, cascadeDelete: true)
                .ForeignKey("dbo.Medications", t => t.Dewormer_id)
                .ForeignKey("dbo.Locations", t => t.DewormerLocationId)
                .ForeignKey("dbo.Locations", t => t.FEVLeukLocation_id)
                .ForeignKey("dbo.Medications", t => t.FleaTick_id)
                .ForeignKey("dbo.Locations", t => t.FleaTickLocationId)
                .ForeignKey("dbo.Locations", t => t.FVRCP1LocationId)
                .ForeignKey("dbo.Locations", t => t.FVRCP2LocationId)
                .ForeignKey("dbo.Locations", t => t.FVRCP3LocationId)
                .ForeignKey("dbo.Locations", t => t.MicrochipLocationId)
                .ForeignKey("dbo.Medications", t => t.MicrochipManufacturer_id)
                .ForeignKey("dbo.Locations", t => t.RabiesLocationId)
                .ForeignKey("dbo.Locations", t => t.SterilizationLocationId)
                .Index(t => t.AnimalId)
                .Index(t => t.MicrochipLocationId)
                .Index(t => t.SterilizationLocationId)
                .Index(t => t.RabiesLocationId)
                .Index(t => t.FVRCP1LocationId)
                .Index(t => t.FVRCP2LocationId)
                .Index(t => t.FVRCP3LocationId)
                .Index(t => t.DewormerLocationId)
                .Index(t => t.FleaTickLocationId)
                .Index(t => t.Dewormer_id)
                .Index(t => t.FEVLeukLocation_id)
                .Index(t => t.FleaTick_id)
                .Index(t => t.MicrochipManufacturer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CatVettings", "SterilizationLocationId", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "RabiesLocationId", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "MicrochipManufacturer_id", "dbo.Medications");
            DropForeignKey("dbo.CatVettings", "MicrochipLocationId", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "FVRCP3LocationId", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "FVRCP2LocationId", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "FVRCP1LocationId", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "FleaTickLocationId", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "FleaTick_id", "dbo.Medications");
            DropForeignKey("dbo.CatVettings", "FEVLeukLocation_id", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "DewormerLocationId", "dbo.Locations");
            DropForeignKey("dbo.CatVettings", "Dewormer_id", "dbo.Medications");
            DropForeignKey("dbo.CatVettings", "AnimalId", "dbo.Animals");
            DropIndex("dbo.CatVettings", new[] { "MicrochipManufacturer_id" });
            DropIndex("dbo.CatVettings", new[] { "FleaTick_id" });
            DropIndex("dbo.CatVettings", new[] { "FEVLeukLocation_id" });
            DropIndex("dbo.CatVettings", new[] { "Dewormer_id" });
            DropIndex("dbo.CatVettings", new[] { "FleaTickLocationId" });
            DropIndex("dbo.CatVettings", new[] { "DewormerLocationId" });
            DropIndex("dbo.CatVettings", new[] { "FVRCP3LocationId" });
            DropIndex("dbo.CatVettings", new[] { "FVRCP2LocationId" });
            DropIndex("dbo.CatVettings", new[] { "FVRCP1LocationId" });
            DropIndex("dbo.CatVettings", new[] { "RabiesLocationId" });
            DropIndex("dbo.CatVettings", new[] { "SterilizationLocationId" });
            DropIndex("dbo.CatVettings", new[] { "MicrochipLocationId" });
            DropIndex("dbo.CatVettings", new[] { "AnimalId" });
            DropTable("dbo.CatVettings");
        }
    }
}
