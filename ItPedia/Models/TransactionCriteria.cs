using System.Collections.Generic;

namespace ItPedia.Models
{
    public class TransactionCriteria
    {
        public TransactionCriteria()
        {
            CustomerCriterias = new HashSet<CustomerCriteria>();
        }

        public int TransactionCriteriaId { get; set; }
        public string PerMonth { get; set; }

        public virtual ICollection<CustomerCriteria> CustomerCriterias { get; set; }
    }
}