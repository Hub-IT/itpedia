using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ItPedia.Models;

namespace ItPedia.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ItPediaDbContext>
    {
        // Industry Categories
        private const string ExportBusiness = "Export Business";
        private const string HomeBusiness = "Home Business";
        private const string Telecommunication = "Telecommunication";
        private const string Banking = "Banking";
        private const string Retail = "Retail";
        private const string Automobile = "Automobile";
        private const string Advertising = "Advertising";
        private const string Insurance = "Insurance";
        private const string Oil = "Oil";
        private const string Pharmaceutical = "Pharmaceutical";
        private const string WaterSupply = "Water Supply";
        private const string Police = "Police";
        private const string TvBroadcasting = "TV Broadcasting";
        private const string StockExchange = "Stock Exchange";
        private const string Energy = "Energy";
        private const string Transportation = "Transportation";

        // Transaction Criterias
        private const string TransactionsPerMonthUpTo100 = "Up to 100";
        private const string TransactionsPerMonthMoreThan100 = "More than 100";

        // Employees Sizes
        private const string EmployeesSizeUpTo10 = "Up to 10";
        private const string EmployeesSize11To50 = "11 - 50";
        private const string EmployeesSize51To200 = "51- 200";
        private const string EmployeesSizeNotNecessary = "Not Necessary";

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "ItPedia.Models.ItPediaDbContext";
        }

        protected override void Seed(ItPediaDbContext context)
        {
            SeedTermsTable(context);

            SeedTransactionsCriteraTable(context);

            SeedCustomerCriteriaTable(context);

//            SeedEmployeeCriteriaTable(context);
//
//            SeedIndustryCriteriaTable(context);
//
//            SeedSolutionCategoriesTable(context);
        }

        private static void SeedTransactionsCriteraTable(ItPediaDbContext context)
        {
            context.TransactionCriterias.AddOrUpdate(transactionCriteria => transactionCriteria.TransactionCriteriaId,
                new TransactionCriteria {TransactionCriteriaId = 1, PerMonth = TransactionsPerMonthUpTo100},
                new TransactionCriteria {TransactionCriteriaId = 2, PerMonth = TransactionsPerMonthMoreThan100});

            context.SaveChanges();
        }

        private static void SeedCustomerCriteriaTable(ItPediaDbContext context)
        {
            var upTo100Transaction =
                context.TransactionCriterias.First(
                    transaction => transaction.PerMonth == TransactionsPerMonthUpTo100);
            var moreThan100Transaction =
                context.TransactionCriterias.First(
                    transaction => transaction.PerMonth == TransactionsPerMonthMoreThan100);

            var transactions = new List<TransactionCriteria> {upTo100Transaction, moreThan100Transaction};

            context.CustomerCriterias.AddOrUpdate(customerCriteria => customerCriteria.CustomerCriteriaId,
                new CustomerCriteria {CustomerCriteriaId = 1, Size = "Up to 500", Transactions = transactions},
                new CustomerCriteria {CustomerCriteriaId = 2, Size = "More than 500", Transactions = transactions});

            context.SaveChanges();
        }

        private static void SeedEmployeeCriteriaTable(ItPediaDbContext context)
        {
            var customeerCriterias = context.CustomerCriterias.ToList();
            context.EmployeeCriterias.AddOrUpdate(employeeCriteria => employeeCriteria.EmployeeCriteriaId,
                GetEmployeeCriteria(1, EmployeesSizeUpTo10, customeerCriterias),
                GetEmployeeCriteria(2, EmployeesSize11To50, customeerCriterias),
                GetEmployeeCriteria(3, EmployeesSize51To200, customeerCriterias),
                GetEmployeeCriteria(4, EmployeesSizeNotNecessary, customeerCriterias)
                );
        }

        private static EmployeeCriteria GetEmployeeCriteria(int employeeCriteriaId, string size,
            List<CustomerCriteria> customerCriterias)
        {
            return new EmployeeCriteria
            {
                EmployeeCriteriaId = employeeCriteriaId,
                CustomerCriterias = customerCriterias,
                Size = size,
            };
        }

        private static void SeedSolutionCategoriesTable(ItPediaDbContext context)
        {
            context.SolutionCategories.AddOrUpdate(solutionCategory => solutionCategory.SolutionCategoryId,
                new SolutionCategory {SolutionCategoryId = 1, Name = "Hardware"},
                new SolutionCategory {Name = "Software", SolutionCategoryId = 2},
                new SolutionCategory {Name = "Applications", SolutionCategoryId = 3},
                new SolutionCategory {Name = "Networks", SolutionCategoryId = 4},
                new SolutionCategory {Name = "Storage", SolutionCategoryId = 5},
                new SolutionCategory {Name = "Fixed Costs", SolutionCategoryId = 6},
                new SolutionCategory {Name = "Recurring Costs", SolutionCategoryId = 7});
        }

        private static void SeedIndustryCriteriaTable(ItPediaDbContext context)
        {
            var homeBusinessEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSizeUpTo10)
            };
            var exportBusinessEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize11To50)
            };
            var telecommunicationEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize51To200)
            };
            var bankingEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize51To200)
            };
            var retailEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSizeUpTo10),
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize11To50)
            };
            var automobileEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSizeUpTo10),
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize11To50),
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize51To200)
            };
            var advertisingEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize11To50)
            };
            var insuranceEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize51To200)
            };
            var oilEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize51To200)
            };
            var pharmaceuticalIndustryEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize11To50),
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize51To200)
            };
            var waterSupplyIndustryEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize11To50),
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize51To200)
            };
            var policeEmployeeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(
                    employeeCriteria => employeeCriteria.Size == EmployeesSizeNotNecessary),
            };
            var tvBroadcastingCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(employeeCriteria => employeeCriteria.Size == EmployeesSize51To200),
            };
            var stockExchangeCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(
                    employeeCriteria => employeeCriteria.Size == EmployeesSizeNotNecessary),
            };
            var energyCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(
                    employeeCriteria => employeeCriteria.Size == EmployeesSizeNotNecessary),
            };
            var transportationCriterias = new List<EmployeeCriteria>
            {
                context.EmployeeCriterias.First(
                    employeeCriteria => employeeCriteria.Size == EmployeesSizeNotNecessary),
            };

            context.IndustryCriterias.AddOrUpdate(industryCriteria => industryCriteria.IndustryCriteriaId,
                GetIndustryCriteria(1, HomeBusiness, homeBusinessEmployeeCriterias),
                GetIndustryCriteria(2, ExportBusiness, exportBusinessEmployeeCriterias),
                GetIndustryCriteria(3, Telecommunication, telecommunicationEmployeeCriterias),
                GetIndustryCriteria(4, Banking, bankingEmployeeCriterias),
                GetIndustryCriteria(5, Retail, retailEmployeeCriterias),
                GetIndustryCriteria(6, Automobile, automobileEmployeeCriterias),
                GetIndustryCriteria(7, Advertising, advertisingEmployeeCriterias),
                GetIndustryCriteria(8, Insurance, insuranceEmployeeCriterias),
                GetIndustryCriteria(9, Oil, oilEmployeeCriterias),
                GetIndustryCriteria(10, Pharmaceutical, pharmaceuticalIndustryEmployeeCriterias),
                GetIndustryCriteria(11, Police, policeEmployeeCriterias),
                GetIndustryCriteria(12, TvBroadcasting, tvBroadcastingCriterias),
                GetIndustryCriteria(13, StockExchange, stockExchangeCriterias),
                GetIndustryCriteria(14, Energy, energyCriterias),
                GetIndustryCriteria(15, Transportation, transportationCriterias),
                GetIndustryCriteria(16, WaterSupply, waterSupplyIndustryEmployeeCriterias));
        }

        private static IndustryCriteria GetIndustryCriteria(int industryCriteriaId, string name,
            List<EmployeeCriteria> employeeCriterias)
        {
            return new IndustryCriteria
            {
                IndustryCriteriaId = 1,
                Name = HomeBusiness,
                EmployeeCriterias = employeeCriterias
            };
        }

        private static void SeedTermsTable(ItPediaDbContext context)
        {
            context.Terms.AddOrUpdate(term => term.TermId,
                new Term
                {
                    TermId = 1,
                    Name = "Server",
                    Source = "http://whatis.techtarget.com/definition/server",
                    Content =
                        "<p>In information technology, a server is a computer program that provides services to other computer programs (and their users) in the same or other computers.</p><p>The computer that a server program runs in is also frequently referred to as a server (though it may be used for other purposes as well).</p>In the client/server programming model, a server is a program that awaits and fulfills requests from client programs in the same or other computers. A given application in a computer may function as a client with requests for services from other programs and also as a server of requests from other programs.</p><p>Specific to the Web, a Web server is the computer program (housed in a computer) that serves requested HTML pages or files. A Web client is the requesting program associated with the user. The Web browser in your computer is a client that requests HTML files from Web servers.</p>"
                },
                new Term
                {
                    TermId = 2,
                    Name = "Desktop",
                    Source = "http://searchwindowsserver.techtarget.com/definition/desktop",
                    Content =
                        "<p>Using an office metaphor, a desktop is a computer display area that represents the kinds of objects one might find on a real desktop: documents, phonebook, telephone, reference sources, writing (and possibly drawing) tools, project folders. A desktop can be contained in a window that is part of the total display area or can be 'full - screen' (the total display area). Conceivably, you can have multiple desktops (for different projects or work environments you may have) and switch among them.<br/> In its Windows product, Microsoft provides what they call an Active Desktop. It includes representations of and access to desktop objects and also dynamic Web content as well, including integrated links to Web sites and information areas that are generated as the result of sites pushing requested information updates to the user.</p><p>Desktop is also an abbreviated form of desktop computer, a personal computer that fits on top of a desk.</p>"
                },
                new Term
                {
                    TermId = 3,
                    Name = "Printer",
                    Source = "http://whatis.techtarget.com/definition/printer",
                    Content =
                        "<p>In computers, a printer is a device that accepts text and graphic output from a computer and transfers the information to paper, usually to standard size sheets of paper. Printers are sometimes sold with computers, but more frequently are purchased separately. Printers vary in size, speed, sophistication, and cost. In general, more expensive printers are used for higher-resolution color printing.</p><p>Personal computer printers can be distinguished as impact or non-impact printers. Early impact printers worked something like an automatic typewriter, with a key striking an inked impression on paper for each printed character . The dot-matrix printer was a popular low-cost personal computer printer. It's an impact printer that strikes the paper a line at a time. The best-known non-impact printers are the inkjet printer, of which several makes of low-cost color printers are an example, and the laser printer . The inkjet sprays ink from an ink cartridge at very close range to the paper as it rolls by. The laser printer uses a laser beam reflected from a mirror to attract ink (called toner ) to selected paper areas as a sheet rolls over a drum.</p>"
                },
                new Term
                {
                    TermId = 4,
                    Name = "UPS",
                    Source = "http://searchdatacenter.techtarget.com/definition/uninterruptible-power-supply",
                    Content =
                        "<p>An uninterruptible power supply (UPS) is a device that allows a computer to keep running for at least a short time when the primary power source is lost. It also provides protection from power surges.</p><p>A UPS contains a battery that 'kicks in' when the device senses a loss of power from the primary source. If you are using the computer when the UPS notifies you of the power loss, you have time to save any data you are working on and exit gracefully before the secondary power source (the battery) runs out. When all power runs out, any data in your computer's random access memory (RAM) is erased. When power surges occur, a UPS intercepts the surge so that it doesn't damage the computer.</p>"
                },
                new Term
                {
                    TermId = 5,
                    Name = "Operating System",
                    Source = "http://whatis.techtarget.com/definition/operating-system-OS",
                    Content =
                        "<p>An operating system (sometimes abbreviated as 'OS') is the program that, after being initially loaded into the computer by a boot program, manages all the other programs in a computer. The other programs are called applications or application programs. The application programs make use of the operating system by making requests for services through a defined application program interface (API). In addition, users can interact directly with the operating system through a user interface such as a command language or a graphical user interface (GUI).</p>"
                },
                new Term
                {
                    TermId = 6,
                    Name = "MS Office 2013",
                    Source =
                        "http://searchenterprisedesktop.techtarget.com/definition/Microsoft-Office-2013-MS-Office-2013",
                    Content =
                        "<p>Microsoft Office 2013 is a suite of productivity applications includes Microsoft Word, Excel, PowerPoint, Outlook, OneNote, Publisher, Access, InfoPath and Link, along with a Visio file viewer and an optional inclusion of Project. There are several notable changes in Office 2013, including support for touch and gestures which allows Office 2013 tools to function on mobile devices such as the Microsoft Surface tablet.</p>"
                },
                new Term
                {
                    TermId = 7,
                    Name = "Switch",
                    Source = "http://searchtelecom.techtarget.com/definition/switch",
                    Content =
                        "<p>In a telecommunications network, a switch is a device that channels incoming data from any of multiple input ports to the specific output port that will take the data toward its intended destination. In the traditional circuit-switched telephone network, one or more switches are used to set up a dedicated though temporary connection or circuit for an exchange between two or more parties. On an Ethernet local area network (LAN), a switch determines from the physical device (Media Access Control or MAC) address in each incoming message frame which output port to forward it to and out of. In a wide area packet-switched network such as the Internet, a switch determines from the IP address in each packet which output port to use for the next part of its trip to the intended destination.</p>"
                },
                new Term
                {
                    TermId = 8,
                    Name = "Internal Control",
                    Source = "http://searchcompliance.techtarget.com/definition/internal-control",
                    Content =
                        "<p>An internal control is a business practice, policy or procedure that is established within an organization to create value or minimize risk.</p><p>A subset of internal controls, IT controls, are designed to ensure that the information technology (IT) within  an organization operates as intended, that data is reliable, and that the organization is in compliance with all applicable laws and regulations.</p>"
                },
                new Term
                {
                    TermId = 9,
                    Name = "Microserver",
                    Source = "http://internetofthingsagenda.techtarget.com/definition/microserver",
                    Content =
                        "<p>Microservers are less expensive and have less processing power than traditional enterprise-class rack servers. They can easily be grouped into clusters and are well-suited for tasks that do not require require multiple CPUs. They are often used by small-to medium-sized businesses that operate with minimal IT staff but they can also be useful in data centers for small or temporary jobs.</p>"
                },
                new Term
                {
                    TermId = 10,
                    Name = "Backup",
                    Source = "http://searchstorage.techtarget.com/definition/backup",
                    Content =
                        "<p>Backup is the activity of copying files or databases so that they will be preserved in case of equipment failure or other catastrophe. Backup is usually a routine part of the operation of large businesses with mainframes as well as the administrators of smaller business computers. For personal computer users, backup is also necessary but often neglected. The retrieval of files you backed up is called restoring them.</p>"
                },
                new Term
                {
                    TermId = 11,
                    Name = "Computer",
                    Source = "http://searchwindowsserver.techtarget.com/definition/computer",
                    Content =
                        "<p>A computer is a device that accepts information (in the form of digitalized data) and manipulates it for some result based on a program or sequence of instructions on how the data is to be processed. Complex computers also include the means for storing data (including the program, which is also a form of data) for some necessary duration. A program may be invariable and built into the computer (and called logic circuitry as it is on microprocessors) or different programs may be provided to the computer (loaded into its storage and then started by an administrator or user). Today's computers have both kinds of programming.</p>"
                },
                new Term
                {
                    TermId = 9,
                    Name = "Print Server",
                    Source = "http://searchwindowsserver.techtarget.com/definition/computer",
                    Content =
                        "<p>A print server is a software application, network device or computer that manages print requests and makes printer queue status information available to end users and network administrators. Print servers are used in both large enterprise and small or home office ( SOHO ) networks.</p><p>In a large organization, a single dedicated computer serving as a print server might manage hundreds of printers. In a small office, a print server is often a specialized plug-in board or small network device about the size of a hub that performs the same function as a dedicated print server, but frees up valuable disk space on the office's limited number of computers.</p>"
                },
                new Term
                {
                    TermId = 10,
                    Name = "Scanner",
                    Source = "http://whatis.techtarget.com/definition/scanner",
                    Content =
                        "<p>A scanner is a device that captures images from photographic prints, posters, magazine pages, and similar sources for computer editing and display. Scanners come in hand-held, feed-in, and flatbed types and for scanning black-and-white only, or color. Very high resolution scanners are used for scanning for high-resolution printing, but lower resolution scanners are adequate for capturing images for computer display. Scanners usually come with software, such as Adobe's Photoshop product, that lets you resize and otherwise modify a captured image.</p>"
                },
                new Term
                {
                    TermId = 11,
                    Name = "Mail Server",
                    Source = "http://searchsoa.techtarget.com/definition/mail-server",
                    Content =
                        "<p>A mail server (also known as a mail transfer agent or MTA, a mail transport agent, a mail router or an Internet mailer) is an application that receives incoming e-mail from local users (people within the same domain) and remote senders and forwards outgoing e-mail for delivery. A computer dedicated to running such applications is also called a mail server. Microsoft Exchange, qmail, Exim and sendmail are among the more common mail server programs.</p>"
                },
                new Term
                {
                    TermId = 12,
                    Name = "ERP",
                    Source = "http://searchsap.techtarget.com/definition/ERP",
                    Content =
                        "<p>Enterprise resource planning (ERP) is an industry term for the broad set of activities that helps an organization manage its business.</p><p>An important goal oF ERP is to facilitate the flow of information so business decisions can be data-driven. ERP software suites are built to collect and organize data from various levels of an organization to provide management with insight into key performance indicators (KPIs) in real time.</p>"
                },
                new Term
                {
                    TermId = 13,
                    Name = "CRM",
                    Source = "http://searchcrm.techtarget.com/definition/CRM",
                    Content =
                        "<p>CustomerCriteria relationship management (CRM) is a term that refers to practices, strategies and technologies that companies use to manage and analyze customer interactions and data throughout the customer lifecycle, with the goal of improving business relationships with customers, assisting in customer retention and driving sales growth. CRM systems are designed to compile information on customers across different channels -- or points of contact between the customer and the company -- which could include the company's website, telephone, live chat, direct mail, marketing materials and social media. CRM systems can also give customer-facing staff detailed information on customers' personal information, purchase history, buying preferences and concerns.</p>"
                },
                new Term
                {
                    TermId = 14,
                    Name = "Microsoft Windows Server 2016",
                    Source = "http://searchwindowsserver.techtarget.com/definition/Microsoft-Windows-Server-2016",
                    Content =
                        "<p>Microsoft Windows Server 2016, previously referred to as Windows Server vNext, is a server operating system (OS). The server operating system is specifically developed to serve as a platform for running networked applications.</p>"
                },
                new Term
                {
                    TermId = 15,
                    Name = "HPSS",
                    Source = "http://searchsoa.techtarget.com/definition/HPSS",
                    Content =
                        "<p>HPSS (High Performance Storage System) is a storage management system especially designed for moving large files and large amounts of data around a nework that may consist of parallel processing computers, supercomputers, and clusters of high-end workstations. HPSS is especially valuable for moving around large amounts of data for scientific and other complex applications and for moving large video files across the network.</p>"
                },
                new Term
                {
                    TermId = 16,
                    Name = "Application",
                    Source = "http://searchsoa.techtarget.com/definition/HPSS",
                    Content =
                        "<p>In information technology, an application is the use of a technology, system, or product.</p><p>The term application is a shorter form of application program. An application program is a program designed to perform a specific function directly for the user or, in some cases, for another application program. Examples of applications include word processors, database programs, Web browsers, development tools, drawing, paint, image editing programs, and communication programs. Applications use the services of the computer's operating system and other supporting applications. The formal requests and means of communicating with other programs that an application program uses is called the application program interface (API).</p>"
                },
                new Term
                {
                    TermId = 16,
                    Name = "Firewall",
                    Source = "http://searchsecurity.techtarget.com/definition/firewall",
                    Content =
                        "<p>A firewall is a network security system, either hardware- or software-based, that controls incoming and outgoing network traffic based on a set of rules.</p><p>Acting as a barrier between a trusted network and other untrusted networks -- such as the Internet -- or less-trusted networks -- such as a Retail merchant's network outside of a cardholder data environment -- a firewall controls access to the resources of a network through a positive control model. This means that the only traffic allowed onto the network defined in the firewall policy is; all other traffic is denied.</p>"
                },
                new Term
                {
                    TermId = 17,
                    Name = "Payroll Software",
                    Source = "http://searchfinancialapplications.techtarget.com/definition/payroll-software",
                    Content =
                        "<p>Payroll software is technology that aims to streamline and automate the process of paying a company's employees. Payroll software can be purchased from a human resources technology vendor or included as a module within a larger enterprise resource planning (ERP) package.</p>"
                },
                new Term
                {
                    TermId = 18,
                    Name = "HRIS",
                    Source = "http://searchfinancialapplications.techtarget.com/definition/HRIS",
                    Content =
                        "<p>A human resource information system (HRIS) is an information system or managed service that provides a single, centralized view of the data that a human resource management (HRM) or human capital management (HCM) group requires for completing human resource (HR) processes. Such processes include recruiting, applicant-tracking, payroll, time and attendance, performance appraisals, benefits administration, employees-size self-service and perhaps even accounting functions.</p>"
                },
                new Term
                {
                    TermId = 19,
                    Name = "Tape Library",
                    Source = "http://searchstorage.techtarget.com/definition/tape-library",
                    Content =
                        "<p>In data storage, a tape library is a collection of magnetic tape cartridges and tape drives. An automated tape library is a hardware device that contains multiple tape drives for reading and writing data, access ports for entering and removing tapes and a robotic device for mounting and dismounting the tape cartridges without human intervention.</p>"
                },
                new Term
                {
                    TermId = 20,
                    Name = "NMS",
                    Source = "http://whatis.techtarget.com/definition/network-management-system",
                    Content =
                        "<p>A network management system (NMS) is a set of hardware and/or software tools that allow an IT professional to supervise the individual components of a network within a larger network management framework.</p>"
                },
                new Term
                {
                    TermId = 21,
                    Name = "SAN file system",
                    Source = "http://searchstorage.techtarget.com/definition/SAN-file-system",
                    Content =
                        "<p>A SAN file system (that is, a storage area network file system) is programming that enables the sharing of the same copies of files stored on common storage media among multiple servers that may have different operating systems. Without a SAN file system, although different servers may share common storage media (using virtualization approaches), they cannot share the same files. A SAN file system simplifies and streamlines SAN management, minimizes storage and retrieval time, optimizes the use of storage resources, allows network components to be scaled individually, and eliminates the need for storage redundancy.</p>"
                },
                new Term
                {
                    TermId = 22,
                    Name = "Router",
                    Source = "http://searchnetworking.techtarget.com/definition/router",
                    Content =
                        "<p>In packet-switched networks such as the Internet, a router is a device or, in some cases, software in a computer, that determines the next network point to which a packet should be forwarded toward its destination.</p>"
                },
                new Term
                {
                    TermId = 23,
                    Name = "Client-Server Network",
                    Source = "http://searchwindowsserver.techtarget.com/definition/client-server-network",
                    Content =
                        "<p>A client-server network is a communications model in which multiple client programs share the services of a common server program.</p>"
                },
                new Term
                {
                    TermId = 24,
                    Name = "Clean Install",
                    Source = "http://searchitchannel.techtarget.com/definition/clean-install",
                    Content =
                        "<p>A clean install is a software installation in which any previous version is eradicated. The alternative to a clean install is an upgrade, in which elements of a previous version remain.</p><p>The terms are often heard in reference to operating systems. A clean installation of an operating system formats the drive and erases all existing data -- the user has to back up all data beforehand. Applications will have to be reinstalled, as well. An upgrade, sometimes referred to as an 'in-place install,' retains user data and settings.</p>"
                },
                new Term
                {
                    TermId = 24,
                    Name = "Parameterization",
                    Source = "https://www.itu.int/ITU-T/studygroups/com17/languages/X.683-0207.pdf",
                    Content = ""
                },
                new Term
                {
                    TermId = 25,
                    Name = "User training",
                    Source =
                        "http://rua.ua.es/dspace/bitstream/10045/1650/4/The_use_of_information_technology_in_training.pdf",
                    Content = ""
                },
                new Term
                {
                    TermId = 25,
                    Name = "Hostig Fees",
                    Source = "http://searchsoa.techtarget.com/definition/hosting",
                    Content =
                        "<p>Hosting (also known as Web site hosting, Web hosting, and Webhosting) is the business of housing, serving, and maintaining files for one or more Web sites. More important than the computer space that is provided for Web site files is the fast connection to the Internet. Most hosting services offer connections on T-carrier system lines. Typically, an individual business hosting its own site would require a similar connection and it would be expensive. Using a hosting service lets many companies share the cost of a fast Internet connection for serving files.</p>"
                },
                new Term
                {
                    TermId = 25,
                    Name = "Software License",
                    Source = "http://searchcio.techtarget.com/definition/software-license",
                    Content =
                        "<p>A software license is a document that provides legally binding guidelines for the use and distribution of software.</p>"
                },
                new Term
                {
                    TermId = 25,
                    Name = "Maintenance",
                    Source =
                        "http://searchhealthit.techtarget.com/definition/Maintenance-Management-Information-System-MMIS",
                    Content =
                        "<p>Maintenance Management Information System (MMIS) is a mechanized claims processing and information retrieval system for Medicaid  that's required by the federal government. All states are required to operate an MMIS to support Medicaid business functions and maintain information in such areas as provider enrollment; client eligibility, including third party liability; benefit package maintenance; managed care enrollment; claims processing; and prior authorization. A fiscal agent who is a private contractor to the state, normally selected through a competitive procurement process, may operate the state's MMIS.</p>"
                }
                );

            context.SaveChanges();
        }
    }
}