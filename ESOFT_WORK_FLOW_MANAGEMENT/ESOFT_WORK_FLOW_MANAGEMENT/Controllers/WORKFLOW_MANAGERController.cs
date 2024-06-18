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
    public class WORKFLOW_MANAGERController : Controller
    {
        private WORK_FLOWEntities db = new WORK_FLOWEntities();

        // GET: WORKFLOW_MANAGER
        public ActionResult Index()
        {
            var wORKFLOW_MANAGER = db.WORKFLOW_MANAGER.Include(w => w.STATUS1).Include(w => w.WORK_FLOW1).Include(w => w.EMPLOYEE);
            return View(wORKFLOW_MANAGER.ToList());
        }

        // GET: WORKFLOW_MANAGER/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WORKFLOW_MANAGER wORKFLOW_MANAGER = db.WORKFLOW_MANAGER.Find(id);
            if (wORKFLOW_MANAGER == null)
            {
                return HttpNotFound();
            }
            return View(wORKFLOW_MANAGER);
        }

        // GET: WORKFLOW_MANAGER/Create
        public ActionResult Create()
        {
            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1");
            ViewBag.WORK_FLOW = new SelectList(db.WORK_FLOW, "WF_ID", "WF_NAME");
            ViewBag.MANAGER = new SelectList(db.EMPLOYEEs, "EMP_ID", "FIRST_NAME");
            return View();
        }

        // POST: WORKFLOW_MANAGER/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WB_ID,WORK_FLOW,MANAGER,STATUS,REMARK")] WORKFLOW_MANAGER wORKFLOW_MANAGER)
        {
            if (ModelState.IsValid)
            {
                db.WORKFLOW_MANAGER.Add(wORKFLOW_MANAGER);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1", wORKFLOW_MANAGER.STATUS);
            ViewBag.WORK_FLOW = new SelectList(db.WORK_FLOW, "WF_ID", "WF_NAME", wORKFLOW_MANAGER.WORK_FLOW);
            ViewBag.MANAGER = new SelectList(db.EMPLOYEEs, "EMP_ID", "FIRST_NAME", wORKFLOW_MANAGER.MANAGER);
            return View(wORKFLOW_MANAGER);
        }

        // GET: WORKFLOW_MANAGER/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WORKFLOW_MANAGER wORKFLOW_MANAGER = db.WORKFLOW_MANAGER.Find(id);
            if (wORKFLOW_MANAGER == null)
            {
                return HttpNotFound();
            }
            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1", wORKFLOW_MANAGER.STATUS);
            ViewBag.WORK_FLOW = new SelectList(db.WORK_FLOW, "WF_ID", "WF_NAME", wORKFLOW_MANAGER.WORK_FLOW);
            ViewBag.MANAGER = new SelectList(db.EMPLOYEEs, "EMP_ID", "FIRST_NAME", wORKFLOW_MANAGER.MANAGER);
            return View(wORKFLOW_MANAGER);
        }

        // POST: WORKFLOW_MANAGER/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WB_ID,WORK_FLOW,MANAGER,STATUS,REMARK")] WORKFLOW_MANAGER wORKFLOW_MANAGER)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wORKFLOW_MANAGER).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1", wORKFLOW_MANAGER.STATUS);
            ViewBag.WORK_FLOW = new SelectList(db.WORK_FLOW, "WF_ID", "WF_NAME", wORKFLOW_MANAGER.WORK_FLOW);
            ViewBag.MANAGER = new SelectList(db.EMPLOYEEs, "EMP_ID", "FIRST_NAME", wORKFLOW_MANAGER.MANAGER);
            return View(wORKFLOW_MANAGER);
        }

        // GET: WORKFLOW_MANAGER/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WORKFLOW_MANAGER wORKFLOW_MANAGER = db.WORKFLOW_MANAGER.Find(id);
            if (wORKFLOW_MANAGER == null)
            {
                return HttpNotFound();
            }
            return View(wORKFLOW_MANAGER);
        }

        // POST: WORKFLOW_MANAGER/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WORKFLOW_MANAGER wORKFLOW_MANAGER = db.WORKFLOW_MANAGER.Find(id);
            db.WORKFLOW_MANAGER.Remove(wORKFLOW_MANAGER);
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
