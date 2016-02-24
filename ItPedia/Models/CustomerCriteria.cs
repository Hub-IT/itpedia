using System.Collections.Generic;

namespace ItPedia.Models
{
    public class CustomerCriteria
    {
        public CustomerCriteria()
        {
            TransactionCriterias = new HashSet<TransactionCriteria>();
        }

        public int CustomerCriteriaId { get; set; }
        public string Size { get; set; }

        public virtual ICollection<TransactionCriteria> TransactionCriterias { get; set; }
    }
}