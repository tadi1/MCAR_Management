namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountingViewModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StrAccountType = c.String(),
                        ExpenseEntryObj_Id = c.Int(),
                        IncomeEntryObj_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ExpenseEntries", t => t.ExpenseEntryObj_Id)
                .ForeignKey("dbo.IncomeEntries", t => t.IncomeEntryObj_Id)
                .Index(t => t.ExpenseEntryObj_Id)
                .Index(t => t.IncomeEntryObj_Id);
            
            CreateTable(
                "dbo.ExpenseEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountTypeID = c.Byte(nullable: false),
                        SuppliesDecimal = c.Decimal(precision: 18, scale: 2),
                        SuppliesComment = c.String(),
                        VetBillsDecimal = c.Decimal(precision: 18, scale: 2),
                        VetBillsComment = c.String(),
                        MedicineDecimal = c.Decimal(precision: 18, scale: 2),
                        MedicineComment = c.String(),
                        InsurancePremiumsDecimal = c.Decimal(precision: 18, scale: 2),
                        InsurancePremiumsComment = c.String(),
                        FosterReimbursementDecimal = c.Decimal(precision: 18, scale: 2),
                        FosterReimbursementComment = c.String(),
                        MiscellaneousExpenseDecimal = c.Decimal(precision: 18, scale: 2),
                        MiscellaneousExpenseComment = c.String(),
                        EffectiveDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeID, cascadeDelete: true)
                .Index(t => t.AccountTypeID);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        AccountTypeID = c.Byte(nullable: false),
                        AccountTypeName = c.String(),
                    })
                .PrimaryKey(t => t.AccountTypeID);
            
            CreateTable(
                "dbo.IncomeEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountTypeID = c.Byte(nullable: false),
                        AdoptionsDecimal = c.Decimal(precision: 18, scale: 2),
                        NumCatAdoptions = c.Int(nullable: false),
                        NumDogAdoptions = c.Int(nullable: false),
                        AdoptionsComment = c.String(),
                        DonationsDecimal = c.Decimal(precision: 18, scale: 2),
                        DonationsComment = c.String(),
                        MiscellaneousIncomeDecimal = c.Decimal(precision: 18, scale: 2),
                        MiscellaneousIncomeComment = c.String(),
                        EffectiveDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeID, cascadeDelete: true)
                .Index(t => t.AccountTypeID);
            
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MCARId = c.String(nullable: false),
                        AnimalTypeID = c.Byte(nullable: false),
                        name = c.String(nullable: false),
                        AgeY = c.String(nullable: false),
                        AgeM = c.String(nullable: false),
                        IntakeDate = c.DateTime(nullable: false),
                        colors = c.String(nullable: false),
                        breed = c.String(nullable: false),
                        description = c.String(),
                        housetraining = c.Boolean(nullable: false),
                        CurrentFosterID = c.Int(nullable: false),
                        Adopted = c.Boolean(nullable: false),
                        ReadyForAdoption = c.Boolean(nullable: false),
                        MicrochipNumber = c.Long(nullable: false),
                        PullFee = c.Decimal(precision: 18, scale: 2),
                        AdoptionFee = c.Decimal(precision: 18, scale: 2),
                        StrAnimalType_id = c.Byte(),
                        StrLocation_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Locations", t => t.CurrentFosterID, cascadeDelete: true)
                .ForeignKey("dbo.AnimalTypes", t => t.StrAnimalType_id)
                .ForeignKey("dbo.Locations", t => t.StrLocation_id)
                .Index(t => t.CurrentFosterID)
                .Index(t => t.StrAnimalType_id)
                .Index(t => t.StrLocation_id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        isActive = c.Boolean(nullable: false),
                        isFoster = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AnimalTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        AnimalTypeName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DogVettings",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        AnimalsID = c.Int(nullable: false),
                        Sterilized = c.Boolean(nullable: false),
                        SterilizationDate = c.DateTime(nullable: false),
                        Rabies = c.Boolean(nullable: false),
                        RabiesDate = c.DateTime(nullable: false),
                        DA2PPR1 = c.Boolean(nullable: false),
                        DA2PPR1Date = c.DateTime(nullable: false),
                        DA2PPR2 = c.Boolean(nullable: false),
                        DA2PPR2Date = c.DateTime(nullable: false),
                        DA2PPR3 = c.Boolean(nullable: false),
                        DA2PPR3Date = c.DateTime(nullable: false),
                        HeartwormTested = c.Boolean(nullable: false),
                        HeartwormDate = c.DateTime(nullable: false),
                        DewormerDate = c.DateTime(nullable: false),
                        Animal_id = c.Int(),
                        DA2PPR1Location_id = c.Int(),
                        DA2PPR2Location_id = c.Int(),
                        DA2PPR3Location_id = c.Int(),
                        Dewormer_id = c.Short(nullable: false),
                        HeartwormLocation_id = c.Int(),
                        RabiesLocation_id = c.Int(),
                        SterilizationLocation_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Animals", t => t.Animal_id)
                .ForeignKey("dbo.Locations", t => t.DA2PPR1Location_id)
                .ForeignKey("dbo.Locations", t => t.DA2PPR2Location_id)
                .ForeignKey("dbo.Locations", t => t.DA2PPR3Location_id)
                .ForeignKey("dbo.Medications", t => t.Dewormer_id, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.HeartwormLocation_id)
                .ForeignKey("dbo.Locations", t => t.RabiesLocation_id)
                .ForeignKey("dbo.Locations", t => t.SterilizationLocation_id)
                .Index(t => t.Animal_id)
                .Index(t => t.DA2PPR1Location_id)
                .Index(t => t.DA2PPR2Location_id)
                .Index(t => t.DA2PPR3Location_id)
                .Index(t => t.Dewormer_id)
                .Index(t => t.HeartwormLocation_id)
                .Index(t => t.RabiesLocation_id)
                .Index(t => t.SterilizationLocation_id);
            
            CreateTable(
                "dbo.Medications",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        type = c.String(),
                        prefix = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InventoryItems",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        description = c.String(),
                        ItemNumber = c.Int(nullable: false),
                        location_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Locations", t => t.location_id)
                .Index(t => t.location_id);
            
            CreateTable(
                "dbo.NewAnimalViewModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StrAnimalType = c.String(),
                        Animal_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Animals", t => t.Animal_id)
                .Index(t => t.Animal_id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Sexes",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        id = c.Short(nullable: false, identity: true),
                        Adopted = c.Boolean(nullable: false),
                        ReadyForAdoption = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.NewAnimalViewModels", "Animal_id", "dbo.Animals");
            DropForeignKey("dbo.InventoryItems", "location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "SterilizationLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "RabiesLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "HeartwormLocation_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "Dewormer_id", "dbo.Medications");
            DropForeignKey("dbo.DogVettings", "DA2PPR3Location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR2Location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "DA2PPR1Location_id", "dbo.Locations");
            DropForeignKey("dbo.DogVettings", "Animal_id", "dbo.Animals");
            DropForeignKey("dbo.Animals", "StrLocation_id", "dbo.Locations");
            DropForeignKey("dbo.Animals", "StrAnimalType_id", "dbo.AnimalTypes");
            DropForeignKey("dbo.Animals", "CurrentFosterID", "dbo.Locations");
            DropForeignKey("dbo.AccountingViewModels", "IncomeEntryObj_Id", "dbo.IncomeEntries");
            DropForeignKey("dbo.IncomeEntries", "AccountTypeID", "dbo.AccountTypes");
            DropForeignKey("dbo.AccountingViewModels", "ExpenseEntryObj_Id", "dbo.ExpenseEntries");
            DropForeignKey("dbo.ExpenseEntries", "AccountTypeID", "dbo.AccountTypes");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.NewAnimalViewModels", new[] { "Animal_id" });
            DropIndex("dbo.InventoryItems", new[] { "location_id" });
            DropIndex("dbo.DogVettings", new[] { "SterilizationLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "RabiesLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "HeartwormLocation_id" });
            DropIndex("dbo.DogVettings", new[] { "Dewormer_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR3Location_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR2Location_id" });
            DropIndex("dbo.DogVettings", new[] { "DA2PPR1Location_id" });
            DropIndex("dbo.DogVettings", new[] { "Animal_id" });
            DropIndex("dbo.Animals", new[] { "StrLocation_id" });
            DropIndex("dbo.Animals", new[] { "StrAnimalType_id" });
            DropIndex("dbo.Animals", new[] { "CurrentFosterID" });
            DropIndex("dbo.IncomeEntries", new[] { "AccountTypeID" });
            DropIndex("dbo.ExpenseEntries", new[] { "AccountTypeID" });
            DropIndex("dbo.AccountingViewModels", new[] { "IncomeEntryObj_Id" });
            DropIndex("dbo.AccountingViewModels", new[] { "ExpenseEntryObj_Id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Status");
            DropTable("dbo.Sexes");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.NewAnimalViewModels");
            DropTable("dbo.InventoryItems");
            DropTable("dbo.EquipmentTypes");
            DropTable("dbo.Medications");
            DropTable("dbo.DogVettings");
            DropTable("dbo.AnimalTypes");
            DropTable("dbo.Locations");
            DropTable("dbo.Animals");
            DropTable("dbo.IncomeEntries");
            DropTable("dbo.AccountTypes");
            DropTable("dbo.ExpenseEntries");
            DropTable("dbo.AccountingViewModels");
        }
    }
}
