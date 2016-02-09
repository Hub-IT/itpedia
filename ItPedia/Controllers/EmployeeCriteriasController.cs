using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ItPedia.Models;

namespace ItPedia.Controllers
{
    public class EmployeeCriteriasController : Controller
    {
        private ItPediaDbContext db = new ItPediaDbContext();

        // GET: EmployeeCriterias
        public ActionResult Index()
        {
            var employeeCriterias = db.EmployeeCriterias.Include(e => e.IndustryCriteria);
            return View(employeeCriterias.ToList());
        }

        // GET: EmployeeCriterias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCriteria employeeCriteria = db.EmployeeCriterias.Find(id);
            if (employeeCriteria == null)
            {
                return HttpNotFound();
            }
            return View(employeeCriteria);
        }

        // GET: EmployeeCriterias/Create
        public ActionResult Create()
        {
            ViewBag.IndustryCriteriaId = new SelectList(db.IndustryCriterias, "IndustryCriteriaId", "Name");
            return View();
        }

        // POST: EmployeeCriterias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeCriteriaId,PerMonth,IndustryCriteriaId")] EmployeeCriteria employeeCriteria)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeCriterias.Add(employeeCriteria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IndustryCriteriaId = new SelectList(db.IndustryCriterias, "IndustryCriteriaId", "Name", employeeCriteria.IndustryCriteriaId);
            return View(employeeCriteria);
        }

        // GET: EmployeeCriterias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCriteria employeeCriteria = db.EmployeeCriterias.Find(id);
            if (employeeCriteria == null)
            {
                return HttpNotFound();
            }
            ViewBag.IndustryCriteriaId = new SelectList(db.IndustryCriterias, "IndustryCriteriaId", "Name", employeeCriteria.IndustryCriteriaId);
            return View(employeeCriteria);
        }

        // POST: EmployeeCriterias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeCriteriaId,PerMonth,IndustryCriteriaId")] EmployeeCriteria employeeCriteria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeCriteria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IndustryCriteriaId = new SelectList(db.IndustryCriterias, "IndustryCriteriaId", "Name", employeeCriteria.IndustryCriteriaId);
            return View(employeeCriteria);
        }

        // GET: EmployeeCriterias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCriteria employeeCriteria = db.EmployeeCriterias.Find(id);
            if (employeeCriteria == null)
            {
                return HttpNotFound();
            }
            return View(employeeCriteria);
        }

        // POST: EmployeeCriterias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeCriteria employeeCriteria = db.EmployeeCriterias.Find(id);
            db.EmployeeCriterias.Remove(employeeCriteria);
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
