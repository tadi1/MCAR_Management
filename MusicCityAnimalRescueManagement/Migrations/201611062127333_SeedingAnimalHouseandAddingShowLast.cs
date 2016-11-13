namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingAnimalHouseandAddingShowLast : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Locations", "isShowLast", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Locations", "isShowLast");
        }
    }
}
