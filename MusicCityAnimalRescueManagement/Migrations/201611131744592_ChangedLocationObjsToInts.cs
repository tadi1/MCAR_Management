namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedLocationObjsToInts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DogVettings", "BordetellaLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR1Location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR2Location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR3Location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DewormerLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "FleaTickLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "HeartwormLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "RabiesLocation_id", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "BordetellaLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR1Location_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR2Location_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR3Location_id" });
            DropIndex("dbo.DogVettings", new[] { "DewormerLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "FleaTickLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "HeartwormLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "RabiesLocation_id" });
            AddColumn("dbo.DogVettings", "BordetellaLocation", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "RabiesLocation", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "DA2PPR1Location", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "DA2PPR2Location", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "DA2PPR3Location", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "HeartwormLocation", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "DewormerLocation", c => c.Int(nullable: false));
            AddColumn("dbo.DogVettings", "FleaTickLocation", c => c.Int(nullable: false));
            DropColumn("dbo.DogVettings", "BordetellaLocation_id");
            DropColumn("dbo.DogVettings", "DA2PPR1Location_id");
            DropColumn("dbo.DogVettings", "DA2PPR2Location_id");
            DropColumn("dbo.DogVettings", "DA2PPR3Location_id");
            DropColumn("dbo.DogVettings", "DewormerLocation_id");
            DropColumn("dbo.DogVettings", "FleaTickLocation_id");
            DropColumn("dbo.DogVettings", "HeartwormLocation_id");
            DropColumn("dbo.DogVettings", "RabiesLocation_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DogVettings", "RabiesLocation_id", c => c.Int());
            AddColumn("dbo.DogVettings", "HeartwormLocation_id", c => c.Int());
            AddColumn("dbo.DogVettings", "FleaTickLocation_id", c => c.Int());
            AddColumn("dbo.DogVettings", "DewormerLocation_id", c => c.Int());
            AddColumn("dbo.DogVettings", "DA2PPR3Location_id", c => c.Int());
            AddColumn("dbo.DogVettings", "DA2PPR2Location_id", c => c.Int());
            AddColumn("dbo.DogVettings", "DA2PPR1Location_id", c => c.Int());
            AddColumn("dbo.DogVettings", "BordetellaLocation_id", c => c.Int());
            DropColumn("dbo.DogVettings", "FleaTickLocation");
            DropColumn("dbo.DogVettings", "DewormerLocation");
            DropColumn("dbo.DogVettings", "HeartwormLocation");
            DropColumn("dbo.DogVettings", "DA2PPR3Location");
            DropColumn("dbo.DogVettings", "DA2PPR2Location");
            DropColumn("dbo.DogVettings", "DA2PPR1Location");
            DropColumn("dbo.DogVettings", "RabiesLocation");
            DropColumn("dbo.DogVettings", "BordetellaLocation");
            CreateIndex("dbo.DogVettings", "RabiesLocation_id");
            CreateIndex("dbo.DogVettings", "HeartwormLocation_id");
            CreateIndex("dbo.DogVettings", "FleaTickLocation_id");
            CreateIndex("dbo.DogVettings", "DewormerLocation_id");
            CreateIndex("dbo.DogVettings", "DA2PPR3Location_id");
            CreateIndex("dbo.DogVettings", "DA2PPR2Location_id");
            CreateIndex("dbo.DogVettings", "DA2PPR1Location_id");
            CreateIndex("dbo.DogVettings", "BordetellaLocation_id");
            AddForeignKey("dbo.DogVettings", "RabiesLocation_id", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "HeartwormLocation_id", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "FleaTickLocation_id", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "DewormerLocation_id", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "DA2PPR3Location_id", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "DA2PPR2Location_id", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "DA2PPR1Location_id", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "BordetellaLocation_id", "dbo.Locations", "id");
        }
    }
}
