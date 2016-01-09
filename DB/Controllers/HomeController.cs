using System.Linq;
using System.Web.Mvc;
using DB.Models;

namespace DB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Company = GetCompanySelectList();
            ViewBag.Customer = GetCustomerSelectList();
            ViewBag.TransactionPm = GetTransactionPmSelectList();

            return View();
        }

        public SelectList GetCompanySelectList()
        {
            var companies = CompanyType.GetCompanyTypes();
            return new SelectList(companies.ToArray(),
                "Code",
                "Name");
        }

        public ActionResult Acknowledgment()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Desktop()
        {
            return View("~/Views/Home/Terms/Desktop.cshtml");
        }

        public ActionResult Server()
        {
            return View("~/Views/Home/Terms/Server.cshtml");
        }

        public ActionResult Printer()
        {
            return View("~/Views/Home/Terms/Printer.cshtml");
        }

        public ActionResult NetworkPrinter()
        {
            return View("~/Views/Home/Terms/NetworkPrinter.cshtml");
        }

        public ActionResult Scanner()
        {
            return View("~/Views/Home/Terms/Scanner.cshtml");
        }

        public ActionResult UPS()
        {
            return View("~/Views/Home/Terms/UPS.cshtml");
        }

        public ActionResult DesktopOperatingSystem()
        {
            return View("~/Views/Home/Terms/DesktopOperatingSystem.cshtml");
        }

        public ActionResult SmallBusinessServer()
        {
            return View("~/Views/Home/Terms/SmallBusinessServer.cshtml");
        }

        public ActionResult WindowsServer()
        {
            return View("~/Views/Home/Terms/WindowsServer.cshtml");
        }

        public ActionResult EmailServer()
        {
            return View("~/Views/Home/Terms/EmailServer.cshtml");
        }

        public ActionResult BackupUtility()
        {
            return View("~/Views/Home/Terms/BackupUtility.cshtml");
        }

        public ActionResult NMS()
        {
            return View("~/Views/Home/Terms/NMS.cshtml");
        }

        public ActionResult OfficeApplications()
        {
            return View("~/Views/Home/Terms/OfficeApplications.cshtml");
        }

        public ActionResult ERP()
        {
            return View("~/Views/Home/Terms/ERP.cshtml");
        }

        public ActionResult CRM()
        {
            return View("~/Views/Home/Terms/CRM.cshtml");
        }

        public ActionResult Payroll()
        {
            return View("~/Views/Home/Terms/Payroll.cshtml");
        }

        public ActionResult HRSystem()
        {
            return View("~/Views/Home/Terms/HRSystem.cshtml");
        }

        public ActionResult CustomSoftwareApplications()
        {
            return View("~/Views/Home/Terms/CustomSoftwareApplications.cshtml");
        }

        public ActionResult GeneralSwitches()
        {
            return View("~/Views/Home/Terms/GeneralSwitches.cshtml");
        }

        public ActionResult SohoSwitches()
        {
            return View("~/Views/Home/Terms/SohoSwitches.cshtml");
        }

        public ActionResult CentralWorkgroupSwitches()
        {
            return View("~/Views/Home/Terms/CentralWorkgroupSwitches.cshtml");
        }

        public ActionResult Firewall()
        {
            return View("~/Views/Home/Terms/Firewall.cshtml");
        }

        public ActionResult Router()
        {
            return View("~/Views/Home/Terms/Router.cshtml");
        }

        public ActionResult SAN()
        {
            return View("~/Views/Home/Terms/SAN.cshtml");
        }

        public ActionResult Internal()
        {
            return View("~/Views/Home/Terms/Internal.cshtml");
        }

        public ActionResult StorageSystem()
        {
            return View("~/Views/Home/Terms/StorageSystem.cshtml");
        }

        public ActionResult TapeLibrary()
        {
            return View("~/Views/Home/Terms/TapeLibrary.cshtml");
        }

        public SelectList GetCustomerSelectList()
        {
            var customers = Customer.GetCustomers();
            return new SelectList(customers.ToArray(),
                "Code",
                "Name");
        }

        public SelectList GetTransactionPmSelectList()
        {
            var transactions = TransactionPm.GetTransactionsPm();

            return new SelectList(transactions.ToArray(),
                "Code",
                "Name");
        }

        // ++slectlist customers, trans

        //public ActionResult Index()
        //{
        //    ViewBag.Company = GetCompanySelectList();
        //    ViewBag.Customer = GetCustomerSelectList();
        //    ViewBag.TransactionPm = GetTransactionPmSelectList();
        //    // ++viewbag customers, trans
        //    return View();
        //}


        [HttpPost]
        public ActionResult Index(string CompanyCode, string Employees, string Customers, string TransactionCode)
        {
            ViewBag.Company = GetCompanySelectList();

            var employeeCode = -1;


            if (!int.TryParse(Employees, out employeeCode))
            {
                ViewBag.YouSelected = "You must select a Company Type and Number of Employees";
                return View();
            }

            var employee = from employees in Employee.GetEmployees()
                where employees.Code == employeeCode
                select employees.Name;

            var company = from companies in CompanyType.GetCompanyTypes()
                where companies.Code == CompanyCode
                select companies.Name;

            var customer = from customers in Customer.GetCustomers()
                where customers.Code == Customers
                select customers.Name;

            var transaction = from transactions in TransactionPm.GetTransactionsPm()
                where transactions.Code == TransactionCode
                select transactions.Name;

            var solutionCode = (from solutions in Solution.GetSolutions()
                where
                    (solutions.EmployeeCode == employeeCode && solutions.CompanyCode == CompanyCode &&
                     solutions.C_Code == Customers && solutions.TransactionCode == TransactionCode)
                select solutions.SolutionCode).FirstOrDefault();


            var test = (from proposals in Proposal.Get()
                where solutionCode == proposals.SolutionCode
                select proposals.ProposalCode).FirstOrDefault();

            var hardware = (from hardwares in Proposal.Get()
                where solutionCode == hardwares.SolutionCode
                select hardwares.HardwareSolutions).FirstOrDefault();

            var software = (from proposals in Proposal.Get()
                where solutionCode == proposals.SolutionCode
                select proposals.SoftwareSolutions).FirstOrDefault();

            var application = (from proposals in Proposal.Get()
                where solutionCode == proposals.SolutionCode
                select proposals.AppSolutions).FirstOrDefault();

            var net = (from proposals in Proposal.Get()
                where solutionCode == proposals.SolutionCode
                select proposals.NetSolutions).FirstOrDefault();

            var storage = (from proposals in Proposal.Get()
                where solutionCode == proposals.SolutionCode
                select proposals.StorageSolutions).FirstOrDefault();


            //  ViewBag.YouSelected2 = "You selected " + company.SingleOrDefault() + " And " + employee.SingleOrDefault() + " The number of customers " + customer.SingleOrDefault() + " the number of TransactionCode per month " + transaction.SingleOrDefault() + " with Solution: " + sol.ToString();
            // ViewBag.YouSelected =  "You Selected " + sol;


            ViewBag.Hardware = hardware;
            ViewBag.Software = software;
            ViewBag.Applications = application;
            ViewBag.Network = net;
            ViewBag.Storage = storage;


            return View("Info");
        }


        public ActionResult CompanyTypeList()
        {
            var companies = CompanyType.GetCompanyTypes();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(GetCompanySelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }


        public ActionResult EmployeeList(string ID)
        {
            var code = ID;

            var employees = from s in Employee.GetEmployees()
                where s.CT_Code == code
                select s;

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                    employees.ToArray(),
                    "Code",
                    "Name")
                    , JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }

        public ActionResult CustomerList()
        {
            var customers = Customer.GetCustomers();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(GetCustomerSelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }

        public ActionResult TransactionList()
        {
            var transactions = TransactionPm.GetTransactionsPm();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(GetTransactionPmSelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }
    }
}