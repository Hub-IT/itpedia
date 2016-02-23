using System.Collections.Generic;

namespace ItPedia.Models
{
    public class TransactionCriteria
    {
        public virtual int TransactionCriteriaId { get; set; }
        public virtual string PerMonth { get; set; }

        public virtual List<CustomerCriteria> CustomerCriterias { get; set; }
    }
}