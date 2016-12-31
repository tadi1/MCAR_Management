namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSavings : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AccountTypes] ([AccountTypeID], [AccountTypeName]) VALUES (3, N'Savings')");
        }
        
        public override void Down()
        {
        }
    }
}
