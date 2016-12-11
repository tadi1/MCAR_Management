namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyingSex : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "SexId", c => c.String(nullable: false));
            AddColumn("dbo.Animals", "Sex_id", c => c.Short());
            CreateIndex("dbo.Animals", "Sex_id");
            AddForeignKey("dbo.Animals", "Sex_id", "dbo.Sexes", "id");
            DropColumn("dbo.Animals", "Sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "Sex", c => c.String(nullable: false));
            DropForeignKey("dbo.Animals", "Sex_id", "dbo.Sexes");
            DropIndex("dbo.Animals", new[] { "Sex_id" });
            DropColumn("dbo.Animals", "Sex_id");
            DropColumn("dbo.Animals", "SexId");
        }
    }
}
