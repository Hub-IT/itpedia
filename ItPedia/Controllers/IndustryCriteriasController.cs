using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ItPedia.Models;
using ItPedia.Models.Contexts;

namespace ItPedia.Controllers
{
    public class IndustryCriteriasController : Controller
    {
        private ItPediaDbContext db = new ItPediaDbContext();

        // GET: IndustryCriteria
        public ActionResult Index()
        {
            return View(db.IndustryCriteria.ToList());
        }

        // GET: IndustryCriteria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryCriterion industryCriterion = db.IndustryCriteria.Find(id);
            if (industryCriterion == null)
            {
                return HttpNotFound();
            }
            return View(industryCriterion);
        }

        // GET: IndustryCriteria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IndustryCriteria/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IndustryCriterionId,Name")] IndustryCriterion industryCriterion)
        {
            if (ModelState.IsValid)
            {
                db.IndustryCriteria.Add(industryCriterion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(industryCriterion);
        }

        // GET: IndustryCriteria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryCriterion industryCriterion = db.IndustryCriteria.Find(id);
            if (industryCriterion == null)
            {
                return HttpNotFound();
            }
            return View(industryCriterion);
        }

        // POST: IndustryCriteria/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IndustryCriterionId,Name")] IndustryCriterion industryCriterion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(industryCriterion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(industryCriterion);
        }

        // GET: IndustryCriteria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryCriterion industryCriterion = db.IndustryCriteria.Find(id);
            if (industryCriterion == null)
            {
                return HttpNotFound();
            }
            return View(industryCriterion);
        }

        // POST: IndustryCriteria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IndustryCriterion industryCriterion = db.IndustryCriteria.Find(id);
            db.IndustryCriteria.Remove(industryCriterion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
