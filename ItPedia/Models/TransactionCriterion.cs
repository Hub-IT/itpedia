using System.Collections.Generic;

namespace ItPedia.Models
{
    public class TransactionCriterion
    {
        public TransactionCriterion()
        {
            IndustryCriteria = new HashSet<IndustryCriterion>();
            EmployeeCriteria = new HashSet<EmployeeCriterion>();
            CustomerCriteria = new HashSet<CustomerCriterion>();
        }

        public int TransactionCriterionId { get; set; }
        public string PerMonth { get; set; }

        public virtual ICollection<IndustryCriterion> IndustryCriteria { get; set; }
        public virtual ICollection<EmployeeCriterion> EmployeeCriteria { get; set; }
        public virtual ICollection<CustomerCriterion> CustomerCriteria { get; set; }
    }
}