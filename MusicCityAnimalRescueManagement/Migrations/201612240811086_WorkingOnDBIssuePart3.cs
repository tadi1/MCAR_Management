namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkingOnDBIssuePart3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Animals", "Sex_id", "dbo.Sexes");
            DropIndex("dbo.Animals", new[] { "Sex_id" });
            DropColumn("dbo.Animals", "SexId");
            AddColumn("dbo.Animals", "SexId", c => c.Short(nullable: true));

            //RenameColumn(table: "dbo.Animals", name: "Sex_id", newName: "SexId");
            //AlterColumn("dbo.Animals", "SexId", c => c.Short(nullable: false));
            //AlterColumn("dbo.Animals", "SexId", c => c.Short(nullable: false));
            AddForeignKey("dbo.Animals", "SexId", "dbo.Sexes", "id", cascadeDelete: true);

            CreateIndex("dbo.Animals", "SexId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "SexId", "dbo.Sexes");
            DropIndex("dbo.Animals", new[] { "SexId" });
            AlterColumn("dbo.Animals", "SexId", c => c.Short());
            AlterColumn("dbo.Animals", "SexId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Animals", name: "SexId", newName: "Sex_id");
            AddColumn("dbo.Animals", "SexId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Animals", "Sex_id");
            AddForeignKey("dbo.Animals", "Sex_id", "dbo.Sexes", "id");
        }
    }
}
