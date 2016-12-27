namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Unsure1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "InRescueTime", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "InRescueTime", c => c.String());
        }
    }
}
