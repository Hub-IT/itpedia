using System.Collections.Generic;

namespace ItPedia.Models
{
    public class IndustryCriteria
    {
        public IndustryCriteria()
        {
            EmployeeCriterias = new HashSet<EmployeeCriteria>();
            CustomerCriteria = new HashSet<CustomerCriteria>();
            TransactionCriteria = new HashSet<TransactionCriteria>();
        }

        public int IndustryCriteriaId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmployeeCriteria> EmployeeCriterias { get; set; }
        public virtual ICollection<CustomerCriteria> CustomerCriteria { get; set; }
        public virtual ICollection<TransactionCriteria> TransactionCriteria { get; set; }
    }
}