namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTempermentAndComments3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Temperament", c => c.String(nullable: false));
            DropColumn("dbo.Animals", "AdtlCommentsTemperament");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "AdtlCommentsTemperament", c => c.String(nullable: false));
            DropColumn("dbo.Animals", "Temperament");
        }
    }
}
