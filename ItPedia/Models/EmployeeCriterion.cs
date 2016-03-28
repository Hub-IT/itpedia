using System.Collections.Generic;

namespace ItPedia.Models
{
    public class EmployeeCriterion
    {
        public EmployeeCriterion()
        {
            IndustryCriteria = new HashSet<IndustryCriterion>();
            CustomerCriteria = new HashSet<CustomerCriterion>();
            TransactionCriteria = new HashSet<TransactionCriterion>();
        }

        public int EmployeeCriterionId { get; set; }
        public string Size { get; set; }

        public virtual ICollection<IndustryCriterion> IndustryCriteria { get; set; }
        public virtual ICollection<CustomerCriterion> CustomerCriteria { get; set; }
        public virtual ICollection<TransactionCriterion> TransactionCriteria { get; set; }
    }
}