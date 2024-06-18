using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ESOFT_WORK_FLOW_MANAGEMENT.Models;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Controllers
{
    public class OrganizationController : Controller
    {
        private WORK_FLOWEntities db = new WORK_FLOWEntities();

        // GET: Organization
        public ActionResult Index()
        {
            return View(db.ORGANIZATIONs.ToList());
        }

        // GET: Organization/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORGANIZATION oRGANIZATION = db.ORGANIZATIONs.Find(id);
            if (oRGANIZATION == null)
            {
                return HttpNotFound();
            }
            return View(oRGANIZATION);
        }

        // GET: Organization/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Organization/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ORG_ID,ORGANIZATION1,ADR1,ADR2,CITY,CONTATC")] ORGANIZATION oRGANIZATION)
        {
            if (ModelState.IsValid)
            {
                db.ORGANIZATIONs.Add(oRGANIZATION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oRGANIZATION);
        }

        // GET: Organization/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORGANIZATION oRGANIZATION = db.ORGANIZATIONs.Find(id);
            if (oRGANIZATION == null)
            {
                return HttpNotFound();
            }
            return View(oRGANIZATION);
        }

        // POST: Organization/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ORG_ID,ORGANIZATION1,ADR1,ADR2,CITY,CONTATC")] ORGANIZATION oRGANIZATION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oRGANIZATION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oRGANIZATION);
        }

        // GET: Organization/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORGANIZATION oRGANIZATION = db.ORGANIZATIONs.Find(id);
            if (oRGANIZATION == null)
            {
                return HttpNotFound();
            }
            return View(oRGANIZATION);
        }

        // POST: Organization/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ORGANIZATION oRGANIZATION = db.ORGANIZATIONs.Find(id);
            db.ORGANIZATIONs.Remove(oRGANIZATION);
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
