namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedRequiredFromFosterLocationToFixEquipError : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "name", c => c.String(nullable: false));
        }
    }
}
