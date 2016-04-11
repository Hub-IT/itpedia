using ItPedia.Migrations.Seeds;

namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ItPedia.Models.Contexts.ItPediaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ItPedia.Models.Contexts.ItPediaDbContext context)
        {
            new TermSeeder(context);

            new IndustryCriteriaSeeder(context);
            new EmployeeCriteriaSeeder(context);
            new CustomerCriteriaSeeder(context);
            new TransactionCriteriaSeeder(context);

            new CategorySeeder(context);
            new SolutionSeeder(context);
            new ProposalSeeder(context);
            new ProposalTermSeeder(context);
        }
    }
}
