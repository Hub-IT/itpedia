using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Xml;
using ItPedia.Models;
using ItPedia.Utilities;

namespace ItPedia.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: dictionary
        public ActionResult Index()
        {
//            var terms = Models.Term.Get();
//
//            return View(terms);
            return View();
        }

        // GET: dictionary/Term/{id}
        public ActionResult Term(string id)
        {
//            Term term;
//
//            if (id == null || (term = Models.Term.GetByName(id)) == null)
//            {
//                return RedirectToAction("Index", "Dictionary");
//            }
//
//            ViewBag.Term = term;
//
//            ViewBag.Title = term.Name;
//
            return View();
        }

        public ActionResult Rss()
        {
//            var terms = Models.Term.GetSyndicationList();

//            var feed = new SyndicationFeed("Terms", "ITPedia", Request.Url, terms);

//            return new RssResult(feed);
            return HttpNotFound();
        }
    }
}