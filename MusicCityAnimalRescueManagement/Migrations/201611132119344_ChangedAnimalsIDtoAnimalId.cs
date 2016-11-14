namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAnimalsIDtoAnimalId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DogVettings", "Animal_id", "dbo.Animals");
            DropIndex("dbo.DogVettings", new[] { "Animal_id" });
            RenameColumn(table: "dbo.DogVettings", name: "Animal_id", newName: "AnimalId");
            AlterColumn("dbo.DogVettings", "AnimalId", c => c.Int(nullable: false));
            CreateIndex("dbo.DogVettings", "AnimalId");
            AddForeignKey("dbo.DogVettings", "AnimalId", "dbo.Animals", "id", cascadeDelete: true);
            DropColumn("dbo.DogVettings", "AnimalsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DogVettings", "AnimalsID", c => c.Int(nullable: false));
            DropForeignKey("dbo.DogVettings", "AnimalId", "dbo.Animals");
            DropIndex("dbo.DogVettings", new[] { "AnimalId" });
            AlterColumn("dbo.DogVettings", "AnimalId", c => c.Int());
            RenameColumn(table: "dbo.DogVettings", name: "AnimalId", newName: "Animal_id");
            CreateIndex("dbo.DogVettings", "Animal_id");
            AddForeignKey("dbo.DogVettings", "Animal_id", "dbo.Animals", "id");
        }
    }
}
