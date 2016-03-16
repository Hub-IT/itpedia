using System.Collections.Generic;
using System.Data.Entity.Migrations;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class CategorySeeder
    {
        public CategorySeeder(ItPediaDbContext context)
        {
            var categories = new List<Category>
            {
                new Category {Name = "Hardware"},
                new Category {Name = "Software"},
                new Category {Name = "Application(s)"},
                new Category {Name = "Network"},
                new Category {Name = "Storage"},
            };


            context.Categories.AddOrUpdate(p => p.Name, categories.ToArray());
        }
    }
}