using LmycDataLib;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LmycWebSite.Controllers
{
    public class HomeController : Controller
    {
        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                try
                {
                    if (s[0].ToString() == "Admin")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.ArgumentOutOfRangeException ex)
                {
                    return false;
                }

            }
                return false;
        }

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;
                //	ApplicationDbContext context = new ApplicationDbContext();
                //	var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                //var s=	UserManager.GetRoles(user.GetUserId());
                //ViewBag.displayMenu = "No";
                Session["status"] = "member";

                if (isAdminUser())
                {
                    //ViewBag.displayMenu = "Yes";
                    Session["status"] = "admin";
                }
                return View();
            }
            else
            {
                Session["status"] = "none";
                //ViewBag.Name = "Not Logged IN";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Boat()
        {
            ViewBag.Message = "Boat page.";

            return View();
        }

        public ActionResult UandR()
        {
            ViewBag.Message = "UandR page.";

            return View();
        }
    }
}