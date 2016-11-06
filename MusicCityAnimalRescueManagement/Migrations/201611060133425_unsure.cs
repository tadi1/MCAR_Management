namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unsure : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DogVettings", "Bordetella", c => c.Boolean(nullable: false));
            AddColumn("dbo.DogVettings", "BordetellaDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.DogVettings", "BordetellaLocation_id", c => c.Int());
            CreateIndex("dbo.DogVettings", "BordetellaLocation_id");
            AddForeignKey("dbo.DogVettings", "BordetellaLocation_id", "dbo.Locations", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DogVettings", "BordetellaLocation_id", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "BordetellaLocation_id" });
            DropColumn("dbo.DogVettings", "BordetellaLocation_id");
            DropColumn("dbo.DogVettings", "BordetellaDate");
            DropColumn("dbo.DogVettings", "Bordetella");
        }
    }
}
