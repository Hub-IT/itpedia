using System.Collections.Generic;

namespace ItPedia.Models
{
    public class EmployeeCriteria
    {
        public EmployeeCriteria()
        {
            IndustryCriterias = new HashSet<IndustryCriteria>();
            CustomerCriteria = new HashSet<CustomerCriteria>();
            TransactionCriteria = new HashSet<TransactionCriteria>();
        }

        public int EmployeeCriteriaId { get; set; }
        public string Size { get; set; }

        public virtual ICollection<IndustryCriteria> IndustryCriterias { get; set; }
        public virtual ICollection<CustomerCriteria> CustomerCriteria { get; set; }
        public virtual ICollection<TransactionCriteria> TransactionCriteria { get; set; }
    }
}