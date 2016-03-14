using System.Data.Entity.Migrations;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class ProposalTermSeeder
    {
        public ProposalTermSeeder(ItPediaDbContext context)
        {
            context.ProposalTerms.AddOrUpdate(p => p.ProposalTermId, transactionCriterias.ToArray());
        }
    }
}