using System.Collections.Generic;

namespace ItPedia.Models
{
    public class Solution
    {
        public int SolutionId { get; set; }
        public virtual string Name { get; set; }

        public virtual int IndustryCriteriaId { get; set; }
        public virtual IndustryCriteria IndustryCriteria { get; set; }
        public virtual int EmployeeCriteriaId { get; set; }
        public virtual EmployeeCriteria EmployeeCriteria { get; set; }
        public virtual int CustomerCriteriaId { get; set; }
        public virtual CustomerCriteria CustomerCriteria { get; set; }
        public virtual int TransactionCriteriaId { get; set; }
        public virtual TransactionCriteria TransactionCriteria { get; set; }

        public virtual List<Proposal> Proposals { get; set; }

    }
}