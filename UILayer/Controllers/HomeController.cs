using BussinessLayer;
using CommonLayer;
using EntityLayer;
using EntityLayer.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UILayer.Filters;
using UILayer.Models;

namespace UILayer.Controllers
{
    [ExecutionHandle]
    public class HomeController : Controller
    {
        private UserManager userManager = new UserManager();

        [Auth]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                BusinessLayerResult<SystemUsers> res = userManager.LoginUser(model);
                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                    return View(model);
                }
                CurrentSession.Set<SystemUsers>("login", res.Result);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Auth]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        public ActionResult AccessDenied()
        {
            return View();
        }

        public ActionResult ErrorView()
        {
            return View();
        }
    }
}