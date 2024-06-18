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
    public class ENTITY_EMPLOYEEController : Controller
    {
        private WORK_FLOWEntities db = new WORK_FLOWEntities();

        // GET: ENTITY_EMPLOYEE
        public ActionResult Index()
        {
            var eNTITY_EMPLOYEE = db.ENTITY_EMPLOYEE.Include(e => e.ENTITY_WORK).Include(e => e.STATUS1).Include(e => e.EMPLOYEE);
            return View(eNTITY_EMPLOYEE.ToList());
        }

        // GET: ENTITY_EMPLOYEE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENTITY_EMPLOYEE eNTITY_EMPLOYEE = db.ENTITY_EMPLOYEE.Find(id);
            if (eNTITY_EMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eNTITY_EMPLOYEE);
        }

        // GET: ENTITY_EMPLOYEE/Create
        public ActionResult Create()
        {
            ViewBag.ENTITY_ID = new SelectList(db.ENTITY_WORK, "EW_WORK", "ENTITY_NAME");
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "WF"), "STATUS_ID", "STATUS1");
            ViewBag.EMP_ID = new SelectList(db.EMPLOYEEs, "EMP_ID", "FIRST_NAME");
            return View();
        }

        // POST: ENTITY_EMPLOYEE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EE_ID,ENTITY_ID,EMP_ID,STATUS,REMARK")] ENTITY_EMPLOYEE eNTITY_EMPLOYEE)
        {
            if (ModelState.IsValid)
            {
                db.ENTITY_EMPLOYEE.Add(eNTITY_EMPLOYEE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ENTITY_ID = new SelectList(db.ENTITY_WORK, "EW_WORK", "ENTITY_NAME", eNTITY_EMPLOYEE.ENTITY_ID);
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "WF"), "STATUS_ID", "STATUS1", eNTITY_EMPLOYEE.STATUS);
            ViewBag.EMP_ID = new SelectList(db.EMPLOYEEs, "EMP_ID", "FIRST_NAME", eNTITY_EMPLOYEE.EMP_ID);
            return View(eNTITY_EMPLOYEE);
        }

        // GET: ENTITY_EMPLOYEE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENTITY_EMPLOYEE eNTITY_EMPLOYEE = db.ENTITY_EMPLOYEE.Find(id);
            if (eNTITY_EMPLOYEE == null)
            {
                return HttpNotFound();
            }
            ViewBag.ENTITY_ID = new SelectList(db.ENTITY_WORK, "EW_WORK", "ENTITY_NAME", eNTITY_EMPLOYEE.ENTITY_ID);
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "WF"), "STATUS_ID", "STATUS1", eNTITY_EMPLOYEE.STATUS);
            ViewBag.EMP_ID = new SelectList(db.EMPLOYEEs, "EMP_ID", "FIRST_NAME", eNTITY_EMPLOYEE.EMP_ID);
            return View(eNTITY_EMPLOYEE);
        }

        // POST: ENTITY_EMPLOYEE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EE_ID,ENTITY_ID,EMP_ID,STATUS,REMARK")] ENTITY_EMPLOYEE eNTITY_EMPLOYEE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eNTITY_EMPLOYEE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ENTITY_ID = new SelectList(db.ENTITY_WORK, "EW_WORK", "ENTITY_NAME", eNTITY_EMPLOYEE.ENTITY_ID);
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "WF"), "STATUS_ID", "STATUS1", eNTITY_EMPLOYEE.STATUS);
            ViewBag.EMP_ID = new SelectList(db.EMPLOYEEs, "EMP_ID", "FIRST_NAME", eNTITY_EMPLOYEE.EMP_ID);
            return View(eNTITY_EMPLOYEE);
        }

        // GET: ENTITY_EMPLOYEE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENTITY_EMPLOYEE eNTITY_EMPLOYEE = db.ENTITY_EMPLOYEE.Find(id);
            if (eNTITY_EMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eNTITY_EMPLOYEE);
        }

        // POST: ENTITY_EMPLOYEE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ENTITY_EMPLOYEE eNTITY_EMPLOYEE = db.ENTITY_EMPLOYEE.Find(id);
            db.ENTITY_EMPLOYEE.Remove(eNTITY_EMPLOYEE);
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
