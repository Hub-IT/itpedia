namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Proposals",
                c => new
                    {
                        ProposalId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SolutionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProposalId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Solutions", t => t.SolutionId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.SolutionId);
            
            CreateTable(
                "dbo.ProposalTerms",
                c => new
                    {
                        ProposalTermId = c.Int(nullable: false, identity: true),
                        Specification = c.String(),
                        TermId = c.Int(nullable: false),
                        ProposalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProposalTermId)
                .ForeignKey("dbo.Proposals", t => t.ProposalId, cascadeDelete: true)
                .ForeignKey("dbo.Terms", t => t.TermId, cascadeDelete: true)
                .Index(t => t.TermId)
                .Index(t => t.ProposalId);
            
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
                "dbo.Solutions",
                c => new
                    {
                        SolutionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IndustryCriterionId = c.Int(nullable: false),
                        EmployeeCriterionId = c.Int(nullable: false),
                        CustomerCriterionId = c.Int(nullable: false),
                        TransactionCriterionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SolutionId)
                .ForeignKey("dbo.CustomerCriterions", t => t.CustomerCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeCriterions", t => t.EmployeeCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.IndustryCriterions", t => t.IndustryCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.TransactionCriterions", t => t.TransactionCriterionId, cascadeDelete: true)
                .Index(t => t.IndustryCriterionId)
                .Index(t => t.EmployeeCriterionId)
                .Index(t => t.CustomerCriterionId)
                .Index(t => t.TransactionCriterionId);
            
            CreateTable(
                "dbo.CustomerCriterions",
                c => new
                    {
                        CustomerCriterionId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.CustomerCriterionId);
            
            CreateTable(
                "dbo.EmployeeCriterions",
                c => new
                    {
                        EmployeeCriterionId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeCriterionId);
            
            CreateTable(
                "dbo.IndustryCriterions",
                c => new
                    {
                        IndustryCriterionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IndustryCriterionId);
            
            CreateTable(
                "dbo.TransactionCriterions",
                c => new
                    {
                        TransactionCriterionId = c.Int(nullable: false, identity: true),
                        PerMonth = c.String(),
                    })
                .PrimaryKey(t => t.TransactionCriterionId);
            
            CreateTable(
                "dbo.EmployeeCriterionCustomerCriterions",
                c => new
                    {
                        EmployeeCriterion_EmployeeCriterionId = c.Int(nullable: false),
                        CustomerCriterion_CustomerCriterionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeCriterion_EmployeeCriterionId, t.CustomerCriterion_CustomerCriterionId })
                .ForeignKey("dbo.EmployeeCriterions", t => t.EmployeeCriterion_EmployeeCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.CustomerCriterions", t => t.CustomerCriterion_CustomerCriterionId, cascadeDelete: true)
                .Index(t => t.EmployeeCriterion_EmployeeCriterionId)
                .Index(t => t.CustomerCriterion_CustomerCriterionId);
            
            CreateTable(
                "dbo.IndustryCriterionCustomerCriterions",
                c => new
                    {
                        IndustryCriterion_IndustryCriterionId = c.Int(nullable: false),
                        CustomerCriterion_CustomerCriterionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IndustryCriterion_IndustryCriterionId, t.CustomerCriterion_CustomerCriterionId })
                .ForeignKey("dbo.IndustryCriterions", t => t.IndustryCriterion_IndustryCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.CustomerCriterions", t => t.CustomerCriterion_CustomerCriterionId, cascadeDelete: true)
                .Index(t => t.IndustryCriterion_IndustryCriterionId)
                .Index(t => t.CustomerCriterion_CustomerCriterionId);
            
            CreateTable(
                "dbo.IndustryCriterionEmployeeCriterions",
                c => new
                    {
                        IndustryCriterion_IndustryCriterionId = c.Int(nullable: false),
                        EmployeeCriterion_EmployeeCriterionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IndustryCriterion_IndustryCriterionId, t.EmployeeCriterion_EmployeeCriterionId })
                .ForeignKey("dbo.IndustryCriterions", t => t.IndustryCriterion_IndustryCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeCriterions", t => t.EmployeeCriterion_EmployeeCriterionId, cascadeDelete: true)
                .Index(t => t.IndustryCriterion_IndustryCriterionId)
                .Index(t => t.EmployeeCriterion_EmployeeCriterionId);
            
            CreateTable(
                "dbo.TransactionCriterionCustomerCriterions",
                c => new
                    {
                        TransactionCriterion_TransactionCriterionId = c.Int(nullable: false),
                        CustomerCriterion_CustomerCriterionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionCriterion_TransactionCriterionId, t.CustomerCriterion_CustomerCriterionId })
                .ForeignKey("dbo.TransactionCriterions", t => t.TransactionCriterion_TransactionCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.CustomerCriterions", t => t.CustomerCriterion_CustomerCriterionId, cascadeDelete: true)
                .Index(t => t.TransactionCriterion_TransactionCriterionId)
                .Index(t => t.CustomerCriterion_CustomerCriterionId);
            
            CreateTable(
                "dbo.TransactionCriterionEmployeeCriterions",
                c => new
                    {
                        TransactionCriterion_TransactionCriterionId = c.Int(nullable: false),
                        EmployeeCriterion_EmployeeCriterionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionCriterion_TransactionCriterionId, t.EmployeeCriterion_EmployeeCriterionId })
                .ForeignKey("dbo.TransactionCriterions", t => t.TransactionCriterion_TransactionCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeCriterions", t => t.EmployeeCriterion_EmployeeCriterionId, cascadeDelete: true)
                .Index(t => t.TransactionCriterion_TransactionCriterionId)
                .Index(t => t.EmployeeCriterion_EmployeeCriterionId);
            
            CreateTable(
                "dbo.TransactionCriterionIndustryCriterions",
                c => new
                    {
                        TransactionCriterion_TransactionCriterionId = c.Int(nullable: false),
                        IndustryCriterion_IndustryCriterionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TransactionCriterion_TransactionCriterionId, t.IndustryCriterion_IndustryCriterionId })
                .ForeignKey("dbo.TransactionCriterions", t => t.TransactionCriterion_TransactionCriterionId, cascadeDelete: true)
                .ForeignKey("dbo.IndustryCriterions", t => t.IndustryCriterion_IndustryCriterionId, cascadeDelete: true)
                .Index(t => t.TransactionCriterion_TransactionCriterionId)
                .Index(t => t.IndustryCriterion_IndustryCriterionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solutions", "TransactionCriterionId", "dbo.TransactionCriterions");
            DropForeignKey("dbo.Proposals", "SolutionId", "dbo.Solutions");
            DropForeignKey("dbo.Solutions", "IndustryCriterionId", "dbo.IndustryCriterions");
            DropForeignKey("dbo.Solutions", "EmployeeCriterionId", "dbo.EmployeeCriterions");
            DropForeignKey("dbo.Solutions", "CustomerCriterionId", "dbo.CustomerCriterions");
            DropForeignKey("dbo.TransactionCriterionIndustryCriterions", "IndustryCriterion_IndustryCriterionId", "dbo.IndustryCriterions");
            DropForeignKey("dbo.TransactionCriterionIndustryCriterions", "TransactionCriterion_TransactionCriterionId", "dbo.TransactionCriterions");
            DropForeignKey("dbo.TransactionCriterionEmployeeCriterions", "EmployeeCriterion_EmployeeCriterionId", "dbo.EmployeeCriterions");
            DropForeignKey("dbo.TransactionCriterionEmployeeCriterions", "TransactionCriterion_TransactionCriterionId", "dbo.TransactionCriterions");
            DropForeignKey("dbo.TransactionCriterionCustomerCriterions", "CustomerCriterion_CustomerCriterionId", "dbo.CustomerCriterions");
            DropForeignKey("dbo.TransactionCriterionCustomerCriterions", "TransactionCriterion_TransactionCriterionId", "dbo.TransactionCriterions");
            DropForeignKey("dbo.IndustryCriterionEmployeeCriterions", "EmployeeCriterion_EmployeeCriterionId", "dbo.EmployeeCriterions");
            DropForeignKey("dbo.IndustryCriterionEmployeeCriterions", "IndustryCriterion_IndustryCriterionId", "dbo.IndustryCriterions");
            DropForeignKey("dbo.IndustryCriterionCustomerCriterions", "CustomerCriterion_CustomerCriterionId", "dbo.CustomerCriterions");
            DropForeignKey("dbo.IndustryCriterionCustomerCriterions", "IndustryCriterion_IndustryCriterionId", "dbo.IndustryCriterions");
            DropForeignKey("dbo.EmployeeCriterionCustomerCriterions", "CustomerCriterion_CustomerCriterionId", "dbo.CustomerCriterions");
            DropForeignKey("dbo.EmployeeCriterionCustomerCriterions", "EmployeeCriterion_EmployeeCriterionId", "dbo.EmployeeCriterions");
            DropForeignKey("dbo.ProposalTerms", "TermId", "dbo.Terms");
            DropForeignKey("dbo.ProposalTerms", "ProposalId", "dbo.Proposals");
            DropForeignKey("dbo.Proposals", "CategoryId", "dbo.Categories");
            DropIndex("dbo.TransactionCriterionIndustryCriterions", new[] { "IndustryCriterion_IndustryCriterionId" });
            DropIndex("dbo.TransactionCriterionIndustryCriterions", new[] { "TransactionCriterion_TransactionCriterionId" });
            DropIndex("dbo.TransactionCriterionEmployeeCriterions", new[] { "EmployeeCriterion_EmployeeCriterionId" });
            DropIndex("dbo.TransactionCriterionEmployeeCriterions", new[] { "TransactionCriterion_TransactionCriterionId" });
            DropIndex("dbo.TransactionCriterionCustomerCriterions", new[] { "CustomerCriterion_CustomerCriterionId" });
            DropIndex("dbo.TransactionCriterionCustomerCriterions", new[] { "TransactionCriterion_TransactionCriterionId" });
            DropIndex("dbo.IndustryCriterionEmployeeCriterions", new[] { "EmployeeCriterion_EmployeeCriterionId" });
            DropIndex("dbo.IndustryCriterionEmployeeCriterions", new[] { "IndustryCriterion_IndustryCriterionId" });
            DropIndex("dbo.IndustryCriterionCustomerCriterions", new[] { "CustomerCriterion_CustomerCriterionId" });
            DropIndex("dbo.IndustryCriterionCustomerCriterions", new[] { "IndustryCriterion_IndustryCriterionId" });
            DropIndex("dbo.EmployeeCriterionCustomerCriterions", new[] { "CustomerCriterion_CustomerCriterionId" });
            DropIndex("dbo.EmployeeCriterionCustomerCriterions", new[] { "EmployeeCriterion_EmployeeCriterionId" });
            DropIndex("dbo.Solutions", new[] { "TransactionCriterionId" });
            DropIndex("dbo.Solutions", new[] { "CustomerCriterionId" });
            DropIndex("dbo.Solutions", new[] { "EmployeeCriterionId" });
            DropIndex("dbo.Solutions", new[] { "IndustryCriterionId" });
            DropIndex("dbo.ProposalTerms", new[] { "ProposalId" });
            DropIndex("dbo.ProposalTerms", new[] { "TermId" });
            DropIndex("dbo.Proposals", new[] { "SolutionId" });
            DropIndex("dbo.Proposals", new[] { "CategoryId" });
            DropTable("dbo.TransactionCriterionIndustryCriterions");
            DropTable("dbo.TransactionCriterionEmployeeCriterions");
            DropTable("dbo.TransactionCriterionCustomerCriterions");
            DropTable("dbo.IndustryCriterionEmployeeCriterions");
            DropTable("dbo.IndustryCriterionCustomerCriterions");
            DropTable("dbo.EmployeeCriterionCustomerCriterions");
            DropTable("dbo.TransactionCriterions");
            DropTable("dbo.IndustryCriterions");
            DropTable("dbo.EmployeeCriterions");
            DropTable("dbo.CustomerCriterions");
            DropTable("dbo.Solutions");
            DropTable("dbo.Terms");
            DropTable("dbo.ProposalTerms");
            DropTable("dbo.Proposals");
            DropTable("dbo.Categories");
        }
    }
}
