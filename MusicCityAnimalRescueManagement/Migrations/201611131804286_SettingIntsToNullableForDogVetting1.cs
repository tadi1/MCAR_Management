namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingIntsToNullableForDogVetting1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogVettings", "SterilizationLocationid", c => c.Int());
            CreateIndex("dbo.DogVettings", "SterilizationLocationid");
            AddForeignKey("dbo.DogVettings", "SterilizationLocationid", "dbo.Locations", "id");
            DropColumn("dbo.DogVettings", "SterilizationLocation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DogVettings", "SterilizationLocation", c => c.Int());
            DropForeignKey("dbo.DogVettings", "SterilizationLocationid", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "SterilizationLocationid" });
            DropColumn("dbo.DogVettings", "SterilizationLocationid");
        }
    }
}
