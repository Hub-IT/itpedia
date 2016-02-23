using System.Collections.Generic;

namespace ItPedia.Models
{
    public class CustomerCriteria
    {
        public virtual int CustomerCriteriaId { get; set; }
        public virtual string Size { get; set; }

        public virtual List<TransactionCriteria> Transactions { get; set; }
    }
}