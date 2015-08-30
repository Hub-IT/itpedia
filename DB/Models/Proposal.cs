using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Models
{
    public class Proposal
    {
        public int P_Code { get; set; }
        public int S_Code { get; set; }
        public string S_HW { get; set; }
        public string S_SW { get; set; }
        public string S_APP { get; set; }
        public string S_NET { get; set; }
        public string S_STO { get; set; }

        public static IQueryable<Proposal> GetProposals()
        {

            return new List<Proposal> {
                new Proposal {
                            P_Code = 1,
                            S_Code = 1,
                            S_HW = "1-3 Desktop, 1 Printer, UPS",
                            S_SW = "Desktop Operating System",
                            S_APP = "Office Applications",
                            S_NET = "SOHO Switch, ADSL Router",
                            S_STO = "(Internal)"
                        },

                        new Proposal {
                            P_Code = 2,
                            S_Code = 2,
                            S_HW = "1 Server, 4-10 Desktop, 1 Printer, UPS",
                            S_SW = "Small Business Server, Desktop Operating Systems, Backup Utility",
                            S_APP = "Office Applications",
                            S_NET = "SOHO Switch, ADSL Router",
                            S_STO = "(Internal)"
                        },

                        new Proposal {
                            P_Code = 3,
                            S_Code = 3,
                            S_HW = "2 Servers, 11-25 Desktops & Laptops, 2 Network Printers, 1 Scanner, UPS",
                            S_SW = "Small Business Server (x2), E-Mail Server, Desktop Operating Systems, Backup Utility",
                            S_APP = "Office Applications, ERP, CRM",
                            S_NET = "Switches, ADSL Router",
                            S_STO = "(Internal)"
                        },


                        new Proposal {
                            P_Code = 4,
                            S_Code = 4,
                            S_HW = "2 Servers, 25-50 Desktops & Laptops, 2 Network Printers, 1 Scanner, UPS",
                            S_SW = "Windows Server (x2), E-Mail Server, Desktop Operating Systems, Backup Utility",
                            S_APP = "Office Applications, ERP, CRM",
                            S_NET = "Switches, ADSL Router",
                            S_STO = "Storage System"
                        },


                        new Proposal {
                            P_Code = 5,
                            S_Code = 5,
                            S_HW = "3 Servers, 25-50 Desktops & Laptops, 2 Network Printers, 1 Scanner, UPS",
                            S_SW = "Windows Server (x3), E-Mail Server, Desktop Operating Systems, Backup Utility",
                            S_APP = "Office Applications, ERP, CRM, Custom Software Application(s)",
                            S_NET = "Switches, Firewall, Router",
                            S_STO = "Storage System"
                        },

                        new Proposal {
                            P_Code = 6,
                            S_Code = 6,
                            S_HW = "3 Servers, 50-100 Desktops & Laptops, 4 Network Printers, 2 Scanner, UPS",
                            S_SW = "Windows Server (x3), E-Mail Server, Desktop Operating Systems, Backup Utility",
                            S_APP = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                            S_NET = "Switches, Firewall, Router",
                            S_STO = "Storage System"
                        },

                        new Proposal {
                            P_Code = 7,
                            S_Code = 7,
                            S_HW = "4 Servers, 50-100 Desktops & Laptops, 4 Network Printers, 2 Scanner, UPS",
                            S_SW = "Windows Server (x4), E-Mail Server, Desktop Operating Systems, Backup Utility",
                            S_APP = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                            S_NET = "Switches, Firewall, Router",
                            S_STO = "Storage System, Tape Library"
                        },

                        new Proposal {
                            P_Code = 8,
                            S_Code = 8,
                            S_HW = "8 Servers, 100-200 Desktops & Laptops, 8 Network Printers, 4 Scanner, UPS",
                            S_SW = "Windows Server (x8), E-Mail Server, NMS, Desktop Operating Systems, Backup Utility",
                            S_APP = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                            S_NET = "Central & Workgroup Switches, Firewall, Router",
                            S_STO = "Storage System, Tape Library"
                        },


                        new Proposal {
                            P_Code = 9,
                            S_Code = 9,
                            S_HW = "8 Servers, 100-200 Desktops & Laptops, 8 Network Printers, 4 Scanner, UPS",
                            S_SW = "Windows Server (x8), E-Mail Server, NMS, Desktop Operating Systems, Backup Utility",
                            S_APP = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                            S_NET = "Central & Workgroup Switches, 2 Firewalls, 2 Routers",
                            S_STO = "SAN Storage System, Tape Library"
                        },

                        new Proposal {
                            P_Code = 10,
                            S_Code = 10,
                            S_HW = "Main Site: 8 Servers, 100-200 Desktops & Laptops, 8 Network Printers, 4 Scanner, UPS & Disaster Site: 4Servers, UPS",
                            S_SW = "Main Site: Windows Server (x8), E-Mail Server, NMS, Desktop Operating Systems, Backup Utility & Disaster Site: Windows Server (x4), E-Mail Servers",
                            S_APP = "Office Applications, ERP, CRM, Payroll, HR System, Custom Software Application(s)",
                            S_NET = "Main Site: Central & Workgroup Switches, 2 Firewalls, 2 Routers & Disaster Site: Central Sqitch, Firewall, Router",
                            S_STO = "Main Site: SAN Storage System, Tape Library & Disaster Site: SAN Storage System"
                        }                
             }.AsQueryable();
        }
    }
}