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
            var solution1 = context.Solutions.First(i => i.Name == "Solution 1");

            var hardwareCategory = context.Categories.First(i => i.Name == "Hardware");
            var softwareCategory = context.Categories.First(i => i.Name == "Software");
            var applicationsCategory = context.Categories.First(i => i.Name == "Applications");
            var networkingCategory = context.Categories.First(i => i.Name == "Networking");
            var storageCategory = context.Categories.First(i => i.Name == "Storage");


            context.Proposals.AddOrUpdate(solution => solution.Name,
                new Proposal
                {
                    Name = "Solution 1: Hardware Proposals",
                    CategoryId = hardwareCategory.CategoryId,
                    SolutionId = solution1.SolutionId
                },
                new Proposal
                {
                    Name = "Solution 1: Software Proposals",
                    CategoryId = softwareCategory.CategoryId,
                    SolutionId = solution1.SolutionId
                },
                new Proposal
                {
                    Name = "Solution 1: Application Proposals",
                    CategoryId = applicationsCategory.CategoryId,
                    SolutionId = solution1.SolutionId
                },
                new Proposal
                {
                    Name = "Solution 1: Network Proposals",
                    CategoryId = networkingCategory.CategoryId,
                    SolutionId = solution1.SolutionId
                },
                new Proposal
                {
                    Name = "Solution 1: Storage Proposals",
                    CategoryId = storageCategory.CategoryId,
                    SolutionId = solution1.SolutionId
                }
                );

            context.SaveChanges();
        }
    }
}