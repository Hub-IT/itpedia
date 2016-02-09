namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2016_02_09_08_51 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IndustryCriterias",
                c => new
                    {
                        IndustryCriteriaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IndustryCriteriaId);
            
            CreateTable(
                "dbo.SolutionCategories",
                c => new
                    {
                        SolutionCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SolutionCategoryId);
            
            CreateTable(
                "dbo.Solutions",
                c => new
                    {
                        SolutionId = c.String(nullable: false, maxLength: 128),
                        IndustryId = c.String(),
                        EmployeeId = c.String(),
                        TransactionId = c.String(),
                        CategoryId = c.Int(nullable: false),
                        EmployeeCriteria_EmployeeCriteriaId = c.Int(),
                        IndustryCriteria_IndustryCriteriaId = c.Int(),
                        SolutionCategory_SolutionCategoryId = c.Int(),
                        TransactionPmCriteria_TransactionPmCriteriaId = c.Int(),
                    })
                .PrimaryKey(t => t.SolutionId)
                .ForeignKey("dbo.EmployeeCriterias", t => t.EmployeeCriteria_EmployeeCriteriaId)
                .ForeignKey("dbo.IndustryCriterias", t => t.IndustryCriteria_IndustryCriteriaId)
                .ForeignKey("dbo.SolutionCategories", t => t.SolutionCategory_SolutionCategoryId)
                .ForeignKey("dbo.TransactionPmCriterias", t => t.TransactionPmCriteria_TransactionPmCriteriaId)
                .Index(t => t.EmployeeCriteria_EmployeeCriteriaId)
                .Index(t => t.IndustryCriteria_IndustryCriteriaId)
                .Index(t => t.SolutionCategory_SolutionCategoryId)
                .Index(t => t.TransactionPmCriteria_TransactionPmCriteriaId);
            
            CreateTable(
                "dbo.EmployeeCriterias",
                c => new
                    {
                        EmployeeCriteriaId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeCriteriaId);
            
            CreateTable(
                "dbo.TransactionPmCriterias",
                c => new
                    {
                        TransactionPmCriteriaId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.TransactionPmCriteriaId);
            
            CreateTable(
                "dbo.Terms",
                c => new
                    {
                        TermId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Source = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.TermId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solutions", "TransactionPmCriteria_TransactionPmCriteriaId", "dbo.TransactionPmCriterias");
            DropForeignKey("dbo.Solutions", "SolutionCategory_SolutionCategoryId", "dbo.SolutionCategories");
            DropForeignKey("dbo.Solutions", "IndustryCriteria_IndustryCriteriaId", "dbo.IndustryCriterias");
            DropForeignKey("dbo.Solutions", "EmployeeCriteria_EmployeeCriteriaId", "dbo.EmployeeCriterias");
            DropIndex("dbo.Solutions", new[] { "TransactionPmCriteria_TransactionPmCriteriaId" });
            DropIndex("dbo.Solutions", new[] { "SolutionCategory_SolutionCategoryId" });
            DropIndex("dbo.Solutions", new[] { "IndustryCriteria_IndustryCriteriaId" });
            DropIndex("dbo.Solutions", new[] { "EmployeeCriteria_EmployeeCriteriaId" });
            DropTable("dbo.Terms");
            DropTable("dbo.TransactionPmCriterias");
            DropTable("dbo.EmployeeCriterias");
            DropTable("dbo.Solutions");
            DropTable("dbo.SolutionCategories");
            DropTable("dbo.IndustryCriterias");
        }
    }
}
