namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedExtraRequiredAnnotations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DogVettings", "Dewormer_id", "dbo.Medications");
            DropForeignKey("dbo.DogVettings", "FleaTick_id", "dbo.Medications");
            DropIndex("dbo.DogVettings", new[] { "Dewormer_id" });
            DropIndex("dbo.DogVettings", new[] { "FleaTick_id" });
            AlterColumn("dbo.DogVettings", "Dewormer_id", c => c.Short());
            AlterColumn("dbo.DogVettings", "FleaTick_id", c => c.Short());
            CreateIndex("dbo.DogVettings", "Dewormer_id");
            CreateIndex("dbo.DogVettings", "FleaTick_id");
            AddForeignKey("dbo.DogVettings", "Dewormer_id", "dbo.Medications", "id");
            AddForeignKey("dbo.DogVettings", "FleaTick_id", "dbo.Medications", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DogVettings", "FleaTick_id", "dbo.Medications");
            DropForeignKey("dbo.DogVettings", "Dewormer_id", "dbo.Medications");
            DropIndex("dbo.DogVettings", new[] { "FleaTick_id" });
            DropIndex("dbo.DogVettings", new[] { "Dewormer_id" });
            AlterColumn("dbo.DogVettings", "FleaTick_id", c => c.Short(nullable: false));
            AlterColumn("dbo.DogVettings", "Dewormer_id", c => c.Short(nullable: false));
            CreateIndex("dbo.DogVettings", "FleaTick_id");
            CreateIndex("dbo.DogVettings", "Dewormer_id");
            AddForeignKey("dbo.DogVettings", "FleaTick_id", "dbo.Medications", "id", cascadeDelete: true);
            AddForeignKey("dbo.DogVettings", "Dewormer_id", "dbo.Medications", "id", cascadeDelete: true);
        }
    }
}
