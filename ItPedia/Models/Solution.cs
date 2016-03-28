using System.Collections.Generic;

namespace ItPedia.Models
{
    public class Solution
    {
        public int SolutionId { get; set; }
        public virtual string Name { get; set; }

        public virtual int IndustryCriterionId { get; set; }
        public virtual IndustryCriterion IndustryCriterion { get; set; }
        public virtual int EmployeeCriterionId { get; set; }
        public virtual EmployeeCriterion EmployeeCriterion { get; set; }
        public virtual int CustomerCriterionId { get; set; }
        public virtual CustomerCriterion CustomerCriterion { get; set; }
        public virtual int TransactionCriterionId { get; set; }
        public virtual TransactionCriterion TransactionCriterion { get; set; }

        public virtual List<Proposal> Proposals { get; set; }

    }
}