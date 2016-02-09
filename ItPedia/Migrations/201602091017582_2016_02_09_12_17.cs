namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2016_02_09_12_17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransactionCriterias", "PerMonth", c => c.String());
            DropColumn("dbo.TransactionCriterias", "Size");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TransactionCriterias", "Size", c => c.String());
            DropColumn("dbo.TransactionCriterias", "PerMonth");
        }
    }
}
