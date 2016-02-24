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
    public class TransactionCriteriasController : Controller
    {
        private readonly ItPediaDbContext db = new ItPediaDbContext();

        // GET: TransactionCriterias
        public ActionResult Index()
        {
            return View(db.TransactionCriterias.ToList());
        }

        // GET: TransactionCriterias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var transactionCriteria = db.TransactionCriterias.Find(id);
            if (transactionCriteria == null)
            {
                return HttpNotFound();
            }
            return View(transactionCriteria);
        }

        // GET: TransactionCriterias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionCriterias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "TransactionCriteriaId,PerMonth")] TransactionCriteria transactionCriteria)
        {
            if (ModelState.IsValid)
            {
                db.TransactionCriterias.Add(transactionCriteria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transactionCriteria);
        }

        // GET: TransactionCriterias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var transactionCriteriasViewModel = new TransactionCriteriaViewModel
            {
                TransactionCriteria = db.TransactionCriterias.Find(id)
            };

            if (transactionCriteriasViewModel.TransactionCriteria == null) return HttpNotFound();

            var allIndustryCriterias = db.IndustryCriterias.ToList();
            var allEmployeeCriterias = db.EmployeeCriterias.ToList();
            var allCustomersCriterias = db.CustomerCriterias.ToList();

            transactionCriteriasViewModel.AllIndustryCriterias = allIndustryCriterias.Select(o => new SelectListItem
            {
                Text = o.Name,
                Value = o.IndustryCriteriaId.ToString()
            });

            transactionCriteriasViewModel.AllEmployeeCriterias = allEmployeeCriterias.Select(o => new SelectListItem
            {
                Text = o.Size,
                Value = o.EmployeeCriteriaId.ToString()
            });

            transactionCriteriasViewModel.AllCustomerCriterias = allCustomersCriterias.Select(o => new SelectListItem
            {
                Text = o.Size,
                Value = o.CustomerCriteriaId.ToString()
            });

            return View(transactionCriteriasViewModel);
        }

        // POST: TransactionCriterias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            TransactionCriteriaViewModel transactionCriteriaViewModel)
        {
            if (transactionCriteriaViewModel == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            if (!ModelState.IsValid)
            {
                Flash.Error("Validation errors occured.");

                RedirectToAction("Edit",
                    new {id = transactionCriteriaViewModel.TransactionCriteria.TransactionCriteriaId});
            }

            var transactionCriteriaToUpdate = db.TransactionCriterias
                .Include(i => i.IndustryCriterias)
                .Include(i => i.EmployeeCriterias)
                .Include(i => i.CustomerCriterias)
                .First(
                    i =>
                        i.TransactionCriteriaId ==
                        transactionCriteriaViewModel.TransactionCriteria.TransactionCriteriaId);

            if (!TryUpdateModel(transactionCriteriaToUpdate, "TransactionCriteria",
                new[] {"PerMonth", "IndustryCriteriaId", "EmployeeCriteriaId", "CustomerCriteriaId"}))
                return RedirectToAction("Index");

            var updatedIndustryCriterias = new HashSet<int>(transactionCriteriaViewModel.SelectedIndustryCriterias);

            foreach (var industryCriteria in db.IndustryCriterias)
            {
                if (!updatedIndustryCriterias.Contains(industryCriteria.IndustryCriteriaId))
                {
                    transactionCriteriaToUpdate.IndustryCriterias.Remove(industryCriteria);

                    continue;
                }

                transactionCriteriaToUpdate.IndustryCriterias.Add((industryCriteria));
            }

            var updatedEmployeeCriterias = new HashSet<int>(transactionCriteriaViewModel.SelectedEmployeeCriterias);

            foreach (var employeeCriteria in db.EmployeeCriterias)
            {
                if (!updatedEmployeeCriterias.Contains(employeeCriteria.EmployeeCriteriaId))
                {
                    transactionCriteriaToUpdate.EmployeeCriterias.Remove(employeeCriteria);

                    continue;
                }

                transactionCriteriaToUpdate.EmployeeCriterias.Add((employeeCriteria));
            }

            var updatedCustomerCriterias= new HashSet<int>(transactionCriteriaViewModel.SelectedCustomerCriterias);

            foreach (var customerCriteria in db.CustomerCriterias)
            {
                if (!updatedCustomerCriterias.Contains(customerCriteria.CustomerCriteriaId))
                {
                    transactionCriteriaToUpdate.CustomerCriterias.Remove(customerCriteria);

                    continue;
                }

                transactionCriteriaToUpdate.CustomerCriterias.Add((customerCriteria));
            }

            db.Entry(transactionCriteriaToUpdate).State = EntityState.Modified;

            db.SaveChanges();

            Flash.Success("Transaction criteria updated.");

            return RedirectToAction("Edit", new {id = transactionCriteriaToUpdate.TransactionCriteriaId});
        }

        // GET: TransactionCriterias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var transactionCriteria = db.TransactionCriterias.Find(id);
            if (transactionCriteria == null)
            {
                return HttpNotFound();
            }
            return View(transactionCriteria);
        }

        // POST: TransactionCriterias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var transactionCriteria = db.TransactionCriterias.Find(id);
            db.TransactionCriterias.Remove(transactionCriteria);
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