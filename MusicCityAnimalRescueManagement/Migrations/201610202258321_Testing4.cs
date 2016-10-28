namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "AnimalTypeID", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "AnimalTypeID");
        }
    }
}
