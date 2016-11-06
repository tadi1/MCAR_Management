namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDogVetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogVettings", "DewormerLocation_id", c => c.Int());
            CreateIndex("dbo.DogVettings", "DewormerLocation_id");
            AddForeignKey("dbo.DogVettings", "DewormerLocation_id", "dbo.Locations", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DogVettings", "DewormerLocation_id", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "DewormerLocation_id" });
            DropColumn("dbo.DogVettings", "DewormerLocation_id");
        }
    }
}
