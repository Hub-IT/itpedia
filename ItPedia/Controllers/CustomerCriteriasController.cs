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
    public class CustomerCriteriasController : Controller
    {
        private readonly ItPediaDbContext db = new ItPediaDbContext();

        // GET: CustomerCriteria
        public ActionResult Index()
        {
            return View(db.CustomerCriterias.ToList());
        }

        // GET: CustomerCriteria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var customerCriteria = db.CustomerCriterias.Find(id);
            if (customerCriteria == null)
            {
                return HttpNotFound();
            }
            return View(customerCriteria);
        }

        // GET: CustomerCriteria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerCriteria/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerCriterionId,Size")] CustomerCriterion customerCriterion)
        {
            if (ModelState.IsValid)
            {
                db.CustomerCriterias.Add(customerCriterion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerCriterion);
        }

        // GET: CustomerCriteria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var customerCriteriasViewModel = new CustomerCriteriasViewModel
            {
                CustomerCriterion = db.CustomerCriterias.Find(id)
            };

            if (customerCriteriasViewModel.CustomerCriterion == null) return HttpNotFound();

            var allIndustryCriterias = db.IndustryCriteria.ToList();
            var allEmployeeCriterias = db.EmployeeCriteria.ToList();

            customerCriteriasViewModel.AllIndustryCriterias = allIndustryCriterias.Select(o => new SelectListItem
            {
                Text = o.Name,
                Value = o.IndustryCriterionId.ToString()
            });

            customerCriteriasViewModel.AllEmployeeCriterias = allEmployeeCriterias.Select(o => new SelectListItem
            {
                Text = o.Size,
                Value = o.EmployeeCriterionId.ToString()
            });

            return View(customerCriteriasViewModel);
        }

        // POST: CustomerCriteria/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerCriteriasViewModel customerCriteriasViewModel)
        {
            if (customerCriteriasViewModel == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            if (!ModelState.IsValid)
            {
                Flash.Error("Validation errors occured.");

                RedirectToAction("Edit",
                    new {id = customerCriteriasViewModel.CustomerCriterion.CustomerCriterionId});
            }

            var customerCriteriaToUpdate = db.CustomerCriterias
                .Include(i => i.IndustryCriteria)
                .Include(i => i.EmployeeCriteria)
                .First(i => i.CustomerCriterionId == customerCriteriasViewModel.CustomerCriterion.CustomerCriterionId);

            if (!TryUpdateModel(customerCriteriaToUpdate, "CustomerCriteria",
                new[] {"Size", "EmployeeCriterionId", "IndustryCriterionId"})) return RedirectToAction("Index");

            var updatedIndustryCriterias = new HashSet<int>(customerCriteriasViewModel.SelectedIndustryCriterias);

            foreach (var industryCriteria in db.IndustryCriteria)
            {
                if (!updatedIndustryCriterias.Contains(industryCriteria.IndustryCriterionId))
                {
                    customerCriteriaToUpdate.IndustryCriteria.Remove(industryCriteria);

                    continue;
                }

                customerCriteriaToUpdate.IndustryCriteria.Add((industryCriteria));
            }

            var updatedEmployeeCriterias = new HashSet<int>(customerCriteriasViewModel.SelectedIndustryCriterias);

            foreach (var employeeCriteria in db.EmployeeCriteria)
            {
                if (!updatedEmployeeCriterias.Contains(employeeCriteria.EmployeeCriterionId))
                {
                    customerCriteriaToUpdate.EmployeeCriteria.Remove(employeeCriteria);

                    continue;
                }

                customerCriteriaToUpdate.EmployeeCriteria.Add((employeeCriteria));
            }

            db.Entry(customerCriteriaToUpdate).State = EntityState.Modified;

            db.SaveChanges();

            Flash.Success("Customer criteria updated.");

            return RedirectToAction("Edit", new {id = customerCriteriaToUpdate.CustomerCriterionId});
        }

        // GET: CustomerCriteria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var customerCriteria = db.CustomerCriterias.Find(id);
            if (customerCriteria == null)
            {
                return HttpNotFound();
            }
            return View(customerCriteria);
        }

        // POST: CustomerCriteria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var customerCriteria = db.CustomerCriterias.Find(id);
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