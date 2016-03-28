using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using ItPedia.Models.Contexts;
using ITPedia.Utilities;

namespace ItPedia.Controllers
{
    public class DictionaryController : Controller
    {
        private readonly ItPediaDbContext _db = new ItPediaDbContext();

        // GET: dictionary
        public ActionResult Index()
        {
            return View(_db.Terms.OrderBy(x => x.Name).ToList());
        }

        // GET: Dictionary/Term/{id}
        public ActionResult Term(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var term = _db.Terms.Find(id);

            if (term == null) return HttpNotFound();

            return View(term);
        }

        public ActionResult Rss()
        {
            var terms = Models.Term.GetSyndicationList();

            var feed = new SyndicationFeed("Terms", "ITPedia", Request.Url, terms);
            return new RssResult(feed);
        }
    }
}