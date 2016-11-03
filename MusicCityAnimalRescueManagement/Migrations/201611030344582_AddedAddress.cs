namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "Address");
        }
    }
}
