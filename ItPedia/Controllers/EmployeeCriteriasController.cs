using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ItPedia.Models;
using ItPedia.Models.Contexts;
using ItPedia.Notifications;
using ItPedia.ViewModels;

namespace ItPedia.Controllers
{
    public class EmployeeCriteriasController : Controller
    {
        private readonly ItPediaDbContext _db = new ItPediaDbContext();

        // GET: EmployeeCriterias
        public ActionResult Index()
        {
            return View(_db.EmployeeCriterias.ToList());
        }

        // GET: EmployeeCriterias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employeeCriteria = _db.EmployeeCriterias.Find(id);
            if (employeeCriteria == null)
            {
                return HttpNotFound();
            }
            return View(employeeCriteria);
        }

        // GET: EmployeeCriterias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeCriterias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeCriteriaId,Size")] EmployeeCriteria employeeCriteria)
        {
            if (ModelState.IsValid)
            {
                _db.EmployeeCriterias.Add(employeeCriteria);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeCriteria);
        }

        // GET: EmployeeCriterias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var employeeCriteriasViewModel = new EmployeeCriteriasViewModel
            {
                EmployeeCriteria = _db.EmployeeCriterias.Find(id)
            };

            if (employeeCriteriasViewModel.EmployeeCriteria == null) return HttpNotFound();

            var allIndustryCriterias = _db.IndustryCriterias.ToList();

            employeeCriteriasViewModel.AllIndustryCriterias = allIndustryCriterias.Select(o => new SelectListItem
            {
                Text = o.Name,
                Value = o.IndustryCriteriaId.ToString()
            });

            return View(employeeCriteriasViewModel);
        }

        // POST: EmployeeCriterias/Edit/5
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
                    new {id = employeeCriteriasViewModel.EmployeeCriteria.EmployeeCriteriaId});
            }

            var employeeCriteriaToUpdate = _db.EmployeeCriterias.Include(i => i.IndustryCriterias).First(i =>
                i.EmployeeCriteriaId == employeeCriteriasViewModel.EmployeeCriteria.EmployeeCriteriaId);

            if (!TryUpdateModel(employeeCriteriaToUpdate, "EmployeeCriteria",
                new[] {"Size", "IndustryCriteriaId"})) return RedirectToAction("Index");

            var updatedIndustryCriterias = new HashSet<int>(employeeCriteriasViewModel.SelectedIndustryCriterias);

            foreach (var industryCriteria in _db.IndustryCriterias)
            {
                if (!updatedIndustryCriterias.Contains(industryCriteria.IndustryCriteriaId))
                {
                    employeeCriteriaToUpdate.IndustryCriterias.Remove(industryCriteria);

                    continue;
                }

                employeeCriteriaToUpdate.IndustryCriterias.Add((industryCriteria));
            }

            _db.Entry(employeeCriteriaToUpdate).State = EntityState.Modified;

            _db.SaveChanges();

            Flash.Success("Transaction criteria updated.");

            return RedirectToAction("Edit", new {id = employeeCriteriaToUpdate.EmployeeCriteriaId});
        }

        // GET: EmployeeCriterias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employeeCriteria = _db.EmployeeCriterias.Find(id);
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
            var employeeCriteria = _db.EmployeeCriterias.Find(id);
            _db.EmployeeCriterias.Remove(employeeCriteria);
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