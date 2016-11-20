namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedLocationDTtoIntInEquipTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InventoryItems", "location_id", "dbo.Locations");
            DropIndex("dbo.InventoryItems", new[] { "location_id" });
            CreateTable(
                "dbo.EquipmentItems",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        description = c.String(),
                        LocationId = c.Int(nullable: false),
                        ItemNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.InventoryItems");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.InventoryItems",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        description = c.String(),
                        ItemNumber = c.Int(nullable: false),
                        location_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.EquipmentItems");
            CreateIndex("dbo.InventoryItems", "location_id");
            AddForeignKey("dbo.InventoryItems", "location_id", "dbo.Locations", "id");
        }
    }
}
