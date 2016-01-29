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

            return new SelectList(companies.ToArray(), "Code", "Name");
        }

        public ActionResult Acknowledgment()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


        public SelectList GetCustomerSelectList()
        {
            var customers = Customer.GetCustomers();

            return new SelectList(customers.ToArray(), "Code", "Name");
        }

        public SelectList GetTransactionPmSelectList()
        {
            var transactions = TransactionPm.GetTransactionsPm();

            return new SelectList(transactions.ToArray(), "Code", "Name");
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


            ViewBag.Proposal = Proposal.GetBySolutionCode(solutionCode);

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