using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Migrations.Seeds
{
    public class ProposalTermSeeder
    {
        public ProposalTermSeeder(ItPediaDbContext context)
        {
            var hardwareProposalSolutions1 = context.Proposals.First(i => i.Name == "Solution 1: Hardware Proposals");
            var softwareProposalSolution1 = context.Proposals.First(i => i.Name == "Solution 1: Software Proposals");
            var applicationProposalSolution1 = context.Proposals.First(i => i.Name == "Solution 1: Application Proposals");
            var networkProposalSolution1 = context.Proposals.First(i => i.Name == "Solution 1: Network Proposals");
            var storageProposalSolution1 = context.Proposals.First(i => i.Name == "Solution 1: Storage Proposals");

            var desktopTerm = context.Terms.First(i => i.Name == "Desktop");
            var printerTerm = context.Terms.First(i => i.Name == "Printer");
            var upsTerm = context.Terms.First(i => i.Name == "UPS");
            var operatingSystemTerm = context.Terms.First(i => i.Name == "Operating System");
            var officeApplicationTerm = context.Terms.First(i => i.Name == "MS Office 2013");
            var switchTerm = context.Terms.First(i => i.Name == "Switch");
            var routerTerm = context.Terms.First(i => i.Name == "Router");
            var internalControlTerm = context.Terms.First(i => i.Name == "Internal Control");


            context.ProposalTerms.AddOrUpdate(proposalTerm => proposalTerm.ProposalTermId,
                new ProposalTerm
                {
                    Specification = "1 - 3",
                    TermId = desktopTerm.TermId,
                    ProposalId = hardwareProposalSolutions1.ProposalId
                },
                new ProposalTerm
                {
                    Specification = "1",
                    TermId = printerTerm.TermId,
                    ProposalId = hardwareProposalSolutions1.ProposalId
                },
                new ProposalTerm
                {
                    Specification = "",
                    TermId = upsTerm.TermId,
                    ProposalId = hardwareProposalSolutions1.ProposalId
                },
                new ProposalTerm
                {
                    Specification = "",
                    TermId = operatingSystemTerm.TermId,
                    ProposalId = softwareProposalSolution1.ProposalId
                },
                new ProposalTerm
                {
                    Specification = "",
                    TermId = officeApplicationTerm.TermId,
                    ProposalId = applicationProposalSolution1.ProposalId
                },
                new ProposalTerm
                {
                    Specification = "",
                    TermId = switchTerm.TermId,
                    ProposalId = networkProposalSolution1.ProposalId
                },
                new ProposalTerm
                {
                    Specification = "",
                    TermId = routerTerm.TermId,
                    ProposalId = networkProposalSolution1.ProposalId
                },
                new ProposalTerm
                {
                    Specification = "",
                    TermId = internalControlTerm.TermId,
                    ProposalId = storageProposalSolution1.ProposalId
                }
                );

            context.SaveChanges();
        }
    }
}