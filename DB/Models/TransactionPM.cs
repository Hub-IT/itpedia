using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class TransactionPM
    {
        public string T_Code { get; set; }
        public string T_Name { get; set; }

        public static IQueryable<TransactionPM> GetTransactionsPM()
        {

            return new List<TransactionPM> {
                new TransactionPM {
                            T_Code = "100",
                            T_Name = "up to 100"
                        },
                new TransactionPM {
                            T_Code = "100more",
                            T_Name = "more than 100"
                        }                
             }.AsQueryable();
        }

    }
}