using System.Web.Mvc;
using DB.Models;

namespace DB.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: Dictionary
        public ActionResult Index()
        {
            ViewBag.Terms = Models.Term.Get();

            return View();
        }

        // GET: Dictionary/Term/{id}
        public ActionResult Term(string id)
        {
            Term term;

            if (id == null || (term = Models.Term.GetByName(id)) == null)
            {
                return RedirectToAction("Index", "Dictionary");
            }

            ViewBag.Term = term;

            ViewBag.Title = term.Name;

            return View();
        }
    }
}