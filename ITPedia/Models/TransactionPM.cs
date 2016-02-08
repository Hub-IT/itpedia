using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ITPedia.Models
{
    public class TransactionPm
    {
        public string Code { get; set; }
        public string Size { get; set; }

        public static IQueryable<TransactionPm> GetTransactionsPm()
        {
            return new List<TransactionPm>
            {
                new TransactionPm
                {
                    Code = "100",
                    Size = "up to 100"
                },
                new TransactionPm
                {
                    Code = "100more",
                    Size = "more than 100"
                }
            }.AsQueryable();
        }

        public static SelectList GetTransactionPmSelectList()
        {
            var transactions = GetTransactionsPm();

            return new SelectList(transactions.ToArray(), "Code", "Size");
        }
    }
}