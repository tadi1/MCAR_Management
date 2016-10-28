namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingaccounttypes : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AccountTypes] ([AccountTypeID], [AccountTypeName]) VALUES (1, N'General')
                    INSERT INTO [dbo].[AccountTypes] ([AccountTypeID], [AccountTypeName]) VALUES (2, N'Paypal')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
