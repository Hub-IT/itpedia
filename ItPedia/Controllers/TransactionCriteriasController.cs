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
    public class TransactionCriteriasController : Controller
    {
        private readonly ItPediaDbContext db = new ItPediaDbContext();

        // GET: TransactionCriterion
        public ActionResult Index()
        {
            return View(db.TransactionCriteria.ToList());
        }

        // GET: TransactionCriterion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var transactionCriteria = db.TransactionCriteria.Find(id);
            if (transactionCriteria == null)
            {
                return HttpNotFound();
            }
            return View(transactionCriteria);
        }

        // GET: TransactionCriterion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionCriterion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "TransactionCriterionId,PerMonth")] TransactionCriterion transactionCriterion)
        {
            if (ModelState.IsValid)
            {
                db.TransactionCriteria.Add(transactionCriterion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transactionCriterion);
        }

        // GET: TransactionCriterion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var transactionCriteriasViewModel = new TransactionCriteriaViewModel
            {
                TransactionCriterion = db.TransactionCriteria.Find(id)
            };

            if (transactionCriteriasViewModel.TransactionCriterion == null) return HttpNotFound();

            var allIndustryCriterias = db.IndustryCriteria.ToList();
            var allEmployeeCriterias = db.EmployeeCriteria.ToList();
            var allCustomersCriterias = db.CustomerCriterias.ToList();

            transactionCriteriasViewModel.AllIndustryCriterias = allIndustryCriterias.Select(o => new SelectListItem
            {
                Text = o.Name,
                Value = o.IndustryCriterionId.ToString()
            });

            transactionCriteriasViewModel.AllEmployeeCriterias = allEmployeeCriterias.Select(o => new SelectListItem
            {
                Text = o.Size,
                Value = o.EmployeeCriterionId.ToString()
            });

            transactionCriteriasViewModel.AllCustomerCriterias = allCustomersCriterias.Select(o => new SelectListItem
            {
                Text = o.Size,
                Value = o.CustomerCriterionId.ToString()
            });

            return View(transactionCriteriasViewModel);
        }

        // POST: TransactionCriterion/Edit/5
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
                    new {id = transactionCriteriaViewModel.TransactionCriterion.TransactionCriterionId});
            }

            var transactionCriteriaToUpdate = db.TransactionCriteria
                .Include(i => i.IndustryCriteria)
                .Include(i => i.EmployeeCriteria)
                .Include(i => i.CustomerCriteria)
                .First(
                    i =>
                        i.TransactionCriterionId ==
                        transactionCriteriaViewModel.TransactionCriterion.TransactionCriterionId);

            if (!TryUpdateModel(transactionCriteriaToUpdate, "TransactionCriterion",
                new[] {"PerMonth", "IndustryCriterionId", "EmployeeCriterionId", "CustomerCriterionId"}))
                return RedirectToAction("Index");

            var updatedIndustryCriterias = new HashSet<int>(transactionCriteriaViewModel.SelectedIndustryCriterias);

            foreach (var industryCriteria in db.IndustryCriteria)
            {
                if (!updatedIndustryCriterias.Contains(industryCriteria.IndustryCriterionId))
                {
                    transactionCriteriaToUpdate.IndustryCriteria.Remove(industryCriteria);

                    continue;
                }

                transactionCriteriaToUpdate.IndustryCriteria.Add((industryCriteria));
            }

            var updatedEmployeeCriterias = new HashSet<int>(transactionCriteriaViewModel.SelectedEmployeeCriterias);

            foreach (var employeeCriteria in db.EmployeeCriteria)
            {
                if (!updatedEmployeeCriterias.Contains(employeeCriteria.EmployeeCriterionId))
                {
                    transactionCriteriaToUpdate.EmployeeCriteria.Remove(employeeCriteria);

                    continue;
                }

                transactionCriteriaToUpdate.EmployeeCriteria.Add((employeeCriteria));
            }

            var updatedCustomerCriterias= new HashSet<int>(transactionCriteriaViewModel.SelectedCustomerCriterias);

            foreach (var customerCriteria in db.CustomerCriterias)
            {
                if (!updatedCustomerCriterias.Contains(customerCriteria.CustomerCriterionId))
                {
                    transactionCriteriaToUpdate.CustomerCriteria.Remove(customerCriteria);

                    continue;
                }

                transactionCriteriaToUpdate.CustomerCriteria.Add((customerCriteria));
            }

            db.Entry(transactionCriteriaToUpdate).State = EntityState.Modified;

            db.SaveChanges();

            Flash.Success("Transaction criteria updated.");

            return RedirectToAction("Edit", new {id = transactionCriteriaToUpdate.TransactionCriterionId});
        }

        // GET: TransactionCriterion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var transactionCriteria = db.TransactionCriteria.Find(id);
            if (transactionCriteria == null)
            {
                return HttpNotFound();
            }
            return View(transactionCriteria);
        }

        // POST: TransactionCriterion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var transactionCriteria = db.TransactionCriteria.Find(id);
            db.TransactionCriteria.Remove(transactionCriteria);
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