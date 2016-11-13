namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestingNullableDate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DogVettings", "BordetellaDate", c => c.DateTime());
            AlterColumn("dbo.DogVettings", "RabiesDate", c => c.DateTime());
            AlterColumn("dbo.DogVettings", "DA2PPR1Date", c => c.DateTime());
            AlterColumn("dbo.DogVettings", "DA2PPR2Date", c => c.DateTime());
            AlterColumn("dbo.DogVettings", "DA2PPR3Date", c => c.DateTime());
            AlterColumn("dbo.DogVettings", "HeartwormDate", c => c.DateTime());
            AlterColumn("dbo.DogVettings", "DewormerDate", c => c.DateTime());
            AlterColumn("dbo.DogVettings", "FleaTickDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DogVettings", "FleaTickDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DogVettings", "DewormerDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DogVettings", "HeartwormDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR3Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR2Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DogVettings", "DA2PPR1Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DogVettings", "RabiesDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.DogVettings", "BordetellaDate", c => c.DateTime(nullable: false));
        }
    }
}
