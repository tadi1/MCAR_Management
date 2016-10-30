namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingAnimalTypes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Animals", name: "AnimalType_id", newName: "StrAnimalType_id");
            RenameIndex(table: "dbo.Animals", name: "IX_AnimalType_id", newName: "IX_StrAnimalType_id");
            AddColumn("dbo.Animals", "AnimalTypeID", c => c.Byte(nullable: false));
            AddColumn("dbo.AnimalTypes", "AnimalTypeName", c => c.String());
            DropColumn("dbo.AnimalTypes", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AnimalTypes", "Type", c => c.String());
            DropColumn("dbo.AnimalTypes", "AnimalTypeName");
            DropColumn("dbo.Animals", "AnimalTypeID");
            RenameIndex(table: "dbo.Animals", name: "IX_StrAnimalType_id", newName: "IX_AnimalType_id");
            RenameColumn(table: "dbo.Animals", name: "StrAnimalType_id", newName: "AnimalType_id");
        }
    }
}
