namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "AnimalType_id", c => c.Short());
            CreateIndex("dbo.Animals", "AnimalType_id");
            AddForeignKey("dbo.Animals", "AnimalType_id", "dbo.AnimalTypes", "id");
            DropColumn("dbo.Animals", "AnimalTypeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "AnimalTypeID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Animals", "AnimalType_id", "dbo.AnimalTypes");
            DropIndex("dbo.Animals", new[] { "AnimalType_id" });
            DropColumn("dbo.Animals", "AnimalType_id");
        }
    }
}
