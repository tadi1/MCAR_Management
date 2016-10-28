namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing2 : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.Animals", "AnimalTypeID", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.Animals", "AnimalTypeID", c => c.Int(nullable: false));
        }
    }
}
