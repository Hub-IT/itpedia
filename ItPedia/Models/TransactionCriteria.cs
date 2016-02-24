using System.Collections.Generic;

namespace ItPedia.Models
{
    public class TransactionCriteria
    {
        public TransactionCriteria()
        {
            IndustryCriterias = new HashSet<IndustryCriteria>();
            EmployeeCriterias = new HashSet<EmployeeCriteria>();
            CustomerCriterias = new HashSet<CustomerCriteria>();
        }

        public int TransactionCriteriaId { get; set; }
        public string PerMonth { get; set; }

        public virtual ICollection<IndustryCriteria> IndustryCriterias { get; set; }
        public virtual ICollection<EmployeeCriteria> EmployeeCriterias { get; set; }
        public virtual ICollection<CustomerCriteria> CustomerCriterias { get; set; }
    }
}