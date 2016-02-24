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
    public class CustomerCriteriasController : Controller
    {
        private readonly ItPediaDbContext db = new ItPediaDbContext();

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
            var customerCriteria = db.CustomerCriterias.Find(id);
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
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var customerCriteriasViewModel = new CustomerCriteriasViewModel
            {
                CustomerCriteria = db.CustomerCriterias.Find(id)
            };

            if (customerCriteriasViewModel.CustomerCriteria == null) return HttpNotFound();

            var allIndustryCriterias = db.IndustryCriterias.ToList();
            var allEmployeeCriterias = db.EmployeeCriterias.ToList();

            customerCriteriasViewModel.AllIndustryCriterias = allIndustryCriterias.Select(o => new SelectListItem
            {
                Text = o.Name,
                Value = o.IndustryCriteriaId.ToString()
            });

            customerCriteriasViewModel.AllEmployeeCriterias = allEmployeeCriterias.Select(o => new SelectListItem
            {
                Text = o.Size,
                Value = o.EmployeeCriteriaId.ToString()
            });

            return View(customerCriteriasViewModel);
        }

        // POST: CustomerCriterias/Edit/5
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
                    new {id = customerCriteriasViewModel.CustomerCriteria.CustomerCriteriaId});
            }

            var customerCriteriaToUpdate = db.CustomerCriterias
                .Include(i => i.IndustryCriterias)
                .Include(i => i.EmployeeCriterias)
                .First(i => i.CustomerCriteriaId == customerCriteriasViewModel.CustomerCriteria.CustomerCriteriaId);

            if (!TryUpdateModel(customerCriteriaToUpdate, "CustomerCriterias",
                new[] {"Size", "EmployeeCriteriaId", "IndustryCriteriaId"})) return RedirectToAction("Index");

            var updatedIndustryCriterias = new HashSet<int>(customerCriteriasViewModel.SelectedIndustryCriterias);

            foreach (var industryCriteria in db.IndustryCriterias)
            {
                if (!updatedIndustryCriterias.Contains(industryCriteria.IndustryCriteriaId))
                {
                    customerCriteriaToUpdate.IndustryCriterias.Remove(industryCriteria);

                    continue;
                }

                customerCriteriaToUpdate.IndustryCriterias.Add((industryCriteria));
            }

            var updatedEmployeeCriterias = new HashSet<int>(customerCriteriasViewModel.SelectedIndustryCriterias);

            foreach (var employeeCriteria in db.EmployeeCriterias)
            {
                if (!updatedEmployeeCriterias.Contains(employeeCriteria.EmployeeCriteriaId))
                {
                    customerCriteriaToUpdate.EmployeeCriterias.Remove(employeeCriteria);

                    continue;
                }

                customerCriteriaToUpdate.EmployeeCriterias.Add((employeeCriteria));
            }

            db.Entry(customerCriteriaToUpdate).State = EntityState.Modified;

            db.SaveChanges();

            Flash.Success("Customer criteria updated.");

            return RedirectToAction("Edit", new {id = customerCriteriaToUpdate.CustomerCriteriaId});
        }

        // GET: CustomerCriterias/Delete/5
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

        // POST: CustomerCriterias/Delete/5
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