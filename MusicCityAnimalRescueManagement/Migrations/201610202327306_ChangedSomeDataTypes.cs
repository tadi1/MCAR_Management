namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSomeDataTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Animals", "Location_id", "dbo.Locations");
            DropForeignKey("dbo.InventoryItems", "location_id", "dbo.Locations");
            DropIndex("dbo.Animals", new[] { "Location_id" });
            DropIndex("dbo.InventoryItems", new[] { "location_id" });
            DropPrimaryKey("dbo.Locations");
            AddColumn("dbo.Animals", "Location", c => c.Int(nullable: false));
            AlterColumn("dbo.Locations", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.InventoryItems", "location_id", c => c.Int());
            AddPrimaryKey("dbo.Locations", "id");
            CreateIndex("dbo.InventoryItems", "location_id");
            AddForeignKey("dbo.InventoryItems", "location_id", "dbo.Locations", "id");
            DropColumn("dbo.Animals", "Location_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "Location_id", c => c.Short());
            DropForeignKey("dbo.InventoryItems", "location_id", "dbo.Locations");
            DropIndex("dbo.InventoryItems", new[] { "location_id" });
            DropPrimaryKey("dbo.Locations");
            AlterColumn("dbo.InventoryItems", "location_id", c => c.Short());
            AlterColumn("dbo.Locations", "id", c => c.Short(nullable: false, identity: true));
            DropColumn("dbo.Animals", "Location");
            AddPrimaryKey("dbo.Locations", "id");
            CreateIndex("dbo.InventoryItems", "location_id");
            CreateIndex("dbo.Animals", "Location_id");
            AddForeignKey("dbo.InventoryItems", "location_id", "dbo.Locations", "id");
            AddForeignKey("dbo.Animals", "Location_id", "dbo.Locations", "id");
        }
    }
}
