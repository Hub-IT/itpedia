﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Xml;
using ItPedia.Models;
using ItPedia.Models.Contexts;
using ItPedia.Utilities;

namespace ItPedia.Controllers
{
    public class DictionaryController : Controller
    {
        private ItPediaDbContext db = new ItPediaDbContext();

        // GET: dictionary
        public ActionResult Index()
        {
            return View(db.Terms.ToList());
        }

        // GET: Dictionary/Term/{id}
        public ActionResult Term(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var term= db.Terms.Find(id);

            if (term == null) return HttpNotFound();

            return View(term);
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