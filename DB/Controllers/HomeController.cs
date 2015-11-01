using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Company = GetCompanySelectList();
            ViewBag.Customer = GetCustomerSelectList();
            ViewBag.TransactionPM = GetTransactionPMSelectList();

            return View();
        }

        public SelectList GetCompanySelectList()
        {

            var companies = DB.Models.CompanyType.GetCompanyTypes();
            return new SelectList(companies.ToArray(),
                                "CT_Code",
                                "CT_Name");

        }

        public ActionResult Acknowledgment()
        {
            return View();
        }

        public ActionResult Dictionary()
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

        public SelectList GetCustomerSelectList()
        {

            var customers = DB.Models.Customer.GetCustomers();
            return new SelectList(customers.ToArray(),
                                "C_Code",
                                "C_Name");

        }

        public SelectList GetTransactionPMSelectList()
        {

            var transactions = DB.Models.TransactionPM.GetTransactionsPM();
            return new SelectList(transactions.ToArray(),
                                "T_Code",
                                "T_Name");

        }
        // ++slectlist customers, trans

        //public ActionResult Index()
        //{
        //    ViewBag.Company = GetCompanySelectList();
        //    ViewBag.Customer = GetCustomerSelectList();
        //    ViewBag.TransactionPM = GetTransactionPMSelectList();
        //    // ++viewbag customers, trans
        //    return View();
        //}


        [HttpPost]
        public ActionResult Index(string Companies, string Employees, string Customers, string Transactions)
        {

            ViewBag.Company = GetCompanySelectList();

            int EM_Code = -1;


            if (!int.TryParse(Employees, out EM_Code))
            {
                ViewBag.YouSelected = "You must select a Company Type and Number of Employees";
                return View();
            }

            var employee = from s in DB.Models.Employee.GetEmployees()
                           where s.EM_Code == EM_Code
                           select s.EM_Name;

            var company = from s in DB.Models.CompanyType.GetCompanyTypes()
                          where s.CT_Code == Companies
                          select s.CT_Name;

            var customer = from s in DB.Models.Customer.GetCustomers()
                           where s.C_Code == Customers
                           select s.C_Name;

            var transaction = from s in DB.Models.TransactionPM.GetTransactionsPM()
                              where s.T_Code == Transactions
                              select s.T_Name;

            var sol = (from s in DB.Models.Solution.GetSolutions()
                       where (s.EM_Code == EM_Code && s.CT_Code == Companies && s.C_Code == Customers && s.T_Code == Transactions)
                       select s.S_Code).FirstOrDefault();





            var test = (from p in DB.Models.Proposal.GetProposals()
                        where sol == p.S_Code
                        select p.P_Code).FirstOrDefault();

            var hardware = (from p in DB.Models.Proposal.GetProposals()
                            where sol == p.S_Code
                            select p.S_HW).FirstOrDefault();

            var software = (from p in DB.Models.Proposal.GetProposals()
                            where sol == p.S_Code
                            select p.S_SW).FirstOrDefault();

            var application = (from p in DB.Models.Proposal.GetProposals()
                               where sol == p.S_Code
                               select p.S_APP).FirstOrDefault();

            var net = (from p in DB.Models.Proposal.GetProposals()
                       where sol == p.S_Code
                       select p.S_NET).FirstOrDefault();

            var storage = (from p in DB.Models.Proposal.GetProposals()
                           where sol == p.S_Code
                           select p.S_STO).FirstOrDefault();



            //  ViewBag.YouSelected2 = "You selected " + company.SingleOrDefault() + " And " + employee.SingleOrDefault() + " The number of customers " + customer.SingleOrDefault() + " the number of Transactions per month " + transaction.SingleOrDefault() + " with Solution: " + sol.ToString();
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
            var companies = DB.Models.CompanyType.GetCompanyTypes();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(GetCompanySelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }


        public ActionResult EmployeeList(string ID)
        {
            string code = ID;

            var employees = from s in DB.Models.Employee.GetEmployees()
                            where s.CT_Code == code
                            select s;

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                                employees.ToArray(),
                                "EM_Code",
                                "EM_Name")
                           , JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }

        public ActionResult CustomerList()
        {
            var customers = DB.Models.Customer.GetCustomers();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(GetCustomerSelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }

        public ActionResult TransactionList()
        {
            var transactions = DB.Models.TransactionPM.GetTransactionsPM();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(GetTransactionPMSelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("Index");
        }
    }
}
