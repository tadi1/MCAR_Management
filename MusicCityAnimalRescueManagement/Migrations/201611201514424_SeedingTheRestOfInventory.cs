namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingTheRestOfInventory : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[InventoryItems] ON
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (8, N'Cat cage, Tall black with wheels', 2001, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (9, N'Cat cage, Tall black with wheels', 2002, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (10, N'Large Beige Carrier', 3001, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (11, N'Large Beige Carrier', 3002, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (12, N'Large Blue Carrier', 3003, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (13, N'Small Wildlife Trap', 9001, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (14, N'Large Wildlife Trap', 9002, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (15, N'Small Blue Carrier', 3004, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (16, N'Small Beige Carrier', 3005, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (17, N'White Table w/ Latch', 5001, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (18, N'White Table w/ Handle and Telescoping Legs', 5002, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (22, N'5 Foot Banner w/ Grommets ', 0, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (25, N'4 Foot Banner w/ Grommets', 1, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (26, N'Supplies/Donations Banner', 2, 29)
INSERT INTO [dbo].[InventoryItems] ([id], [description], [ItemNumber], [location_id]) VALUES (27, N'Posters for Wooden Stand', 3, 29)
SET IDENTITY_INSERT [dbo].[InventoryItems] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
