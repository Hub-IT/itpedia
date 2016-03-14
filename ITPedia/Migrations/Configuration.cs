using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Migrations.Seeds;
using ItPedia.Models;
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
            new IndustryCriteriaSeeder(context);


        }
    }
}