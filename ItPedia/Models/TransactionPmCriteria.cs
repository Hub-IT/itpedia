using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ItPedia.Models
{
    public class TransactionPmCriteria
    {
        public virtual int TransactionPmCriteriaId { get; set; }
        public virtual string Size { get; set; }

//        public static IQueryable<TransactionPmCriteria> GetTransactionsPm()
//        {
//            return new List<TransactionPmCriteria>
//            {
//                new TransactionPmCriteria
//                {
//                    TransactionPmId = "100",
//                    Size = "up to 100"
//                },
//                new TransactionPmCriteria
//                {
//                    TransactionPmId = "100more",
//                    Size = "more than 100"
//                }
//            }.AsQueryable();
//        }
//
//        public static SelectList GetTransactionPmSelectList()
//        {
//            var transactions = GetTransactionsPm();
//
//            return new SelectList(transactions.ToArray(), "EmployeeCriteriaId", "Size");
//        }
    }
}