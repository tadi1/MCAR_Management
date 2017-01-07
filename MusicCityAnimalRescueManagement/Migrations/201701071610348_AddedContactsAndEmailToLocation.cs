namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedContactsAndEmailToLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "Contacts", c => c.String());
            AddColumn("dbo.Locations", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "Email");
            DropColumn("dbo.Locations", "Contacts");
        }
    }
}
