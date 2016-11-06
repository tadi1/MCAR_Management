namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTempermentAndComments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Tempement", c => c.String(nullable: false));
            AddColumn("dbo.Animals", "AdtlComments", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "AdtlComments");
            DropColumn("dbo.Animals", "Tempement");
        }
    }
}
