namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCatVettingOtherModelChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "AdoptionDate", c => c.DateTime());
            AddColumn("dbo.Animals", "AdoptionLocationId", c => c.Int());
            AddColumn("dbo.Animals", "InRescueTime", c => c.String());
            AddColumn("dbo.Locations", "isAdoptionVenue", c => c.Boolean(nullable: false));
            AddColumn("dbo.DogVettings", "RabiesNumber", c => c.Int());
            AddColumn("dbo.DogVettings", "MicrochipNumber", c => c.Long());
            AddColumn("dbo.DogVettings", "MicrochipManufacturerId", c => c.Int());
            AddColumn("dbo.DogVettings", "MicrochipLocationId", c => c.Int());
            AddColumn("dbo.DogVettings", "MicrochipManufacturer_id", c => c.Short());
            AddColumn("dbo.Medications", "isMicrochipManufacturer", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Animals", "AdoptionLocationId");
            CreateIndex("dbo.DogVettings", "MicrochipLocationId");
            CreateIndex("dbo.DogVettings", "MicrochipManufacturer_id");
            AddForeignKey("dbo.Animals", "AdoptionLocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "MicrochipLocationId", "dbo.Locations", "id");
            AddForeignKey("dbo.DogVettings", "MicrochipManufacturer_id", "dbo.Medications", "id");
            DropColumn("dbo.Animals", "MicrochipNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "MicrochipNumber", c => c.Long(nullable: false));
            DropForeignKey("dbo.DogVettings", "MicrochipManufacturer_id", "dbo.Medications");
            DropForeignKey("dbo.DogVettings", "MicrochipLocationId", "dbo.Locations");
            DropForeignKey("dbo.Animals", "AdoptionLocationId", "dbo.Locations");
            DropIndex("dbo.DogVettings", new[] { "MicrochipManufacturer_id" });
            DropIndex("dbo.DogVettings", new[] { "MicrochipLocationId" });
            DropIndex("dbo.Animals", new[] { "AdoptionLocationId" });
            DropColumn("dbo.Medications", "isMicrochipManufacturer");
            DropColumn("dbo.DogVettings", "MicrochipManufacturer_id");
            DropColumn("dbo.DogVettings", "MicrochipLocationId");
            DropColumn("dbo.DogVettings", "MicrochipManufacturerId");
            DropColumn("dbo.DogVettings", "MicrochipNumber");
            DropColumn("dbo.DogVettings", "RabiesNumber");
            DropColumn("dbo.Locations", "isAdoptionVenue");
            DropColumn("dbo.Animals", "InRescueTime");
            DropColumn("dbo.Animals", "AdoptionLocationId");
            DropColumn("dbo.Animals", "AdoptionDate");
        }
    }
}
