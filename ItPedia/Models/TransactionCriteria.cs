using System.Collections.Generic;

namespace ItPedia.Models
{
    public class TransactionCriteria
    {
        public virtual int TransactionCriteriaId { get; set; }
        public virtual string PerMonth { get; set; }

        public virtual ICollection<CustomerCriteria> CustomerCriterias { get; set; }
    }
}