namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTempermentAndComments1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Temperament", c => c.String(nullable: false));
            DropColumn("dbo.Animals", "Tempement");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "Tempement", c => c.String(nullable: false));
            DropColumn("dbo.Animals", "Temperament");
        }
    }
}
