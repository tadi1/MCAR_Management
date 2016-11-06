namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingOtherLocation : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Locations] ON
INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster], [isPullLocation], [Address], [Notes], [Cats], [Dogs]) VALUES (17, N'Other', 1, 0, 1, NULL, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[Locations] OFF");

        }

        public override void Down()
        {
        }
    }
}
