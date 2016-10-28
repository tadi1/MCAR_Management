namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chageddts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "AnimalType_id", c => c.Short(nullable: false));
            AddColumn("dbo.Animals", "Location_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Animals", "AnimalType_id");
            CreateIndex("dbo.Animals", "Location_id");
            AddForeignKey("dbo.Animals", "AnimalType_id", "dbo.AnimalTypes", "id", cascadeDelete: true);
            AddForeignKey("dbo.Animals", "Location_id", "dbo.Locations", "id", cascadeDelete: true);
            DropColumn("dbo.Animals", "AnimalTypeID");
            DropColumn("dbo.Animals", "LocationID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "LocationID", c => c.Int(nullable: false));
            AddColumn("dbo.Animals", "AnimalTypeID", c => c.Short(nullable: false));
            DropForeignKey("dbo.Animals", "Location_id", "dbo.Locations");
            DropForeignKey("dbo.Animals", "AnimalType_id", "dbo.AnimalTypes");
            DropIndex("dbo.Animals", new[] { "Location_id" });
            DropIndex("dbo.Animals", new[] { "AnimalType_id" });
            DropColumn("dbo.Animals", "Location_id");
            DropColumn("dbo.Animals", "AnimalType_id");
        }
    }
}
