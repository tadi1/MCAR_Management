namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Animals", "StrAnimalType_id", "dbo.AnimalTypes");
            DropIndex("dbo.Animals", new[] { "StrAnimalType_id" });
            DropColumn("dbo.Animals", "AnimalTypeID");
            RenameColumn(table: "dbo.Animals", name: "StrAnimalType_id", newName: "AnimalTypeID");
            AlterColumn("dbo.Animals", "AnimalTypeID", c => c.Byte(nullable: true));
            CreateIndex("dbo.Animals", "AnimalTypeID");
            AddForeignKey("dbo.Animals", "AnimalTypeID", "dbo.AnimalTypes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "AnimalTypeID", "dbo.AnimalTypes");
            DropIndex("dbo.Animals", new[] { "AnimalTypeID" });
            AlterColumn("dbo.Animals", "AnimalTypeID", c => c.Byte());
            RenameColumn(table: "dbo.Animals", name: "AnimalTypeID", newName: "StrAnimalType_id");
            AddColumn("dbo.Animals", "AnimalTypeID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Animals", "StrAnimalType_id");
            AddForeignKey("dbo.Animals", "StrAnimalType_id", "dbo.AnimalTypes", "id");
        }
    }
}
