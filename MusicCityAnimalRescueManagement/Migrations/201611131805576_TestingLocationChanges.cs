namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestingLocationChanges : DbMigration
    {
        public override void Up()
        {
            //Sql("ALTER TABLE dbo.DogVettings ON DELETE NO ACTION");

            DropForeignKey("dbo.DogVettings", "SterilizationLocationid", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "SterilizationLocationid" });
            AddColumn("dbo.DogVettings", "BordetellaLocationId", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "RabiesLocationId", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "DA2PPR1LocationId", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "DA2PPR2LocationId", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "DA2PPR3LocationId", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "HeartwormLocationId", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "DewormerLocationId", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "FleaTickLocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.DogVettings", "SterilizationLocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.DogVettings", "SterilizationLocationId");
            CreateIndex("dbo.DogVettings", "BordetellaLocationId");
            CreateIndex("dbo.DogVettings", "RabiesLocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR1LocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR2LocationId");
            CreateIndex("dbo.DogVettings", "DA2PPR3LocationId");
            CreateIndex("dbo.DogVettings", "HeartwormLocationId");
            CreateIndex("dbo.DogVettings", "DewormerLocationId");
            CreateIndex("dbo.DogVettings", "FleaTickLocationId");
            AddForeignKey("dbo.DogVettings", "BordetellaLocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "DA2PPR1LocationId", "dbo.Locations", "id", cascadeDelete: false);
            AddForeignKey("dbo.DogVettings", "DA2PPR2LocationId", "dbo.Locations", "id", cascadeDelete: false);
            AddForeignKey("dbo.DogVettings", "DA2PPR3LocationId", "dbo.Locations", "id", cascadeDelete: false);
            AddForeignKey("dbo.DogVettings", "DewormerLocationId", "dbo.Locations", "id", cascadeDelete: false);
            AddForeignKey("dbo.DogVettings", "FleaTickLocationId", "dbo.Locations", "id", cascadeDelete: false);
            AddForeignKey("dbo.DogVettings", "HeartwormLocationId", "dbo.Locations", "id", cascadeDelete: false);
            AddForeignKey("dbo.DogVettings", "RabiesLocationId", "dbo.Locations", "id", cascadeDelete: false);
            AddForeignKey("dbo.DogVettings", "SterilizationLocationId", "dbo.Locations", "id", cascadeDelete: false);
            DropColumn("dbo.DogVettings", "BordetellaLocation");
            DropColumn("dbo.DogVettings", "RabiesLocation");
            DropColumn("dbo.DogVettings", "DA2PPR1Location");
            DropColumn("dbo.DogVettings", "DA2PPR2Location");
            DropColumn("dbo.DogVettings", "DA2PPR3Location");
            DropColumn("dbo.DogVettings", "HeartwormLocation");
            DropColumn("dbo.DogVettings", "DewormerLocation");
            DropColumn("dbo.DogVettings", "FleaTickLocation");
            //Sql("ALTER TABLE dbo.DogVettings CHECK CONSTRAINT ALL");

        }

        public override void Down()
        {
            AddColumn("dbo.DogVettings", "FleaTickLocation", c => c.Int());
            AddColumn("dbo.DogVettings", "DewormerLocation", c => c.Int());
            AddColumn("dbo.DogVettings", "HeartwormLocation", c => c.Int());
            AddColumn("dbo.DogVettings", "DA2PPR3Location", c => c.Int());
            AddColumn("dbo.DogVettings", "DA2PPR2Location", c => c.Int());
            AddColumn("dbo.DogVettings", "DA2PPR1Location", c => c.Int());
            AddColumn("dbo.DogVettings", "RabiesLocation", c => c.Int());
            AddColumn("dbo.DogVettings", "BordetellaLocation", c => c.Int());
            DropForeignKey("dbo.DogVettings", "SterilizationLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "RabiesLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "HeartwormLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "FleaTickLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DewormerLocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR3LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR2LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR1LocationId", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "BordetellaLocationId", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "FleaTickLocationId" });
            DropIndex("dbo.DogVettings", new[] { "DewormerLocationId" });
            DropIndex("dbo.DogVettings", new[] { "HeartwormLocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR3LocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR2LocationId" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR1LocationId" });
            DropIndex("dbo.DogVettings", new[] { "RabiesLocationId" });
            DropIndex("dbo.DogVettings", new[] { "BordetellaLocationId" });
            DropIndex("dbo.DogVettings", new[] { "SterilizationLocationId" });
            AlterColumn("dbo.DogVettings", "SterilizationLocationId", c => c.Int());
            DropColumn("dbo.DogVettings", "FleaTickLocationId");
            DropColumn("dbo.DogVettings", "DewormerLocationId");
            DropColumn("dbo.DogVettings", "HeartwormLocationId");
            DropColumn("dbo.DogVettings", "DA2PPR3LocationId");
            DropColumn("dbo.DogVettings", "DA2PPR2LocationId");
            DropColumn("dbo.DogVettings", "DA2PPR1LocationId");
            DropColumn("dbo.DogVettings", "RabiesLocationId");
            DropColumn("dbo.DogVettings", "BordetellaLocationId");
            CreateIndex("dbo.DogVettings", "SterilizationLocationid");
            AddForeignKey("dbo.DogVettings", "SterilizationLocationid", "dbo.Locations", "id");
        }
    }
}
