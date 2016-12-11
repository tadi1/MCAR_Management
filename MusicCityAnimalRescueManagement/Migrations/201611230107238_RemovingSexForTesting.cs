namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingSexForTesting : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Animals", "Sex_id", "dbo.Sexes");
            DropIndex("dbo.Animals", new[] { "Sex_id" });
            DropColumn("dbo.Animals", "SexId");
            DropColumn("dbo.Animals", "Sex_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "Sex_id", c => c.Short());
            AddColumn("dbo.Animals", "SexId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Animals", "Sex_id");
            AddForeignKey("dbo.Animals", "Sex_id", "dbo.Sexes", "id");
        }
    }
}
