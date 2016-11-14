namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLocationPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "previousName", c => c.String());
            AddColumn("dbo.Locations", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Animals", "AdtlComments", c => c.String());
            AlterColumn("dbo.Locations", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "name", c => c.String());
            AlterColumn("dbo.Animals", "AdtlComments", c => c.String(nullable: false));
            DropColumn("dbo.Locations", "PhoneNumber");
            DropColumn("dbo.Animals", "previousName");
        }
    }
}
