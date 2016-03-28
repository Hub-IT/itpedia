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
    public class SolutionsController : Controller
    {
        private ItPediaDbContext db = new ItPediaDbContext();

        // GET: Solutions
        public ActionResult Index()
        {
            var solutions = db.Solutions.Include(s => s.CustomerCriterion).Include(s => s.EmployeeCriterion).Include(s => s.IndustryCriterion).Include(s => s.TransactionCriterion);
            return View(solutions.ToList());
        }

        // GET: Solutions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            return View(solution);
        }

        // GET: Solutions/Create
        public ActionResult Create()
        {
            ViewBag.CustomerCriteriaId = new SelectList(db.CustomerCriterias, "CustomerCriterionId", "Size");
            ViewBag.EmployeeCriteriaId = new SelectList(db.EmployeeCriteria, "EmployeeCriterionId", "Size");
            ViewBag.IndustryCriteriaId = new SelectList(db.IndustryCriteria, "IndustryCriterionId", "Name");
            ViewBag.TransactionCriteriaId = new SelectList(db.TransactionCriteria, "TransactionCriterionId", "PerMonth");
            return View();
        }

        // POST: Solutions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SolutionId,Name,IndustryCriterionId,EmployeeCriterionId,CustomerCriterionId,TransactionCriterionId")] Solution solution)
        {
            if (ModelState.IsValid)
            {
                db.Solutions.Add(solution);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerCriteriaId = new SelectList(db.CustomerCriterias, "CustomerCriterionId", "Size", solution.CustomerCriterionId);
            ViewBag.EmployeeCriteriaId = new SelectList(db.EmployeeCriteria, "EmployeeCriterionId", "Size", solution.EmployeeCriterionId);
            ViewBag.IndustryCriteriaId = new SelectList(db.IndustryCriteria, "IndustryCriterionId", "Name", solution.IndustryCriterionId);
            ViewBag.TransactionCriteriaId = new SelectList(db.TransactionCriteria, "TransactionCriterionId", "PerMonth", solution.TransactionCriterionId);
            return View(solution);
        }

        // GET: Solutions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerCriteriaId = new SelectList(db.CustomerCriterias, "CustomerCriterionId", "Size", solution.CustomerCriterionId);
            ViewBag.EmployeeCriteriaId = new SelectList(db.EmployeeCriteria, "EmployeeCriterionId", "Size", solution.EmployeeCriterionId);
            ViewBag.IndustryCriteriaId = new SelectList(db.IndustryCriteria, "IndustryCriterionId", "Name", solution.IndustryCriterionId);
            ViewBag.TransactionCriteriaId = new SelectList(db.TransactionCriteria, "TransactionCriterionId", "PerMonth", solution.TransactionCriterionId);
            return View(solution);
        }

        // POST: Solutions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SolutionId,Name,IndustryCriterionId,EmployeeCriterionId,CustomerCriterionId,TransactionCriterionId")] Solution solution)
        {
            if (ModelState.IsValid)
            {
                db.Entry(solution).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerCriteriaId = new SelectList(db.CustomerCriterias, "CustomerCriterionId", "Size", solution.CustomerCriterionId);
            ViewBag.EmployeeCriteriaId = new SelectList(db.EmployeeCriteria, "EmployeeCriterionId", "Size", solution.EmployeeCriterionId);
            ViewBag.IndustryCriteriaId = new SelectList(db.IndustryCriteria, "IndustryCriterionId", "Name", solution.IndustryCriterionId);
            ViewBag.TransactionCriteriaId = new SelectList(db.TransactionCriteria, "TransactionCriterionId", "PerMonth", solution.TransactionCriterionId);
            return View(solution);
        }

        // GET: Solutions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            return View(solution);
        }

        // POST: Solutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Solution solution = db.Solutions.Find(id);
            db.Solutions.Remove(solution);
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
