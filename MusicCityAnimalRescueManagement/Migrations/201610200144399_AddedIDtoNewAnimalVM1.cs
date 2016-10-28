namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIDtoNewAnimalVM1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "AnimalTypes_id", c => c.Short());
            CreateIndex("dbo.Animals", "AnimalTypes_id");
            AddForeignKey("dbo.Animals", "AnimalTypes_id", "dbo.AnimalTypes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "AnimalTypes_id", "dbo.AnimalTypes");
            DropIndex("dbo.Animals", new[] { "AnimalTypes_id" });
            DropColumn("dbo.Animals", "AnimalTypes_id");
        }
    }
}
