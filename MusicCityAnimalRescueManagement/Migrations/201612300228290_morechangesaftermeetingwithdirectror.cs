namespace MusicCityAnimalRescueManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class morechangesaftermeetingwithdirectror : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExpenseEntries", "PullFeeDecimal", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ExpenseEntries", "PullFeeComment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExpenseEntries", "PullFeeComment");
            DropColumn("dbo.ExpenseEntries", "PullFeeDecimal");
        }
    }
}
