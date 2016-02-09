namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2016_02_09_12_08 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Solutions", "TransactionPmCriteria_TransactionPmCriteriaId", "dbo.TransactionPmCriterias");
            DropIndex("dbo.Solutions", new[] { "TransactionPmCriteria_TransactionPmCriteriaId" });
            CreateTable(
                "dbo.TransactionCriterias",
                c => new
                    {
                        TransactionCriteriaId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.TransactionCriteriaId);
            
            AddColumn("dbo.Solutions", "TransactionCriteria_TransactionCriteriaId", c => c.Int());
            CreateIndex("dbo.Solutions", "TransactionCriteria_TransactionCriteriaId");
            AddForeignKey("dbo.Solutions", "TransactionCriteria_TransactionCriteriaId", "dbo.TransactionCriterias", "TransactionCriteriaId");
            DropColumn("dbo.Solutions", "TransactionPmCriteria_TransactionPmCriteriaId");
            DropTable("dbo.TransactionPmCriterias");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TransactionPmCriterias",
                c => new
                    {
                        TransactionPmCriteriaId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.TransactionPmCriteriaId);
            
            AddColumn("dbo.Solutions", "TransactionPmCriteria_TransactionPmCriteriaId", c => c.Int());
            DropForeignKey("dbo.Solutions", "TransactionCriteria_TransactionCriteriaId", "dbo.TransactionCriterias");
            DropIndex("dbo.Solutions", new[] { "TransactionCriteria_TransactionCriteriaId" });
            DropColumn("dbo.Solutions", "TransactionCriteria_TransactionCriteriaId");
            DropTable("dbo.TransactionCriterias");
            CreateIndex("dbo.Solutions", "TransactionPmCriteria_TransactionPmCriteriaId");
            AddForeignKey("dbo.Solutions", "TransactionPmCriteria_TransactionPmCriteriaId", "dbo.TransactionPmCriterias", "TransactionPmCriteriaId");
        }
    }
}
