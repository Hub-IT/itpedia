namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2016_02_09_11_58 : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerCriterias");
        }
    }
}
