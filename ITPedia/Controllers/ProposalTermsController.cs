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
    public class ProposalTermsController : Controller
    {
        private ItPediaDbContext db = new ItPediaDbContext();

        // GET: ProposalTerms
        public ActionResult Index()
        {
            var proposalTerms = db.ProposalTerms.Include(p => p.Proposal).Include(p => p.Term);
            return View(proposalTerms.ToList());
        }

        // GET: ProposalTerms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProposalTerm proposalTerm = db.ProposalTerms.Find(id);
            if (proposalTerm == null)
            {
                return HttpNotFound();
            }
            return View(proposalTerm);
        }

        // GET: ProposalTerms/Create
        public ActionResult Create()
        {
            ViewBag.ProposalId = new SelectList(db.Proposals, "ProposalId", "Name");
            ViewBag.TermId = new SelectList(db.Terms, "TermId", "Name");
            return View();
        }

        // POST: ProposalTerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProposalTermId,Specification,TermId,ProposalId")] ProposalTerm proposalTerm)
        {
            if (ModelState.IsValid)
            {
                db.ProposalTerms.Add(proposalTerm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProposalId = new SelectList(db.Proposals, "ProposalId", "Name", proposalTerm.ProposalId);
            ViewBag.TermId = new SelectList(db.Terms, "TermId", "Name", proposalTerm.TermId);
            return View(proposalTerm);
        }

        // GET: ProposalTerms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProposalTerm proposalTerm = db.ProposalTerms.Find(id);
            if (proposalTerm == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProposalId = new SelectList(db.Proposals, "ProposalId", "Name", proposalTerm.ProposalId);
            ViewBag.TermId = new SelectList(db.Terms, "TermId", "Name", proposalTerm.TermId);
            return View(proposalTerm);
        }

        // POST: ProposalTerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProposalTermId,Specification,TermId,ProposalId")] ProposalTerm proposalTerm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proposalTerm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProposalId = new SelectList(db.Proposals, "ProposalId", "Name", proposalTerm.ProposalId);
            ViewBag.TermId = new SelectList(db.Terms, "TermId", "Name", proposalTerm.TermId);
            return View(proposalTerm);
        }

        // GET: ProposalTerms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProposalTerm proposalTerm = db.ProposalTerms.Find(id);
            if (proposalTerm == null)
            {
                return HttpNotFound();
            }
            return View(proposalTerm);
        }

        // POST: ProposalTerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProposalTerm proposalTerm = db.ProposalTerms.Find(id);
            db.ProposalTerms.Remove(proposalTerm);
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
