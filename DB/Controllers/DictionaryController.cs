using System.Web.Mvc;
using TechConfigApp.Models;

namespace DB.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: Dictionary
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dictionary/Term/{id}
        public ActionResult Term(string id)
        {
            Term term;

            if (id == null || (term = TechConfigApp.Models.Term.GetByName(id)) == null)
            {
                return RedirectToAction("Index", "Dictionary");
            }

            ViewBag.Term = term;

            ViewBag.Title = term.Name;

            return View();
        }
    }
}