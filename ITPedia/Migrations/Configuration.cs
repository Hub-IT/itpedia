using System.Data.Entity.Migrations;
using ItPedia.Migrations.Seeds;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ItPediaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ItPediaDbContext context)
        {
            new TermSeeder(context);

            new IndustryCriteriaSeeder(context);
            new EmployeeCriteriaSeeder(context);
            new CustomerCriteriaSeeder(context);
            new TransactionCriteriaSeeder(context);

            new CategorySeeder(context);
            new SolutionSeeder(context);
            new ProposalSeeder(context);
        }
    }
}