using BussinessLayer;
using DataAccessLayer;
using EntityLayer;
using EntityLayer.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UILayer.Filters;
using UILayer.Models;

namespace UILayer.Controllers
{
    [Auth]
    [ExecutionHandle]
    public class UserController : Controller
    {

        private UserManager userManager = new UserManager();


        [AuthAdmin]

        // GET: EvernoteUser
        public ActionResult Index()
        {

            return View(userManager.List());
        }


        [AuthAdmin]
        public ActionResult Create()
        {
            return View();
        }

        [AuthAdmin]
        [HttpPost]
        public ActionResult Create(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                BusinessLayerResult<SystemUsers> res = userManager.RegisterUser(model);
                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                    return View(model);
                }
            }
            return View("Index");
        }

        
       
        public ActionResult ProfileDetail()
        {
            BusinessLayerResult<SystemUsers> res = userManager.GetUserById(CurrentSession.User.SystemUserID);

            return View(res.Result);
        }

        [AuthAdmin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUsers user = userManager.Find(x => x.SystemUserID == id.Value);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [AuthAdmin]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            SystemUsers user = userManager.Find(x => x.SystemUserID == id);
            userManager.Delete(user);
            return RedirectToAction("Index");
        }
    }
}