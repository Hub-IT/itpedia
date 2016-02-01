using System.Linq;
using System.Web.Mvc;
using TechConfigApp.Models;

namespace DB.Controllers
{
    public class ConfigurationController : Controller
    {
        public ActionResult NewRequest()
        {
            ViewBag.IndustrySelectList = Industry.GetIndustrySelectList();

            ViewBag.CustomerList = Customer.GetCustomerSelectList();

            ViewBag.TransactionPmList = TransactionPm.GetTransactionPmSelectList();

            return View();
        }


        [HttpPost]
        public ActionResult NewRequest(string industryCode, string employeeCode, string customerCode, string transactionCode)
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

            return RedirectToAction("NewRequest");
        }


        public ActionResult EmployeeList(string industryCode)
        {
            var employees = Employee.GetByIndustryCode(industryCode);

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                    employees.ToArray(), "Code", "Size"), JsonRequestBehavior.AllowGet);


           return RedirectToAction("NewRequest");
        }

        public ActionResult CustomerList()
        {
            if (HttpContext.Request.IsAjaxRequest())
                return Json(Customer.GetCustomerSelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("NewRequest");
        }

        public ActionResult TransactionList()
        {
            if (HttpContext.Request.IsAjaxRequest())
                return Json(TransactionPm.GetTransactionPmSelectList(), JsonRequestBehavior.AllowGet);

            return RedirectToAction("NewRequest");
        }
    }
}