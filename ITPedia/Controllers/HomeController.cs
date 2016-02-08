using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DB.Models;

namespace DB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.IndustrySelectList = Industry.GetIndustrySelectList();

            ViewBag.CustomerList = Customer.GetCustomerSelectList();

            ViewBag.TransactionPmList = TransactionPm.GetTransactionPmSelectList();

            return View();
        }

        public ActionResult About()
        {

            // TODO: move these data to the model layer
            ViewBag.ObjectiveIntro =
                "The main objective of this website is to foster and develop a cooperative relationship between the academia and the Information & Communications Technology (ICT) industry in Greece.";
            ViewBag.ObjectiveDescription =
                "A synergy between DEREE CIS department and BYTE Computer has been established to develop a website to inform and advise new entrepreneurs, public and private firms interested in establishing or upgrading the IS and infrastructure of their business. CIS students have performed the requirements specification process and also developed a prototype website in the framework of the software development courses in their major program of study with content provided by Byte Computer SA. Following this, senior IT students have implemented and updated it.";

            ViewBag.StudentsWorkedTitle =
                "Students";
            ViewBag.StudentsWorkedIntro =
                "The CIS and IT students who worked for the analysis and development of the website under the supervision of Professors Manos Varouhas and Kostas Leftheriotis are:";

            ViewBag.StudentsWorked = new List<string>
            {
                "Mark Kethisouaran, CIS",
                "Gregory Kyriazis, CIS/A&F",
                "Julia Pustowoj, CIS",
                "Antony Kalogeropoulos, IT",
                "Rizart Dokollari, IT"
            };

            ViewBag.DereeCisAndByteTitle = "DEREE CIS & BYTE Computer SA";
            ViewBag.DereeCisAndByteContent = new List<string>
            {
                "The academic department of Computer Information Systems (CIS) was established in the beginning of the 1980s at DEREE offering one of the first accredited information systems programs in Greece. Today, through academic collaborations, professional partnerships with top global corporations and an expanding network of professionals we aim at exposing students to latest trends and best practices in management information systems and therefore add value to their studies.",
                "ΒΥΤΕ Computer SA is a leading Greek Information and Communications Technology (ICT) Integrator with a dynamic presence of over 30 years in the Greek ICT Market and focus on the private sector. At the same time BYTE is among the five leading ICT vendors that successfully carry out projects in the Greek public sector, which is absorbing the largest share of our national economy.",
            };


            ViewBag.ResourcePeopleTitle = "Resource People";
            ViewBag.ResourcePeople = new List<string>
            {
                "Apostolos Kapetanios, BYTE Computer",
                "Maria Vyzantiou, BYTE Computer",
                "Prof. Maira Kotsovoulou, DEREE, IT",
                "Prof. Vassia Stefanou, DEREE, CIS"
            };

            ViewBag.ToolsAndTechnologiesUsedTitle = "Tools and Technologies used";
            ViewBag.ToolsAndTechnologiesUsedItems = new Dictionary<string, string>
            {
                { "ASP.NET MVC 5 - Web Application Framework", "http://www.asp.net/mvc/mvc5"},
                { "Visual Studio Community - Integrated Development Environment", "https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx"},
                { "Bootstrap 3 - Front-End Framework", "http://getbootstrap.com/"},
                { "OpenSource", "https://github.com/Hub-IT/itpedia"},
                { "Git - Source Code Management System", "https://git-scm.com/"},
                { "ReSharper - Visual Studio Extension for .NET Developers", "https://www.jetbrains.com/resharper/"},
            };

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Results(string industryCode, string employeeCode, string customerCode,
            string transactionCode)
        {
//             TODO: replace below code with seperate functions (isValid) for each of the parameters defined in their respective models
//            if (!int.TryParse(employees, out employeeCode))
//            {
//                ViewBag.YouSelected = "You must select a Company Type and Number of employees";
//
//                return View();
//            }
//
            var solutionCode = Solution.GetSolutionCode(employeeCode, industryCode, transactionCode);

            ViewBag.Solutions = Proposal.GetBySolutionCode(solutionCode);

            return View("Results");
        }


        public ActionResult IndustriesList()
        {
            if (HttpContext.Request.IsAjaxRequest())
                return Json(Industry.GetIndustrySelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Results");
        }


        public ActionResult EmployeeList(string industryCode)
        {
            var employees = Employee.GetByIndustryCode(industryCode);

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                    employees.ToArray(), "Code", "Size"), JsonRequestBehavior.AllowGet);


            return RedirectToAction("Results");
        }

        public ActionResult CustomerList()
        {
            if (HttpContext.Request.IsAjaxRequest())
                return Json(Customer.GetCustomerSelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Results");
        }

        public ActionResult TransactionList()
        {
            if (HttpContext.Request.IsAjaxRequest())
                return Json(TransactionPm.GetTransactionPmSelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Results");
        }
    }
}