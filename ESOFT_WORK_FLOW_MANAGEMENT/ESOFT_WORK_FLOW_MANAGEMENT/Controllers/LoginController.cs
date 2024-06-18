using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ESOFT_WORK_FLOW_MANAGEMENT.Models;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Controllers
{
    public class LoginController : Controller
    {
        WORK_FLOWEntities db = new WORK_FLOWEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public string GetPermission(string username,string password)
        {
            try
            {
                var user = db.EMPLOYEEs.Where(x => x.PASSWORD == password).Select(x => x.USER_NAME).FirstOrDefault();
                var pass = db.EMPLOYEEs.Where(x => x.USER_NAME == username).Select(x => x.PASSWORD).FirstOrDefault();

                if(username == user && password == pass)
                {
                    Session["usertype"] = db.EMPLOYEEs.Where(x => x.USER_NAME == username).Select(x => x).FirstOrDefault();
                    return "true";
                }
                else if(username != user && password == pass)
                {
                    return "false";
                }
                else if (username == user && password != pass)
                {
                    return "false";
                }
                else if (username != user && password != pass)
                {
                    return "false";
                }

                
            }
            catch(Exception ex)
            {
                return "Error" + ex.Message;
            }
            return "false";
        }
    }
}