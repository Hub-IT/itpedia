using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class SolutionSeeder
    {
        public SolutionSeeder(ItPediaDbContext context)
        {
//            var proposal1 = context.Proposals.First(i => i.SolutionId == 1);
            var termDesktop = context.Terms.First(i => i.Name == "Desktop");
            var termPrinter = context.Terms.First(i => i.Name == "Printer");
            var termUps = context.Terms.First(i => i.Name == "UPS");
            var termMsOffice2013 = context.Terms.First(i => i.Name == "MS Office 2013");
            var termSwitch = context.Terms.First(i => i.Name == "Switch");
            var termRouter = context.Terms.First(i => i.Name == "Router");
            var termInternalControl = context.Terms.First(i => i.Name == "Internal Control");

            var proposalTermsProposal1 = new List<ProposalTerm>
            {
                CreateProposal("1 -3", termDesktop),
                CreateProposal("1", termPrinter),
                CreateProposal("", termUps),
            };

            var proposalSolution1 = new List<Proposal>
            {
                new Proposal
                {
                }
            };


//            context.ProposalTerms.AddOrUpdate(p => p.ProposalTermId, proposalTermsSolution1.ToArray());
            context.SaveChanges();


            new Solution
            {
                
            };
        }

        private static ProposalTerm CreateProposal(string specification, Term termDesktop)
        {
            return new ProposalTerm {Specification = specification, Term = termDesktop};
        }
    }
}