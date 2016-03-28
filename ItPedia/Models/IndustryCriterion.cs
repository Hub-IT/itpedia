using System.Collections.Generic;

namespace ItPedia.Models
{
    public class IndustryCriterion
    {
        public IndustryCriterion()
        {
            EmployeeCriteria = new HashSet<EmployeeCriterion>();
            CustomerCriteria = new HashSet<CustomerCriterion>();
            TransactionCriteria = new HashSet<TransactionCriterion>();
        }

        public int IndustryCriterionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmployeeCriterion> EmployeeCriteria { get; set; }
        public virtual ICollection<CustomerCriterion> CustomerCriteria { get; set; }
        public virtual ICollection<TransactionCriterion> TransactionCriteria { get; set; }
    }
}