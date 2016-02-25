namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerCriterias",
                c => new
                    {
                        CustomerCriteriaId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.CustomerCriteriaId);
            
            CreateTable(
                "dbo.EmployeeCriterias",
                c => new
                    {
                        EmployeeCriteriaId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeCriteriaId);
            
            CreateTable(
                "dbo.IndustryCriterias",
                c => new
                    {
                        IndustryCriteriaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IndustryCriteriaId);
            
            CreateTable(
                "dbo.TransactionCriterias",
                c => new
                    {
                        TransactionCriteriaId = c.Int(nullable: false, identity: true),
                        PerMonth = c.String(),
                    })
                .PrimaryKey(t => t.TransactionCriteriaId);
            
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
                        TransactionCriteria_TransactionCriteriaId = c.Int(),
                    })
                .PrimaryKey(t => t.SolutionId)
                .ForeignKey("dbo.EmployeeCriterias", t => t.EmployeeCriteria_EmployeeCriteriaId)
                .ForeignKey("dbo.IndustryCriterias", t => t.IndustryCriteria_IndustryCriteriaId)
                .ForeignKey("dbo.SolutionCategories", t => t.SolutionCategory_SolutionCategoryId)
                .ForeignKey("dbo.TransactionCriterias", t => t.TransactionCriteria_TransactionCriteriaId)
                .Index(t => t.EmployeeCriteria_EmployeeCriteriaId)
                .Index(t => t.IndustryCriteria_IndustryCriteriaId)
                .Index(t => t.SolutionCategory_SolutionCategoryId)
                .Index(t => t.TransactionCriteria_TransactionCriteriaId);
            
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
            
            CreateTable(
                "dbo.EmployeeCriteriaCustomerCriterias",
                c => new
                    {
                        EmployeeCriteria_EmployeeCriteriaId = c.Int(nullable: false),
                        CustomerCriteria_CustomerCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeCriteria_EmployeeCriteriaId, t.CustomerCriteria_CustomerCriteriaId })
                .ForeignKey("dbo.EmployeeCriterias", t => t.EmployeeCriteria_EmployeeCriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.CustomerCriterias", t => t.CustomerCriteria_CustomerCriteriaId, cascadeDelete: true)
                .Index(t => t.EmployeeCriteria_EmployeeCriteriaId)
                .Index(t => t.CustomerCriteria_CustomerCriteriaId);
            
            CreateTable(
                "dbo.IndustryCriteriaCustomerCriterias",
                c => new
                    {
                        IndustryCriteria_IndustryCriteriaId = c.Int(nullable: false),
                        CustomerCriteria_CustomerCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IndustryCriteria_IndustryCriteriaId, t.CustomerCriteria_CustomerCriteriaId })
                .ForeignKey("dbo.IndustryCriterias", t => t.IndustryCriteria_IndustryCriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.CustomerCriterias", t => t.CustomerCriteria_CustomerCriteriaId, cascadeDelete: true)
                .Index(t => t.IndustryCriteria_IndustryCriteriaId)
                .Index(t => t.CustomerCriteria_CustomerCriteriaId);
            
            CreateTable(
                "dbo.IndustryCriteriaEmployeeCriterias",
                c => new
                    {
                        IndustryCriteria_IndustryCriteriaId = c.Int(nullable: false),
                        EmployeeCriteria_EmployeeCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IndustryCriteria_IndustryCriteriaId, t.EmployeeCriteria_EmployeeCriteriaId })
                .ForeignKey("dbo.IndustryCriterias", t => t.IndustryCriteria_IndustryCriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeCriterias", t => t.EmployeeCriteria_EmployeeCriteriaId, cascadeDelete: true)
                .Index(t => t.IndustryCriteria_IndustryCriteriaId)
                .Index(t => t.EmployeeCriteria_EmployeeCriteriaId);
            
            CreateTable(
                "dbo.TransactionCriteriaCustomerCriterias",
                c => new
                    {
                        TransactionCriteria_TransactionCriteriaId = c.Int(nullable: false),
                        CustomerCriteria_CustomerCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionCriteria_TransactionCriteriaId, t.CustomerCriteria_CustomerCriteriaId })
                .ForeignKey("dbo.TransactionCriterias", t => t.TransactionCriteria_TransactionCriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.CustomerCriterias", t => t.CustomerCriteria_CustomerCriteriaId, cascadeDelete: true)
                .Index(t => t.TransactionCriteria_TransactionCriteriaId)
                .Index(t => t.CustomerCriteria_CustomerCriteriaId);
            
            CreateTable(
                "dbo.TransactionCriteriaEmployeeCriterias",
                c => new
                    {
                        TransactionCriteria_TransactionCriteriaId = c.Int(nullable: false),
                        EmployeeCriteria_EmployeeCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionCriteria_TransactionCriteriaId, t.EmployeeCriteria_EmployeeCriteriaId })
                .ForeignKey("dbo.TransactionCriterias", t => t.TransactionCriteria_TransactionCriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeCriterias", t => t.EmployeeCriteria_EmployeeCriteriaId, cascadeDelete: true)
                .Index(t => t.TransactionCriteria_TransactionCriteriaId)
                .Index(t => t.EmployeeCriteria_EmployeeCriteriaId);
            
            CreateTable(
                "dbo.TransactionCriteriaIndustryCriterias",
                c => new
                    {
                        TransactionCriteria_TransactionCriteriaId = c.Int(nullable: false),
                        IndustryCriteria_IndustryCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionCriteria_TransactionCriteriaId, t.IndustryCriteria_IndustryCriteriaId })
                .ForeignKey("dbo.TransactionCriterias", t => t.TransactionCriteria_TransactionCriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.IndustryCriterias", t => t.IndustryCriteria_IndustryCriteriaId, cascadeDelete: true)
                .Index(t => t.TransactionCriteria_TransactionCriteriaId)
                .Index(t => t.IndustryCriteria_IndustryCriteriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solutions", "TransactionCriteria_TransactionCriteriaId", "dbo.TransactionCriterias");
            DropForeignKey("dbo.Solutions", "SolutionCategory_SolutionCategoryId", "dbo.SolutionCategories");
            DropForeignKey("dbo.Solutions", "IndustryCriteria_IndustryCriteriaId", "dbo.IndustryCriterias");
            DropForeignKey("dbo.Solutions", "EmployeeCriteria_EmployeeCriteriaId", "dbo.EmployeeCriterias");
            DropForeignKey("dbo.TransactionCriteriaIndustryCriterias", "IndustryCriteria_IndustryCriteriaId", "dbo.IndustryCriterias");
            DropForeignKey("dbo.TransactionCriteriaIndustryCriterias", "TransactionCriteria_TransactionCriteriaId", "dbo.TransactionCriterias");
            DropForeignKey("dbo.TransactionCriteriaEmployeeCriterias", "EmployeeCriteria_EmployeeCriteriaId", "dbo.EmployeeCriterias");
            DropForeignKey("dbo.TransactionCriteriaEmployeeCriterias", "TransactionCriteria_TransactionCriteriaId", "dbo.TransactionCriterias");
            DropForeignKey("dbo.TransactionCriteriaCustomerCriterias", "CustomerCriteria_CustomerCriteriaId", "dbo.CustomerCriterias");
            DropForeignKey("dbo.TransactionCriteriaCustomerCriterias", "TransactionCriteria_TransactionCriteriaId", "dbo.TransactionCriterias");
            DropForeignKey("dbo.IndustryCriteriaEmployeeCriterias", "EmployeeCriteria_EmployeeCriteriaId", "dbo.EmployeeCriterias");
            DropForeignKey("dbo.IndustryCriteriaEmployeeCriterias", "IndustryCriteria_IndustryCriteriaId", "dbo.IndustryCriterias");
            DropForeignKey("dbo.IndustryCriteriaCustomerCriterias", "CustomerCriteria_CustomerCriteriaId", "dbo.CustomerCriterias");
            DropForeignKey("dbo.IndustryCriteriaCustomerCriterias", "IndustryCriteria_IndustryCriteriaId", "dbo.IndustryCriterias");
            DropForeignKey("dbo.EmployeeCriteriaCustomerCriterias", "CustomerCriteria_CustomerCriteriaId", "dbo.CustomerCriterias");
            DropForeignKey("dbo.EmployeeCriteriaCustomerCriterias", "EmployeeCriteria_EmployeeCriteriaId", "dbo.EmployeeCriterias");
            DropIndex("dbo.TransactionCriteriaIndustryCriterias", new[] { "IndustryCriteria_IndustryCriteriaId" });
            DropIndex("dbo.TransactionCriteriaIndustryCriterias", new[] { "TransactionCriteria_TransactionCriteriaId" });
            DropIndex("dbo.TransactionCriteriaEmployeeCriterias", new[] { "EmployeeCriteria_EmployeeCriteriaId" });
            DropIndex("dbo.TransactionCriteriaEmployeeCriterias", new[] { "TransactionCriteria_TransactionCriteriaId" });
            DropIndex("dbo.TransactionCriteriaCustomerCriterias", new[] { "CustomerCriteria_CustomerCriteriaId" });
            DropIndex("dbo.TransactionCriteriaCustomerCriterias", new[] { "TransactionCriteria_TransactionCriteriaId" });
            DropIndex("dbo.IndustryCriteriaEmployeeCriterias", new[] { "EmployeeCriteria_EmployeeCriteriaId" });
            DropIndex("dbo.IndustryCriteriaEmployeeCriterias", new[] { "IndustryCriteria_IndustryCriteriaId" });
            DropIndex("dbo.IndustryCriteriaCustomerCriterias", new[] { "CustomerCriteria_CustomerCriteriaId" });
            DropIndex("dbo.IndustryCriteriaCustomerCriterias", new[] { "IndustryCriteria_IndustryCriteriaId" });
            DropIndex("dbo.EmployeeCriteriaCustomerCriterias", new[] { "CustomerCriteria_CustomerCriteriaId" });
            DropIndex("dbo.EmployeeCriteriaCustomerCriterias", new[] { "EmployeeCriteria_EmployeeCriteriaId" });
            DropIndex("dbo.Solutions", new[] { "TransactionCriteria_TransactionCriteriaId" });
            DropIndex("dbo.Solutions", new[] { "SolutionCategory_SolutionCategoryId" });
            DropIndex("dbo.Solutions", new[] { "IndustryCriteria_IndustryCriteriaId" });
            DropIndex("dbo.Solutions", new[] { "EmployeeCriteria_EmployeeCriteriaId" });
            DropTable("dbo.TransactionCriteriaIndustryCriterias");
            DropTable("dbo.TransactionCriteriaEmployeeCriterias");
            DropTable("dbo.TransactionCriteriaCustomerCriterias");
            DropTable("dbo.IndustryCriteriaEmployeeCriterias");
            DropTable("dbo.IndustryCriteriaCustomerCriterias");
            DropTable("dbo.EmployeeCriteriaCustomerCriterias");
            DropTable("dbo.Terms");
            DropTable("dbo.Solutions");
            DropTable("dbo.SolutionCategories");
            DropTable("dbo.TransactionCriterias");
            DropTable("dbo.IndustryCriterias");
            DropTable("dbo.EmployeeCriterias");
            DropTable("dbo.CustomerCriterias");
        }
    }
}
