using ItPedia.Models;

namespace ItPedia.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ItPedia.Models.ItPediaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "ItPedia.Models.ItPediaDbContext";
        }

        protected override void Seed(ItPedia.Models.ItPediaDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.SolutionCategories.AddOrUpdate(solutionCategory => solutionCategory.Id,
                new SolutionCategory {Id = 1, Name = "Hardware"},
                new SolutionCategory {Name = "Software", Id = 2},
                new SolutionCategory {Name = "Applications", Id = 3},
                new SolutionCategory {Name = "Networks", Id = 4},
                new SolutionCategory {Name = "Storage", Id = 5},
                new SolutionCategory {Name = "Fixed Costs", Id = 6},
                new SolutionCategory {Name = "Recurring Costs", Id = 7},
                new SolutionCategory {Name = "Recurring Costs", Id = 9},
                new SolutionCategory {Name = "Recurring Costs2", Id = 8}
                );
        }
    }
}