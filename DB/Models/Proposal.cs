using System.Collections.Generic;
using System.Linq;

namespace DB.Models
{
    public class Proposal
    {
        public int ProposalCode { get; set; }
        public int SolutionCode { get; set; }
        public Dictionary<Term, string> HardwareSolutions { get; set; }
        public Dictionary<Term, string> SoftwareSolutions { get; set; }
        public Dictionary<Term, string> AppSolutions { get; set; }
        public Dictionary<Term, string> NetSolutions { get; set; }
        public Dictionary<Term, string> StorageSolutions { get; set; }


        public static IQueryable<Proposal> Get()
        {
            return Proposals().AsQueryable();
        }


        private static IEnumerable<Proposal> Proposals()
        {
            return new List<Proposal>
            {
                new Proposal
                {
                    ProposalCode = 1,
                    SolutionCode = 1,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Computer"), "1-3"},
                        {Term.GetByName("Printer"), "1"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Operating System"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Router"), ""}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Internal Control"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 2,
                    SolutionCode = 2,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "1"},
                        {Term.GetByName("Computer"), "4-10"},
                        {Term.GetByName("Printer"), "1"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microserver"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Router"), ""}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Internal Control"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 3,
                    SolutionCode = 3,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "2"},
                        {Term.GetByName("Computer"), "11-25"},
                        {Term.GetByName("Print Server"), "2"},
                        {Term.GetByName("Scanner"), "1"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microserver"), "2"},
                        {Term.GetByName("Mail Server"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""},
                        {Term.GetByName("ERP"), ""},
                        {Term.GetByName("CRM"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Router"), ""}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Internal Control"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 4,
                    SolutionCode = 4,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "2"},
                        {Term.GetByName("Computer"), "22-50"},
                        {Term.GetByName("Client-Server Network"), "2"},
                        {Term.GetByName("Scanner"), "1"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microsoft Windows Server 2016"), "2"},
                        {Term.GetByName("Mail Server"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""},
                        {Term.GetByName("ERP"), ""},
                        {Term.GetByName("CRM"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Router"), ""}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("HPSS"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 5,
                    SolutionCode = 5,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "3"},
                        {Term.GetByName("Computer"), "25-50"},
                        {Term.GetByName("Print Server"), "2"},
                        {Term.GetByName("Scanner"), "1"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microsoft Windows Server 2016"), "3"},
                        {Term.GetByName("Mail Server"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""},
                        {Term.GetByName("ERP"), ""},
                        {Term.GetByName("CRM"), ""},
                        {Term.GetByName("Application"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Firewall"), ""},
                        {Term.GetByName("Router"), ""}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("HPSS"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 6,
                    SolutionCode = 6,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "3"},
                        {Term.GetByName("Computer"), "50-100"},
                        {Term.GetByName("Print Server"), "4"},
                        {Term.GetByName("Scanner"), "2"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microsoft Windows Server 2016"), "3"},
                        {Term.GetByName("Mail Server"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""},
                        {Term.GetByName("ERP"), ""},
                        {Term.GetByName("CRM"), ""},
                        {Term.GetByName("HRIS"), ""},
                        {Term.GetByName("HRIS"), ""},
                        {Term.GetByName("Application"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Firewall"), ""},
                        {Term.GetByName("Router"), ""}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("HPSS"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 7,
                    SolutionCode = 7,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "4"},
                        {Term.GetByName("Computer"), "50-100"},
                        {Term.GetByName("Print Server"), "4"},
                        {Term.GetByName("Scanner"), "2"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microsoft Windows Server 2016"), "4"},
                        {Term.GetByName("Mail Server"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""},
                        {Term.GetByName("ERP"), ""},
                        {Term.GetByName("CRM"), ""},
                        {Term.GetByName("HRIS"), ""},
                        {Term.GetByName("Application"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Firewall"), ""},
                        {Term.GetByName("Router"), ""}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("HPSS"), ""},
                        {Term.GetByName("Tape Library"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 8,
                    SolutionCode = 8,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "8"},
                        {Term.GetByName("Computer"), "100-200"},
                        {Term.GetByName("Print Server"), "8"},
                        {Term.GetByName("Scanner"), "4"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microsoft Windows Server 2016"), "8"},
                        {Term.GetByName("Mail Server"), ""},
                        {Term.GetByName("NMS"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""},
                        {Term.GetByName("ERP"), ""},
                        {Term.GetByName("CRM"), ""},
                        {Term.GetByName("HRIS"), ""},
                        {Term.GetByName("Application"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Firewall"), ""},
                        {Term.GetByName("Router"), ""}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("HPSS"), ""},
                        {Term.GetByName("Tape Library"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 9,
                    SolutionCode = 9,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "8"},
                        {Term.GetByName("Computer"), "100-200"},
                        {Term.GetByName("Print Server"), "8"},
                        {Term.GetByName("Scanner"), "4"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microsoft Windows Server 2016"), "8"},
                        {Term.GetByName("Mail Server"), ""},
                        {Term.GetByName("NMS"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), ""}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""},
                        {Term.GetByName("ERP"), ""},
                        {Term.GetByName("CRM"), ""},
                        {Term.GetByName("HRIS"), ""},
                        {Term.GetByName("Application"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), ""},
                        {Term.GetByName("Firewall"), "2"},
                        {Term.GetByName("Router"), "2"}
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("SAN File System"), ""},
                        {Term.GetByName("Tape Library"), ""}
                    }
                },
                new Proposal
                {
                    ProposalCode = 10,
                    SolutionCode = 10,
                    HardwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Server"), "Main Site: 8, UPS & Disaster Site: 4"},
                        {Term.GetByName("Computer"), "100-200"},
                        {Term.GetByName("Print Server"), "8"},
                        {Term.GetByName("Scanner"), "4"},
                        {Term.GetByName("UPS"), ""}
                    },
                    SoftwareSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Microsoft Windows Server 2016"), "Main Site: 8, Disaster Site: 4"},
                        {Term.GetByName("Mail Server"), ""},
                        {Term.GetByName("NMS"), ""},
                        {Term.GetByName("Operating System"), ""},
                        {Term.GetByName("Backup"), "Disaster Site"}
                    },
                    AppSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("MS Office 2013"), ""},
                        {Term.GetByName("ERP"), ""},
                        {Term.GetByName("CRM"), ""},
                        {Term.GetByName("HRIS"), ""},
                        {Term.GetByName("Application"), ""}
                    },
                    NetSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("Switch"), "Main Site, 2"},
                        {Term.GetByName("Firewall"), "2"},
                    },
                    StorageSolutions = new Dictionary<Term, string>
                    {
                        {Term.GetByName("SAN File System"), "Main Site, Disaster Site"},
                        {Term.GetByName("Tape Library"), ""}
                    }
                }
            };
        }

        public static Proposal GetBySolutionCode(int solutionCode)
        {
            return Proposals().First(proposal => solutionCode == proposal.SolutionCode);
        }
    }
}