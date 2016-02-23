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

        // GET: IndustryCriterias
        public ActionResult Index()
        {
            return View(db.IndustryCriterias.ToList());
        }

        // GET: IndustryCriterias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryCriteria industryCriteria = db.IndustryCriterias.Find(id);
            if (industryCriteria == null)
            {
                return HttpNotFound();
            }
            return View(industryCriteria);
        }

        // GET: IndustryCriterias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IndustryCriterias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IndustryCriteriaId,Name")] IndustryCriteria industryCriteria)
        {
            if (ModelState.IsValid)
            {
                db.IndustryCriterias.Add(industryCriteria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(industryCriteria);
        }

        // GET: IndustryCriterias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryCriteria industryCriteria = db.IndustryCriterias.Find(id);
            if (industryCriteria == null)
            {
                return HttpNotFound();
            }
            return View(industryCriteria);
        }

        // POST: IndustryCriterias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IndustryCriteriaId,Name")] IndustryCriteria industryCriteria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(industryCriteria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(industryCriteria);
        }

        // GET: IndustryCriterias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryCriteria industryCriteria = db.IndustryCriterias.Find(id);
            if (industryCriteria == null)
            {
                return HttpNotFound();
            }
            return View(industryCriteria);
        }

        // POST: IndustryCriterias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IndustryCriteria industryCriteria = db.IndustryCriterias.Find(id);
            db.IndustryCriterias.Remove(industryCriteria);
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
