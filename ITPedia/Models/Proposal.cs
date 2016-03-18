using System.Collections.Generic;

namespace ItPedia.Models
{
    public class Proposal
    {
        public int ProposalId { get; set; }

        public virtual string Name { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual int SolutionId { get; set; }
        public virtual Solution Solution { get; set; }

        public virtual List<ProposalTerm> ProposalTerms { get; set; }
    }
}