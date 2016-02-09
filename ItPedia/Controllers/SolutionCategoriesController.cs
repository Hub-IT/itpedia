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
    public class SolutionCategoriesController : Controller
    {
        private ItPediaDbContext _dbContext = new ItPediaDbContext();

        // GET: SolutionCategories
        public ActionResult Index()
        {
            return View(_dbContext.SolutionCategories.ToList());
        }

        // GET: SolutionCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolutionCategory solutionCategory = _dbContext.SolutionCategories.Find(id);
            if (solutionCategory == null)
            {
                return HttpNotFound();
            }
            return View(solutionCategory);
        }

        // GET: SolutionCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SolutionCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] SolutionCategory solutionCategory)
        {
            if (ModelState.IsValid)
            {
                _dbContext.SolutionCategories.Add(solutionCategory);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(solutionCategory);
        }

        // GET: SolutionCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolutionCategory solutionCategory = _dbContext.SolutionCategories.Find(id);
            if (solutionCategory == null)
            {
                return HttpNotFound();
            }
            return View(solutionCategory);
        }

        // POST: SolutionCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] SolutionCategory solutionCategory)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Entry(solutionCategory).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(solutionCategory);
        }

        // GET: SolutionCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolutionCategory solutionCategory = _dbContext.SolutionCategories.Find(id);
            if (solutionCategory == null)
            {
                return HttpNotFound();
            }
            return View(solutionCategory);
        }

        // POST: SolutionCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SolutionCategory solutionCategory = _dbContext.SolutionCategories.Find(id);
            _dbContext.SolutionCategories.Remove(solutionCategory);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
