namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTempermentAndComments2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "AdtlCommentsTemperament", c => c.String(nullable: false));
            DropColumn("dbo.Animals", "Temperament");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "Temperament", c => c.String(nullable: false));
            DropColumn("dbo.Animals", "AdtlCommentsTemperament");
        }
    }
}
