using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ItPedia.Models;
using ItPedia.Models.Contexts;
using ItPedia.Utilities;
using ItPedia.ViewModels;

namespace ItPedia.Controllers
{
    public class EmployeeCriteriasController : Controller
    {
        private readonly ItPediaDbContext _db = new ItPediaDbContext();

        // GET: EmployeeCriteria
        public ActionResult Index()
        {
            return View(_db.EmployeeCriteria.ToList());
        }

        // GET: EmployeeCriteria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employeeCriteria = _db.EmployeeCriteria.Find(id);
            if (employeeCriteria == null)
            {
                return HttpNotFound();
            }
            return View(employeeCriteria);
        }

        // GET: EmployeeCriteria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeCriteria/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeCriterionId,Size")] EmployeeCriterion employeeCriterion)
        {
            if (ModelState.IsValid)
            {
                _db.EmployeeCriteria.Add(employeeCriterion);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeCriterion);
        }

        // GET: EmployeeCriteria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var employeeCriteriasViewModel = new EmployeeCriteriasViewModel
            {
                EmployeeCriterion = _db.EmployeeCriteria.Find(id)
            };

            if (employeeCriteriasViewModel.EmployeeCriterion == null) return HttpNotFound();

            var allIndustryCriterias = _db.IndustryCriteria.ToList();

            employeeCriteriasViewModel.AllIndustryCriterias = allIndustryCriterias.Select(o => new SelectListItem
            {
                Text = o.Name,
                Value = o.IndustryCriterionId.ToString()
            });

            return View(employeeCriteriasViewModel);
        }

        // POST: EmployeeCriteria/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeCriteriasViewModel employeeCriteriasViewModel)
        {
            if (employeeCriteriasViewModel == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            if (!ModelState.IsValid)
            {
                Flash.Error("Validation errors occured.");

                RedirectToAction("Edit",
                    new {id = employeeCriteriasViewModel.EmployeeCriterion.EmployeeCriterionId});
            }

            var employeeCriteriaToUpdate = _db.EmployeeCriteria.Include(i => i.IndustryCriteria).First(i =>
                i.EmployeeCriterionId == employeeCriteriasViewModel.EmployeeCriterion.EmployeeCriterionId);

            if (!TryUpdateModel(employeeCriteriaToUpdate, "EmployeeCriteria",
                new[] {"Size", "IndustryCriterionId"})) return RedirectToAction("Index");

            var updatedIndustryCriterias = new HashSet<int>(employeeCriteriasViewModel.SelectedIndustryCriterias);

            foreach (var industryCriteria in _db.IndustryCriteria)
            {
                if (!updatedIndustryCriterias.Contains(industryCriteria.IndustryCriterionId))
                {
                    employeeCriteriaToUpdate.IndustryCriteria.Remove(industryCriteria);

                    continue;
                }

                employeeCriteriaToUpdate.IndustryCriteria.Add((industryCriteria));
            }

            _db.Entry(employeeCriteriaToUpdate).State = EntityState.Modified;

            _db.SaveChanges();

            Flash.Success("Transaction criteria updated.");

            return RedirectToAction("Edit", new {id = employeeCriteriaToUpdate.EmployeeCriterionId});
        }

        // GET: EmployeeCriteria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employeeCriteria = _db.EmployeeCriteria.Find(id);
            if (employeeCriteria == null)
            {
                return HttpNotFound();
            }
            return View(employeeCriteria);
        }

        // POST: EmployeeCriteria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var employeeCriteria = _db.EmployeeCriteria.Find(id);
            _db.EmployeeCriteria.Remove(employeeCriteria);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}