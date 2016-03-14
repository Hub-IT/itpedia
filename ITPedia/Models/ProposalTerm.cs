namespace ItPedia.Models
{
    public class ProposalTerm
    {
        public virtual int ProposalTermId { get; set; }

        public virtual string Number { get; set; }

        public virtual int TermId { get; set; }
        public virtual Term Term { get; set; }
        public virtual int ProposalId { get; set; }
        public virtual Proposal Proposal { get; set; }
    }
}