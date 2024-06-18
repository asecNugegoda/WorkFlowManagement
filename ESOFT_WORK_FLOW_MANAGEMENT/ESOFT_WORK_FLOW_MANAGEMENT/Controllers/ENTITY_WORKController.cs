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
    public class ENTITY_WORKController : Controller
    {
        private WORK_FLOWEntities db = new WORK_FLOWEntities();

        // GET: ENTITY_WORK
        public ActionResult Index()
        {
            var eNTITY_WORK = db.ENTITY_WORK.Include(e => e.STATUS1).Include(e => e.WORK_FLOW);
            return View(eNTITY_WORK.ToList());
        }

        // GET: ENTITY_WORK/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENTITY_WORK eNTITY_WORK = db.ENTITY_WORK.Find(id);
            if (eNTITY_WORK == null)
            {
                return HttpNotFound();
            }
            return View(eNTITY_WORK);
        }

        // GET: ENTITY_WORK/Create
        public ActionResult Create()
        {
            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1");
            ViewBag.WF_ID = new SelectList(db.WORK_FLOW, "WF_ID", "WF_NAME");
            return View();
        }

        // POST: ENTITY_WORK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EW_WORK,WF_ID,ENTITY_NAME,REMARK,ASSIGN_DATE,END_DATE,STATUS")] ENTITY_WORK eNTITY_WORK)
        {
            if (ModelState.IsValid)
            {
                db.ENTITY_WORK.Add(eNTITY_WORK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1", eNTITY_WORK.STATUS);
            ViewBag.WF_ID = new SelectList(db.WORK_FLOW, "WF_ID", "WF_NAME", eNTITY_WORK.WF_ID);
            return View(eNTITY_WORK);
        }

        // GET: ENTITY_WORK/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENTITY_WORK eNTITY_WORK = db.ENTITY_WORK.Find(id);
            if (eNTITY_WORK == null)
            {
                return HttpNotFound();
            }
            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1", eNTITY_WORK.STATUS);
            ViewBag.WF_ID = new SelectList(db.WORK_FLOW, "WF_ID", "WF_NAME", eNTITY_WORK.WF_ID);
            return View(eNTITY_WORK);
        }

        // POST: ENTITY_WORK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EW_WORK,WF_ID,ENTITY_NAME,REMARK,ASSIGN_DATE,END_DATE,STATUS")] ENTITY_WORK eNTITY_WORK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eNTITY_WORK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1", eNTITY_WORK.STATUS);
            ViewBag.WF_ID = new SelectList(db.WORK_FLOW, "WF_ID", "WF_NAME", eNTITY_WORK.WF_ID);
            return View(eNTITY_WORK);
        }

        // GET: ENTITY_WORK/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENTITY_WORK eNTITY_WORK = db.ENTITY_WORK.Find(id);
            if (eNTITY_WORK == null)
            {
                return HttpNotFound();
            }
            return View(eNTITY_WORK);
        }

        // POST: ENTITY_WORK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ENTITY_WORK eNTITY_WORK = db.ENTITY_WORK.Find(id);
            db.ENTITY_WORK.Remove(eNTITY_WORK);
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
