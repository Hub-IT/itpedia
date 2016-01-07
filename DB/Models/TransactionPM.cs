using System.Collections.Generic;
using System.Linq;

namespace DB.Models
{
    public class TransactionPm
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static IQueryable<TransactionPm> GetTransactionsPm()
        {
            return new List<TransactionPm>
            {
                new TransactionPm
                {
                    Code = "100",
                    Name = "up to 100"
                },
                new TransactionPm
                {
                    Code = "100more",
                    Name = "more than 100"
                }
            }.AsQueryable();
        }
    }
}