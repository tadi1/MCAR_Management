namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReaddingSexForTesting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "SexId", c => c.Byte(nullable: false));
            AddColumn("dbo.Animals", "Sex_id", c => c.Short());
            CreateIndex("dbo.Animals", "Sex_id");
            AddForeignKey("dbo.Animals", "Sex_id", "dbo.Sexes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "Sex_id", "dbo.Sexes");
            DropIndex("dbo.Animals", new[] { "Sex_id" });
            DropColumn("dbo.Animals", "Sex_id");
            DropColumn("dbo.Animals", "SexId");
        }
    }
}
