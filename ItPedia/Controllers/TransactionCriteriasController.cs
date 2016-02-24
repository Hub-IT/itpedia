using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ItPedia.Models;
using ItPedia.Models.Contexts;
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

            var transactionCriteriasViewModel = new TransactionCriteriasViewModel
            {
                TransactionCriteria = db.TransactionCriterias.Find(id)
            };

            if (transactionCriteriasViewModel.TransactionCriteria == null) return HttpNotFound();

            var allCustomerCriterias = db.CustomerCriterias.ToList();

            transactionCriteriasViewModel.AllCustomerCriterias = allCustomerCriterias.Select(o => new SelectListItem
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
//            [Bind(Include = "TransactionCriteriaId,PerMonth,SelectedCustomerCriterias")] TransactionCriteriasViewModel transactionCriteriasViewModel)
            TransactionCriteriasViewModel transactionCriteriasViewModel)
        {
            if (transactionCriteriasViewModel == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            if (!ModelState.IsValid)
            {
                // TODO: flash error message 

                RedirectToAction("Edit",
                    new {id = transactionCriteriasViewModel.TransactionCriteria.TransactionCriteriaId});
            }

            var transactionCriteriaToUpdate = db.TransactionCriterias.Include(i => i.CustomerCriterias).First(i =>
                i.TransactionCriteriaId == transactionCriteriasViewModel.TransactionCriteria.TransactionCriteriaId);

            if (!TryUpdateModel(transactionCriteriaToUpdate, "TransactionCriteria",
                new[] {"PerMonth", "TransactionCriteriaId"})) return RedirectToAction("Index");

            var newCustomerCriterias =
                db.CustomerCriterias.Where(
                    m => transactionCriteriasViewModel.SelectedCustomerCriterias.Contains(m.CustomerCriteriaId))
                    .ToList();

            var updatedCustomerCriterias = new HashSet<int>(transactionCriteriasViewModel.SelectedCustomerCriterias);

            foreach (var customerCriteria in db.CustomerCriterias)
            {
                if (!updatedCustomerCriterias.Contains(customerCriteria.CustomerCriteriaId))
                {
                    transactionCriteriaToUpdate.CustomerCriterias.Remove(customerCriteria);

                    continue;
                }

                transactionCriteriaToUpdate.CustomerCriterias.Add((customerCriteria));
            }

            db.Entry(transactionCriteriaToUpdate).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

            // TODO: flash success message

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