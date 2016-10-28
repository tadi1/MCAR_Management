namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingLocations : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Locations] ON
                    INSERT INTO [dbo].[Locations] ([id], [name]) VALUES (1, N'Storage')
                    INSERT INTO [dbo].[Locations] ([id], [name]) VALUES (2, N'Rebecca')
                    INSERT INTO [dbo].[Locations] ([id], [name]) VALUES (3, N'Takari')
                    INSERT INTO [dbo].[Locations] ([id], [name]) VALUES (4, N'Vickie')
                    INSERT INTO [dbo].[Locations] ([id], [name]) VALUES (5, N'Kathy')
                    INSERT INTO [dbo].[Locations] ([id], [name]) VALUES (6, N'Linda')
                    SET IDENTITY_INSERT [dbo].[Locations] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}
