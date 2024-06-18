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
    public class EmployeeController : Controller
    {
        private WORK_FLOWEntities db = new WORK_FLOWEntities();

        // GET: Employee
        public ActionResult Index()
        {
            
            EMPLOYEE usertype = (EMPLOYEE)Session["usertype"];
            try
            {
                var userrole = usertype.USER_ROLE.ToString();
                if (usertype.USER_ROLE.ToString() == "3")
                {
                    Response.Redirect("/Login/Index");
                }
            }
            catch (Exception)
            {
                Response.Redirect("/Login/Index");
            }
            
            var eMPLOYEEs = db.EMPLOYEEs.Include(e => e.ORGANIZATION).Include(e => e.USER_ROLE1).Include(e => e.STATUS1);
            return View(eMPLOYEEs.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            EMPLOYEE usertype = (EMPLOYEE)Session["usertype"];
            try
            {
                var userrole = usertype.USER_ROLE.ToString();
                if (usertype.USER_ROLE.ToString() == "3")
                {
                    Response.Redirect("/Login/Index");
                }
            }
            catch (Exception)
            {
                Response.Redirect("/Login/Index");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            EMPLOYEE usertype = (EMPLOYEE)Session["usertype"];
            try
            {
                var userrole = usertype.USER_ROLE.ToString();
                if (usertype.USER_ROLE.ToString() == "3")
                {
                    Response.Redirect("/Login/Index");
                }
            }
            catch (Exception)
            {
                Response.Redirect("/Login/Index");
            }
            ViewBag.ORGN_ID = new SelectList(db.ORGANIZATIONs, "ORG_ID", "ORGANIZATION1");
            ViewBag.USER_ROLE = new SelectList(db.USER_ROLE, "USER_ROLE_ID", "USER_ROLE1");
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "ROLE"), "STATUS_ID", "STATUS1");
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EMP_ID,USER_ROLE,ORGN_ID,FIRST_NAME,LAST_NAME,CONTACT,USER_NAME,PASSWORD,STATUS")] EMPLOYEE eMPLOYEE)
        {
            if (ModelState.IsValid)
            {
                db.EMPLOYEEs.Add(eMPLOYEE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ORGN_ID = new SelectList(db.ORGANIZATIONs, "ORG_ID", "ORGANIZATION1", eMPLOYEE.ORGN_ID);
            ViewBag.USER_ROLE = new SelectList(db.USER_ROLE, "USER_ROLE_ID", "USER_ROLE1", eMPLOYEE.USER_ROLE);
            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1", eMPLOYEE.STATUS);
            return View(eMPLOYEE);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            EMPLOYEE usertype = (EMPLOYEE)Session["usertype"];
            try
            {
                var userrole = usertype.USER_ROLE.ToString();
                if (usertype.USER_ROLE.ToString() == "3")
                {
                    Response.Redirect("/Login/Index");
                }
            }
            catch (Exception)
            {
                Response.Redirect("/Login/Index");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            ViewBag.ORGN_ID = new SelectList(db.ORGANIZATIONs, "ORG_ID", "ORGANIZATION1", eMPLOYEE.ORGN_ID);
            ViewBag.USER_ROLE = new SelectList(db.USER_ROLE, "USER_ROLE_ID", "USER_ROLE1", eMPLOYEE.USER_ROLE);
            ViewBag.STATUS = new SelectList(db.STATUS.Where(x => x.TYPE == "ROLE"), "STATUS_ID", "STATUS1", eMPLOYEE.STATUS);
            return View(eMPLOYEE);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMP_ID,USER_ROLE,ORGN_ID,FIRST_NAME,LAST_NAME,CONTACT,USER_NAME,PASSWORD,STATUS")] EMPLOYEE eMPLOYEE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMPLOYEE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ORGN_ID = new SelectList(db.ORGANIZATIONs, "ORG_ID", "ORGANIZATION1", eMPLOYEE.ORGN_ID);
            ViewBag.USER_ROLE = new SelectList(db.USER_ROLE, "USER_ROLE_ID", "USER_ROLE1", eMPLOYEE.USER_ROLE);
            ViewBag.STATUS = new SelectList(db.STATUS, "STATUS_ID", "STATUS1", eMPLOYEE.STATUS);
            return View(eMPLOYEE);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {

            EMPLOYEE usertype = (EMPLOYEE)Session["usertype"];
            try
            {
                var userrole = usertype.USER_ROLE.ToString();
                if (usertype.USER_ROLE.ToString() == "3")
                {
                    Response.Redirect("/Login/Index");
                }
            }
            catch (Exception)
            {
                Response.Redirect("/Login/Index");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            db.EMPLOYEEs.Remove(eMPLOYEE);
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
