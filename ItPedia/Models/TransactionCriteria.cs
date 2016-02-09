using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ItPedia.Models
{
    public class TransactionCriteria
    {
        public virtual int TransactionCriteriaId { get; set; }
        public virtual string PerMonth { get; set; }
    }
}