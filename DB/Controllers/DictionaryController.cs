using System.Web.Mvc;

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
            return Content(id);
        }
    }
}