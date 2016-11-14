namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestingDTForLocations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DogVettings", "SterilizationLocation_id", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "SterilizationLocation_id" });
            AddColumn("dbo.DogVettings", "SterilizationLocation", c => c.Int(nullable: false));
            DropColumn("dbo.DogVettings", "SterilizationLocation_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DogVettings", "SterilizationLocation_id", c => c.Int());
            DropColumn("dbo.DogVettings", "SterilizationLocation");
            CreateIndex("dbo.DogVettings", "SterilizationLocation_id");
            AddForeignKey("dbo.DogVettings", "SterilizationLocation_id", "dbo.Locations", "id");
        }
    }
}
