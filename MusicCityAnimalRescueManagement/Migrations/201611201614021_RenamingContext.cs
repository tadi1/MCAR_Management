namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamingContext : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[EquipmentItems] ON
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (1, N'24x18 Green/Camo Wire Crate', 1001, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (2, N'24x18 Black Wire Crate', 1002, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (3, N'24x18 Black Wire Crate', 1003, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (4, N'48x30 Black Wire Crate', 1004, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (5, N'42x27 Black Wire Crate', 1005, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (6, N'42x27 Black Wire Crate', 1006, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (7, N'20x12 Black Wire Crate', 1007, 29)


                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (8, N'Cat cage, Tall black with wheels', 2001, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (9, N'Cat cage, Tall black with wheels', 2002, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (10, N'Large Beige Carrier', 3001, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (11, N'Large Beige Carrier', 3002, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (12, N'Large Blue Carrier', 3003, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (13, N'Small Wildlife Trap', 9001, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (14, N'Large Wildlife Trap', 9002, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (15, N'Small Blue Carrier', 3004, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (16, N'Small Beige Carrier', 3005, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (17, N'White Table w/ Latch', 5001, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (18, N'White Table w/ Handle and Telescoping Legs', 5002, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (22, N'5 Foot Banner w/ Grommets ', 0, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (25, N'4 Foot Banner w/ Grommets', 1, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (26, N'Supplies/Donations Banner', 2, 29)
                INSERT INTO [dbo].[EquipmentItems] ([id], [description], [ItemNumber], [locationid]) VALUES (27, N'Posters for Wooden Stand', 3, 29)
                SET IDENTITY_INSERT [dbo].[EquipmentItems] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}
