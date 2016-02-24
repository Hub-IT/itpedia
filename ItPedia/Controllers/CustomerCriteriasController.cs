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
    public class CustomerCriteriasController : Controller
    {
        private ItPediaDbContext db = new ItPediaDbContext();

        // GET: CustomerCriterias
        public ActionResult Index()
        {
            return View(db.CustomerCriterias.ToList());
        }

        // GET: CustomerCriterias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerCriteria customerCriteria = db.CustomerCriterias.Find(id);
            if (customerCriteria == null)
            {
                return HttpNotFound();
            }
            return View(customerCriteria);
        }

        // GET: CustomerCriterias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerCriterias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerCriteriaId,Size")] CustomerCriteria customerCriteria)
        {
            if (ModelState.IsValid)
            {
                db.CustomerCriterias.Add(customerCriteria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerCriteria);
        }

        // GET: CustomerCriterias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerCriteria customerCriteria = db.CustomerCriterias.Find(id);
            if (customerCriteria == null)
            {
                return HttpNotFound();
            }
            return View(customerCriteria);
        }

        // POST: CustomerCriterias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerCriteriaId,Size")] CustomerCriteria customerCriteria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerCriteria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerCriteria);
        }

        // GET: CustomerCriterias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerCriteria customerCriteria = db.CustomerCriterias.Find(id);
            if (customerCriteria == null)
            {
                return HttpNotFound();
            }
            return View(customerCriteria);
        }

        // POST: CustomerCriterias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerCriteria customerCriteria = db.CustomerCriterias.Find(id);
            db.CustomerCriterias.Remove(customerCriteria);
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
