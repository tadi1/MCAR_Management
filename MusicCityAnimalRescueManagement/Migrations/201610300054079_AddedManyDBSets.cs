namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedManyDBSets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DogVettings",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        Sterilized = c.Boolean(nullable: false),
                        SterilizationDate = c.DateTime(nullable: false),
                        Rabies = c.Boolean(nullable: false),
                        RabiesDate = c.DateTime(nullable: false),
                        DA2PPR1 = c.Boolean(nullable: false),
                        DA2PPR1Date = c.DateTime(nullable: false),
                        DA2PPR2 = c.Boolean(nullable: false),
                        DA2PPR2Date = c.DateTime(nullable: false),
                        DA2PPR3 = c.Boolean(nullable: false),
                        DA2PPR3Date = c.DateTime(nullable: false),
                        HeartwormTested = c.Boolean(nullable: false),
                        HeartwormDate = c.DateTime(nullable: false),
                        DewormerDate = c.DateTime(nullable: false),
                        DA2PPR1Location_id = c.Int(),
                        DA2PPR2Location_id = c.Int(),
                        DA2PPR3Location_id = c.Int(),
                        Dewormer_id = c.Short(nullable: false),
                        HeartwormLocation_id = c.Int(),
                        RabiesLocation_id = c.Int(),
                        SterilizationLocation_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Locations", t => t.DA2PPR1Location_id)
                .ForeignKey("dbo.Locations", t => t.DA2PPR2Location_id)
                .ForeignKey("dbo.Locations", t => t.DA2PPR3Location_id)
                .ForeignKey("dbo.Medications", t => t.Dewormer_id, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.HeartwormLocation_id)
                .ForeignKey("dbo.Locations", t => t.RabiesLocation_id)
                .ForeignKey("dbo.Locations", t => t.SterilizationLocation_id)
                .Index(t => t.DA2PPR1Location_id)
                .Index(t => t.DA2PPR2Location_id)
                .Index(t => t.DA2PPR3Location_id)
                .Index(t => t.Dewormer_id)
                .Index(t => t.HeartwormLocation_id)
                .Index(t => t.RabiesLocation_id)
                .Index(t => t.SterilizationLocation_id);
            
            CreateTable(
                "dbo.Medications",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Sexes",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        Adopted = c.Boolean(nullable: false),
                        ReadyForAdoption = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DogVettings", "SterilizationLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "RabiesLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "HeartwormLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "Dewormer_id", "dbo.Medications");
            DropForeignKey("dbo.DogVettings", "DA2PPR3Location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR2Location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR1Location_id", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "SterilizationLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "RabiesLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "HeartwormLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "Dewormer_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR3Location_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR2Location_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR1Location_id" });
            DropTable("dbo.Status");
            DropTable("dbo.Sexes");
            DropTable("dbo.Medications");
            DropTable("dbo.DogVettings");
        }
    }
}
