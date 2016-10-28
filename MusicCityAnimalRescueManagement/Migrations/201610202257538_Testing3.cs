namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Animals", "AnimalTypeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "AnimalTypeID", c => c.Short(nullable: false));
        }
    }
}
