namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingtofixafuckup : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.EquipmentItems", "LocationId");
            AddForeignKey("dbo.EquipmentItems", "LocationId", "dbo.Locations", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EquipmentItems", "LocationId", "dbo.Locations");
            DropIndex("dbo.EquipmentItems", new[] { "LocationId" });
        }
    }
}
