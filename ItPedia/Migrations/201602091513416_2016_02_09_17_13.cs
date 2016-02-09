namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2016_02_09_17_13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeCriterias", "IndustryCriteriaId", "dbo.IndustryCriterias");
            DropIndex("dbo.EmployeeCriterias", new[] { "IndustryCriteriaId" });
            RenameColumn(table: "dbo.EmployeeCriterias", name: "IndustryCriteriaId", newName: "IndustryCriteria_IndustryCriteriaId");
            AddColumn("dbo.CustomerCriterias", "EmployeeCriteria_EmployeeCriteriaId", c => c.Int());
            AddColumn("dbo.TransactionCriterias", "CustomerCriteria_CustomerCriteriaId", c => c.Int());
            AlterColumn("dbo.EmployeeCriterias", "IndustryCriteria_IndustryCriteriaId", c => c.Int());
            CreateIndex("dbo.CustomerCriterias", "EmployeeCriteria_EmployeeCriteriaId");
            CreateIndex("dbo.TransactionCriterias", "CustomerCriteria_CustomerCriteriaId");
            CreateIndex("dbo.EmployeeCriterias", "IndustryCriteria_IndustryCriteriaId");
            AddForeignKey("dbo.TransactionCriterias", "CustomerCriteria_CustomerCriteriaId", "dbo.CustomerCriterias", "CustomerCriteriaId");
            AddForeignKey("dbo.CustomerCriterias", "EmployeeCriteria_EmployeeCriteriaId", "dbo.EmployeeCriterias", "EmployeeCriteriaId");
            AddForeignKey("dbo.EmployeeCriterias", "IndustryCriteria_IndustryCriteriaId", "dbo.IndustryCriterias", "IndustryCriteriaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeCriterias", "IndustryCriteria_IndustryCriteriaId", "dbo.IndustryCriterias");
            DropForeignKey("dbo.CustomerCriterias", "EmployeeCriteria_EmployeeCriteriaId", "dbo.EmployeeCriterias");
            DropForeignKey("dbo.TransactionCriterias", "CustomerCriteria_CustomerCriteriaId", "dbo.CustomerCriterias");
            DropIndex("dbo.EmployeeCriterias", new[] { "IndustryCriteria_IndustryCriteriaId" });
            DropIndex("dbo.TransactionCriterias", new[] { "CustomerCriteria_CustomerCriteriaId" });
            DropIndex("dbo.CustomerCriterias", new[] { "EmployeeCriteria_EmployeeCriteriaId" });
            AlterColumn("dbo.EmployeeCriterias", "IndustryCriteria_IndustryCriteriaId", c => c.Int(nullable: false));
            DropColumn("dbo.TransactionCriterias", "CustomerCriteria_CustomerCriteriaId");
            DropColumn("dbo.CustomerCriterias", "EmployeeCriteria_EmployeeCriteriaId");
            RenameColumn(table: "dbo.EmployeeCriterias", name: "IndustryCriteria_IndustryCriteriaId", newName: "IndustryCriteriaId");
            CreateIndex("dbo.EmployeeCriterias", "IndustryCriteriaId");
            AddForeignKey("dbo.EmployeeCriterias", "IndustryCriteriaId", "dbo.IndustryCriterias", "IndustryCriteriaId", cascadeDelete: true);
        }
    }
}
