using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class Term
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public static IQueryable<Proposal> GetProposals()
        {

//            return new List<Proposal> {
//                new Proposal {
//                            P_Code = 1,
//                            S_Code = 1,
//                            S_HW = "1-3 Desktop, 1 Printer, UPS",
//                            S_SW = "Desktop Operating System",
//                            S_APP = "Office Applications",
//                            S_NET = "SOHO Switch, ADSL Router",
//                            S_STO = "(Internal)"
//                        },
//
//             }.AsQueryable();

            return new List<Term>
            {
                new Term
                {
                    Id = 1,
                    Name = "Server",
                    Content = "1-3 Desktop, 1 Printer, UPS"
                },
                new Term
                {
                    Id = 2,
                    Name = "Server2",
                    Content = "1-3 Desktop, 1 Printer, UPS"
                }
            }.AsQueryable();
        }
    }
}