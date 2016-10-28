namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Animals", "AnimalType_id", "dbo.AnimalTypes");
            DropIndex("dbo.Animals", new[] { "AnimalType_id" });
            AddColumn("dbo.Animals", "AnimalTypeID", c => c.Int(nullable: false));
            DropColumn("dbo.Animals", "AnimalType_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "AnimalType_id", c => c.Short());
            DropColumn("dbo.Animals", "AnimalTypeID");
            CreateIndex("dbo.Animals", "AnimalType_id");
            AddForeignKey("dbo.Animals", "AnimalType_id", "dbo.AnimalTypes", "id");
        }
    }
}
