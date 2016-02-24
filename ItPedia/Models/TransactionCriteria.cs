using System.Collections.Generic;

namespace ItPedia.Models
{
    public partial class TransactionCriteria
    {
        public TransactionCriteria()
        {
            this.CustomerCriterias = new HashSet<CustomerCriteria>();
        }

        public int TransactionCriteriaId { get; set; }
        public string PerMonth { get; set; }

        public virtual ICollection<CustomerCriteria> CustomerCriterias { get; set; }
    }
}