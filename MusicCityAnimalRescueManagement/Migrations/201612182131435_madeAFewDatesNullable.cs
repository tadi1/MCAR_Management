namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeAFewDatesNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CatVettings", "NextVet", c => c.DateTime());
            AlterColumn("dbo.CatVettings", "VettingCompleted", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CatVettings", "VettingCompleted", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CatVettings", "NextVet", c => c.DateTime(nullable: false));
        }
    }
}
