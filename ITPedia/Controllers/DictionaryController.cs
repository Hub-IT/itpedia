using System.Linq;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using ITPedia.Models;
using ITPedia.Utilities;

namespace ITPedia.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: dictionary
        public ActionResult Index()
        {
            ViewBag.terms = Models.Term.Get();

            return View();
        }

        // GET: dictionary/Term/{id}
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

        public ActionResult Rss()
        {
            var terms = Models.Term.GetSyndicationList();

            var feed = new SyndicationFeed("Terms", "ITPedia", Request.Url, terms);

            return new RssResult(feed);
        }
    }
}