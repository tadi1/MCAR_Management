namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingMeds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogVettings", "FleaTickDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.DogVettings", "FleaTick_id", c => c.Short(nullable: false));
            AddColumn("dbo.DogVettings", "FleaTickLocation_id", c => c.Int());
            AddColumn("dbo.Medications", "isFleaTick", c => c.Boolean(nullable: false));
            AddColumn("dbo.Medications", "isHeartworm", c => c.Boolean(nullable: false));
            AddColumn("dbo.Medications", "isForCats", c => c.Boolean(nullable: false));
            AddColumn("dbo.Medications", "isForDogs", c => c.Boolean(nullable: false));
            CreateIndex("dbo.DogVettings", "FleaTick_id");
            CreateIndex("dbo.DogVettings", "FleaTickLocation_id");
            AddForeignKey("dbo.DogVettings", "FleaTick_id", "dbo.Medications", "id", cascadeDelete: false);
            AddForeignKey("dbo.DogVettings", "FleaTickLocation_id", "dbo.Locations", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DogVettings", "FleaTickLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "FleaTick_id", "dbo.Medications");
            DropIndex("dbo.DogVettings", new[] { "FleaTickLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "FleaTick_id" });
            DropColumn("dbo.Medications", "isForDogs");
            DropColumn("dbo.Medications", "isForCats");
            DropColumn("dbo.Medications", "isHeartworm");
            DropColumn("dbo.Medications", "isFleaTick");
            DropColumn("dbo.DogVettings", "FleaTickLocation_id");
            DropColumn("dbo.DogVettings", "FleaTick_id");
            DropColumn("dbo.DogVettings", "FleaTickDate");
        }
    }
}
