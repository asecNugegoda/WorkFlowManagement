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
    public class WORK_FLOWController : Controller
    {
        private WORK_FLOWEntities db = new WORK_FLOWEntities();

        // GET: WORK_FLOW
        public ActionResult Index()
        {
            var wORK_FLOW = db.WORK_FLOW.Include(w => w.STATUS1);
            return View(wORK_FLOW.ToList());
        }

        // GET: WORK_FLOW/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WORK_FLOW wORK_FLOW = db.WORK_FLOW.Find(id);
            if (wORK_FLOW == null)
            {
                return HttpNotFound();
            }
            return View(wORK_FLOW);
        }

        // GET: WORK_FLOW/Create
        public ActionResult Create()
        {
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "WF"), "STATUS_ID", "STATUS1");
            return View();
        }

        // POST: WORK_FLOW/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WF_ID,WF_NAME,STATUS,CREATE_DATE,END_DATE")] WORK_FLOW wORK_FLOW)
        {
            if (ModelState.IsValid)
            {
                db.WORK_FLOW.Add(wORK_FLOW);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "WF"), "STATUS_ID", "STATUS1", wORK_FLOW.STATUS);
            return View(wORK_FLOW);
        }

        // GET: WORK_FLOW/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WORK_FLOW wORK_FLOW = db.WORK_FLOW.Find(id);
            if (wORK_FLOW == null)
            {
                return HttpNotFound();
            }
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "WF"), "STATUS_ID", "STATUS1", wORK_FLOW.STATUS);
            return View(wORK_FLOW);
        }

        // POST: WORK_FLOW/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WF_ID,WF_NAME,STATUS,CREATE_DATE,END_DATE")] WORK_FLOW wORK_FLOW)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wORK_FLOW).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "WF"), "STATUS_ID", "STATUS1", wORK_FLOW.STATUS);
            return View(wORK_FLOW);
        }

        // GET: WORK_FLOW/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WORK_FLOW wORK_FLOW = db.WORK_FLOW.Find(id);
            if (wORK_FLOW == null)
            {
                return HttpNotFound();
            }
            return View(wORK_FLOW);
        }

        // POST: WORK_FLOW/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WORK_FLOW wORK_FLOW = db.WORK_FLOW.Find(id);
            db.WORK_FLOW.Remove(wORK_FLOW);
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
