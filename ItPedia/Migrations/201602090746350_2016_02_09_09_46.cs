namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2016_02_09_09_46 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeCriterias", "IndustryCriteriaId", c => c.Int(nullable: false));
            CreateIndex("dbo.EmployeeCriterias", "IndustryCriteriaId");
            AddForeignKey("dbo.EmployeeCriterias", "IndustryCriteriaId", "dbo.IndustryCriterias", "IndustryCriteriaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeCriterias", "IndustryCriteriaId", "dbo.IndustryCriterias");
            DropIndex("dbo.EmployeeCriterias", new[] { "IndustryCriteriaId" });
            DropColumn("dbo.EmployeeCriterias", "IndustryCriteriaId");
        }
    }
}
