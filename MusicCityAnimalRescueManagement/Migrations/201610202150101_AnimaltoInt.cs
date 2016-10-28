namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnimaltoInt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Animals", "AnimalTypes_id", "dbo.AnimalTypes");
            DropIndex("dbo.Animals", new[] { "AnimalTypes_id" });
            AddColumn("dbo.Animals", "AnimalTypeID", c => c.Int(nullable: false));
            DropColumn("dbo.Animals", "AnimalTypes_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "AnimalTypes_id", c => c.Short());
            DropColumn("dbo.Animals", "AnimalTypeID");
            CreateIndex("dbo.Animals", "AnimalTypes_id");
            AddForeignKey("dbo.Animals", "AnimalTypes_id", "dbo.AnimalTypes", "id");
        }
    }
}
