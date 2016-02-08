using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ITPedia.Models
{
    public class TransactionPm
    {
        public virtual string TransactionPmId { get; set; }
        public virtual string Size { get; set; }

        public static IQueryable<TransactionPm> GetTransactionsPm()
        {
            return new List<TransactionPm>
            {
                new TransactionPm
                {
                    TransactionPmId = "100",
                    Size = "up to 100"
                },
                new TransactionPm
                {
                    TransactionPmId = "100more",
                    Size = "more than 100"
                }
            }.AsQueryable();
        }

        public static SelectList GetTransactionPmSelectList()
        {
            var transactions = GetTransactionsPm();

            return new SelectList(transactions.ToArray(), "EmployeeId", "Size");
        }
    }
}