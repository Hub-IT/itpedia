using System.Data.Entity.Migrations;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class CategorySeeder
    {
        public CategorySeeder(ItPediaDbContext context)
        {

            context.Categories.AddOrUpdate(category => category.Name,
                new Category { Name = "Hardware", },
                new Category { Name = "Software", },
                new Category { Name = "Applications", },
                new Category { Name = "Networking", },
                new Category { Name = "Storage", }
                );

            context.SaveChanges();
        }
    }
}