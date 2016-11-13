namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingShelters : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Locations] ON");
            AddColumn("dbo.Locations", "isShowLast", c => c.Boolean(nullable: false));

            Sql(@"INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster], [isPullLocation]) VALUES (6, N'Williamson Co. Shelter', 1, 0, 1)
                INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster], [isPullLocation]) VALUES (7, N'Benton Co. Shelter', 1, 0, 1)
                INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster], [isPullLocation]) VALUES (8, N'Nashville Metro Shelter', 1, 0, 1)
                INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster], [isPullLocation]) VALUES (9, N'Putnam Co. Shelter', 1, 0, 1)
                INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster], [isPullLocation]) VALUES (10, N'Owner Surrender', 1, 0, 1)

                ");
            Sql(@"SET IDENTITY_INSERT [dbo].[Locations] OFF");

        }

        public override void Down()
        {

        }
    }
}
