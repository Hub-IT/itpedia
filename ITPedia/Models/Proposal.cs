using System.Collections.Generic;

namespace ItPedia.Models
{
    public class Proposal
    {
        public virtual List<ProposalTerm> ProposalTerms { get; set; }
    }
}