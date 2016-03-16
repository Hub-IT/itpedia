using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class ProposalSeeder
    {
        public ProposalSeeder(ItPediaDbContext context)
        {
            var hardwareCategory = context.Categories.First(i => i.Name == "Hardware");


            context.Proposals.AddOrUpdate(proposal => proposal.Name,
                new Proposal { Name = "Proposal - Solution 1", CategoryId = hardwareCategory.CategoryId }
                );

            context.SaveChanges();
        }
    }
}