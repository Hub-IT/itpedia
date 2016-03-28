using System.Collections.Generic;

namespace ItPedia.Models
{
    public class CustomerCriterion
    {
        public CustomerCriterion()
        {
            IndustryCriteria = new HashSet<IndustryCriterion>();
            EmployeeCriteria = new HashSet<EmployeeCriterion>();
            TransactionCriteria = new HashSet<TransactionCriterion>();
        }

        public int CustomerCriterionId { get; set; }
        public string Size { get; set; }

        public virtual ICollection<IndustryCriterion> IndustryCriteria { get; set; }
        public virtual ICollection<EmployeeCriterion> EmployeeCriteria { get; set; }
        public virtual ICollection<TransactionCriterion> TransactionCriteria { get; set; }
    }
}