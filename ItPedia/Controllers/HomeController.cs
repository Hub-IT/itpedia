using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using ItPedia.Models;
using ItPedia.Models.Contexts;
using ItPedia.ViewModels;
using static System.Int32;

namespace ItPedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ItPediaDbContext _db = new ItPediaDbContext();

        public ActionResult Index()
        {
            var model = new HomeIndexModelView.IndexViewModel
            {
                IndustryCriterias = new SelectList(_db.IndustryCriteria, "IndustryCriterionId", "Name"),
                CustomerCriterias = new SelectList(_db.CustomerCriterias, "CustomerCriterion", "Size"),
                TransactionCriterias = new SelectList(_db.TransactionCriteria, "TransactionCriterion", "PerMonth")
            };

            return View(model);
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
                "ΒΥΤΕ Computer SA is a leading Greek Information and Communications Technology (ICT) Integrator with a dynamic presence of over 30 years in the Greek ICT Market and focus on the private sector. At the same time BYTE is among the five leading ICT vendors that successfully carry out projects in the Greek public sector, which is absorbing the largest share of our national economy."
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
                {"ASP.NET MVC 5 - Web Application Framework", "http://www.asp.net/mvc/mvc5"},
                {
                    "Visual Studio Community - Integrated Development Environment",
                    "https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx"
                },
                {"Bootstrap 3 - Front-End Framework", "http://getbootstrap.com/"},
                {"OpenSource", "https://github.com/Hub-IT/itpedia"},
                {"Git - Source EmployeeCriterionId Management System", "https://git-scm.com/"},
                {"ReSharper - Visual Studio Extension for .NET Developers", "https://www.jetbrains.com/resharper/"}
            };

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetSolutions()
        {
            if (null == Request["IndustryCriterion"] || !Regex.IsMatch(Request["IndustryCriterion"], @"^\d+$")
                || null == Request["EmployeeCriteria"] || !Regex.IsMatch(Request["EmployeeCriteria"], @"^\d+$")
                || null == Request["CustomerCriterion"] || !Regex.IsMatch(Request["CustomerCriterion"], @"^\d+$")
                || null == Request["TransactionCriterion"] ||
                !Regex.IsMatch(Request["TransactionCriterion"], @"^\d+$"))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var industryCriteriaId = Parse(Request["IndustryCriterion"]);
            var employeeCriteriaId = Parse(Request["EmployeeCriteria"]);
            var customerCriteriaId = Parse(Request["CustomerCriterion"]);
            var transactionCriteriaId = Parse(Request["TransactionCriterion"]);

            Debug.WriteLine(Request["IndustryCriterion"]);
            Debug.WriteLine(Request["EmployeeCriteria"]);
            Debug.WriteLine(Request["CustomerCriterion"]);
            Debug.WriteLine(Request["TransactionCriterion"]);

            if (null == _db.EmployeeCriteria.Find(industryCriteriaId) ||
                null == _db.EmployeeCriteria.Find(employeeCriteriaId) ||
                null == _db.EmployeeCriteria.Find(customerCriteriaId) ||
                null == _db.EmployeeCriteria.Find(transactionCriteriaId))
            {
                return HttpNotFound();
            }



            var solution = _db.Solutions
                .Where(s => s.IndustryCriterionId == industryCriteriaId)
                .Where(s => s.EmployeeCriterionId == employeeCriteriaId)
                .Where(s => s.CustomerCriterionId == customerCriteriaId).
                First(s => s.TransactionCriterionId == transactionCriteriaId);

            return View("Results", solution);
        }


        public ActionResult GetEmployeeCriteriasByIndustryId(int? id)
        {
//            if (!HttpContext.Request.IsAjaxRequest() || id == null || null == _db.IndustryCriteria.Find(id))
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var results = from employeeCriteria in _db.EmployeeCriteria
                from industryCriteria in employeeCriteria.IndustryCriteria
                where (industryCriteria.IndustryCriterionId == id)
                select new {EmployeeCriteriaId = employeeCriteria.EmployeeCriterionId, employeeCriteria.Size};

            return Json(new SelectList(
                results.ToArray(), "employeeCriterias", "Size"), JsonRequestBehavior.AllowGet);
        }

        // GET: /Home/GetCustomerCriterias?industryId=&employeeId=1
        public ActionResult GetCustomerCriterias(int industryId, int employeeId)
        {
            if (!HttpContext.Request.IsAjaxRequest() || _db.IndustryCriteria.Find(industryId) == null ||
                _db.EmployeeCriteria.Find(employeeId) == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var results = from customerCriteria in _db.CustomerCriterias
                from industryCriteria in customerCriteria.IndustryCriteria
                from employeeCriteria in customerCriteria.EmployeeCriteria
                where
                    (industryCriteria.IndustryCriterionId == industryId &&
                     employeeCriteria.EmployeeCriterionId == employeeId)
                select new {CustomerCriteriaId = customerCriteria.CustomerCriterionId, customerCriteria.Size};

            return Json(new SelectList(
                results.ToArray(), "CustomerCriterion", "Size"), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetTransactionCriterias(int industryId, int employeeId, int customerId)
        {
            if (!HttpContext.Request.IsAjaxRequest() || _db.IndustryCriteria.Find(industryId) == null ||
                _db.EmployeeCriteria.Find(employeeId) == null || _db.CustomerCriterias.Find(customerId) == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var results = from transactionCriteria in _db.TransactionCriteria
                from industryCriteria in transactionCriteria.IndustryCriteria
                from employeeCriteria in transactionCriteria.EmployeeCriteria
                from customerCriteria in transactionCriteria.CustomerCriteria
                where
                    (industryCriteria.IndustryCriterionId == industryId &&
                     employeeCriteria.EmployeeCriterionId == employeeId &&
                     customerCriteria.CustomerCriterionId == customerId)
                select new {TransactionCriteriaId = transactionCriteria.TransactionCriterionId, transactionCriteria.PerMonth};

            return Json(new SelectList(
                results.ToArray(), "TransactionCriterion", "PerMonth"), JsonRequestBehavior.AllowGet);
        }
    }
}