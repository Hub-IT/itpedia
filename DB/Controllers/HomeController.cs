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
            // ++viewbag customers, trans
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
            string Code = ID;
            var employees = from s in DB.Models.Employee.GetEmployees()
                            where s.CT_Code == Code
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
