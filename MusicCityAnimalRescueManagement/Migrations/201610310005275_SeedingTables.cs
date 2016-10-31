namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingTables : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AnimalTypes] ([id], [AnimalTypeName]) VALUES (0, N'Cat')
                    INSERT INTO [dbo].[AnimalTypes] ([id], [AnimalTypeName]) VALUES (1, N'Dog')
                    INSERT INTO [dbo].[AnimalTypes] ([id], [AnimalTypeName]) VALUES (3, N'Other')");

            Sql(@"SET IDENTITY_INSERT [dbo].[EquipmentTypes] ON
                    INSERT INTO [dbo].[EquipmentTypes] ([id], [type], [prefix]) VALUES (1, N'Dog Crate', 1)
                    INSERT INTO [dbo].[EquipmentTypes] ([id], [type], [prefix]) VALUES (2, N'Cat Crate', 2)
                    INSERT INTO [dbo].[EquipmentTypes] ([id], [type], [prefix]) VALUES (3, N'Carrier', 3)
                    INSERT INTO [dbo].[EquipmentTypes] ([id], [type], [prefix]) VALUES (4, N'Wildlife Cage', 9)
                    INSERT INTO [dbo].[EquipmentTypes] ([id], [type], [prefix]) VALUES (5, N'Table', 5)
                    INSERT INTO [dbo].[EquipmentTypes] ([id], [type], [prefix]) VALUES (6, N'Other', 0)
                    SET IDENTITY_INSERT [dbo].[EquipmentTypes] OFF");

            Sql(@"SET IDENTITY_INSERT [dbo].[Locations] ON
                    INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster]) VALUES (1, N'Takari Donaville', 1, 1)
                    INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster]) VALUES (2, N'Kathy Wells', 1, 1)
                    INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster]) VALUES (3, N'Rebecca Wilson', 0, 1)
                    INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster]) VALUES (4, N'Vickie Harris', 0, 0)
                    INSERT INTO [dbo].[Locations] ([id], [name], [isActive], [isFoster]) VALUES (5, N'Linda Harris?', 1, 1)
                    SET IDENTITY_INSERT [dbo].[Locations] OFF");

            Sql(@"SET IDENTITY_INSERT [dbo].[Sexes] ON
                    INSERT INTO [dbo].[Sexes] ([id], [Name]) VALUES (1, N'Male')
                    INSERT INTO [dbo].[Sexes] ([id], [Name]) VALUES (2, N'Female')
                    SET IDENTITY_INSERT [dbo].[Sexes] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
