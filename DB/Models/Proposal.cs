using System.Collections.Generic;
using System.Linq;

namespace DB.Models
{
    public class Proposal
    {
        public int ProposalCode { get; set; }
        public int SolutionCode { get; set; }
        public string SolutionHardware { get; set; }
        public string SolutionSoftware { get; set; }
        public string SolutionApp { get; set; }
        public string SolutionNet { get; set; }
        public string SolutionStorage { get; set; }

        public static IQueryable<Proposal> GetProposals()
        {
            return new List<Proposal>
            {
                new Proposal
                {
                    ProposalCode = 1,
                    SolutionCode = 1,
                    SolutionHardware = "1-3 Desktop, 1 Printer, UPS",
                    SolutionSoftware = "Desktop Operating System",
                    SolutionApp = "Office Applications",
                    SolutionNet = "SOHO Switch, ADSL Router",
                    SolutionStorage = "(Internal)"
                },
                new Proposal
                {
                    ProposalCode = 2,
                    SolutionCode = 2,
                    SolutionHardware = "1 Server, 4-10 Desktop, 1 Printer, UPS",
                    SolutionSoftware = "Small Business Server, Desktop Operating Systems, Backup Utility",
                    SolutionApp = "Office Applications",
                    SolutionNet = "SOHO Switch, ADSL Router",
                    SolutionStorage = "(Internal)"
                },
                new Proposal
                {
                    ProposalCode = 3,
                    SolutionCode = 3,
                    SolutionHardware = "2 Servers, 11-25 Desktops & Laptops, 2 Network Printers, 1 Scanner, UPS",
                    SolutionSoftware = "Small Business Server (x2), E-Mail Server, Desktop Operating Systems, Backup Utility",
                    SolutionApp = "Office Applications, ERP, CRM",
                    SolutionNet = "Switches, ADSL Router",
                    SolutionStorage = "(Internal)"
                },
                new Proposal
                {
                    ProposalCode = 4,
                    SolutionCode = 4,
                    SolutionHardware = "2 Servers, 25-50 Desktops & Laptops, 2 Network Printers, 1 Scanner, UPS",
                    SolutionSoftware = "Windows Server (x2), E-Mail Server, Desktop Operating Systems, Backup Utility",
                    SolutionApp = "Office Applications, ERP, CRM",
                    SolutionNet = "Switches, ADSL Router",
                    SolutionStorage = "Storage System"
                },
                new Proposal
                {
                    ProposalCode = 5,
                    SolutionCode = 5,
                    SolutionHardware = "3 Servers, 25-50 Desktops & Laptops, 2 Network Printers, 1 Scanner, UPS",
                    SolutionSoftware = "Windows Server (x3), E-Mail Server, Desktop Operating Systems, Backup Utility",
                    SolutionApp = "Office Applications, ERP, CRM, Custom Software Application(s)",
                    SolutionNet = "Switches, Firewall, Router",
                    SolutionStorage = "Storage System"
                },
                new Proposal
                {
                    ProposalCode = 6,
                    SolutionCode = 6,
                    SolutionHardware = "3 Servers, 50-100 Desktops & Laptops, 4 Network Printers, 2 Scanner, UPS",
                    SolutionSoftware = "Windows Server (x3), E-Mail Server, Desktop Operating Systems, Backup Utility",
                    SolutionApp = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                    SolutionNet = "Switches, Firewall, Router",
                    SolutionStorage = "Storage System"
                },
                new Proposal
                {
                    ProposalCode = 7,
                    SolutionCode = 7,
                    SolutionHardware = "4 Servers, 50-100 Desktops & Laptops, 4 Network Printers, 2 Scanner, UPS",
                    SolutionSoftware = "Windows Server (x4), E-Mail Server, Desktop Operating Systems, Backup Utility",
                    SolutionApp = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                    SolutionNet = "Switches, Firewall, Router",
                    SolutionStorage = "Storage System, Tape Library"
                },
                new Proposal
                {
                    ProposalCode = 8,
                    SolutionCode = 8,
                    SolutionHardware = "8 Servers, 100-200 Desktops & Laptops, 8 Network Printers, 4 Scanner, UPS",
                    SolutionSoftware = "Windows Server (x8), E-Mail Server, NMS, Desktop Operating Systems, Backup Utility",
                    SolutionApp = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                    SolutionNet = "Central & Workgroup Switches, Firewall, Router",
                    SolutionStorage = "Storage System, Tape Library"
                },
                new Proposal
                {
                    ProposalCode = 9,
                    SolutionCode = 9,
                    SolutionHardware = "8 Servers, 100-200 Desktops & Laptops, 8 Network Printers, 4 Scanner, UPS",
                    SolutionSoftware = "Windows Server (x8), E-Mail Server, NMS, Desktop Operating Systems, Backup Utility",
                    SolutionApp = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                    SolutionNet = "Central & Workgroup Switches, 2 Firewalls, 2 Routers",
                    SolutionStorage = "SAN Storage System, Tape Library"
                },
                new Proposal
                {
                    ProposalCode = 10,
                    SolutionCode = 10,
                    SolutionHardware =
                        "Main Site: 8 Servers, 100-200 Desktops & Laptops, 8 Network Printers, 4 Scanner, UPS & Disaster Site: 4Servers, UPS",
                    SolutionSoftware =
                        "Main Site: Windows Server (x8), E-Mail Server, NMS, Desktop Operating Systems, Backup Utility & Disaster Site: Windows Server (x4), E-Mail Servers",
                    SolutionApp = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                    SolutionNet =
                        "Main Site: Central & Workgroup Switches, 2 Firewalls, 2 Routers & Disaster Site: Central Switch, Firewall, Router",
                    SolutionStorage = "Main Site: SAN Storage System, Tape Library & Disaster Site: SAN Storage System"
                }
            }.AsQueryable();
        }
    }
}