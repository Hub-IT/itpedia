using System.Collections.Generic;

namespace ItPedia.Models
{
    public class CustomerCriteria
    {
        public CustomerCriteria()
        {
            IndustryCriterias = new HashSet<IndustryCriteria>();
            EmployeeCriterias = new HashSet<EmployeeCriteria>();
            TransactionCriteria = new HashSet<TransactionCriteria>();
        }

        public int CustomerCriteriaId { get; set; }
        public string Size { get; set; }

        public virtual ICollection<IndustryCriteria> IndustryCriterias { get; set; }
        public virtual ICollection<EmployeeCriteria> EmployeeCriterias { get; set; }
        public virtual ICollection<TransactionCriteria> TransactionCriteria { get; set; }
    }
}