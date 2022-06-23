using BussinessLayer;
using CommonLayer;
using EntityLayer;
using EntityLayer.JunctionTables;
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
    public class PollController : Controller
    {

        private PollManager pollManager = new PollManager();

        // GET: Poll
        public ActionResult Index()
        {
            return View();
        }

        [AuthAdmin]
        public ActionResult Create()
        {
            return View();
        }

        [AuthAdmin]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Polls poll)
        {

            if (ModelState.IsValid)
            {
                pollManager.Insert(poll);
                return RedirectToAction("Index");
            }

            return View(poll);
        }

        public ActionResult ShowPollDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Polls poll = pollManager.Find(x => x.PollID == id);

            if (poll == null)
            {
                return HttpNotFound();
            }

            return PartialView("_PartialPollDetails", poll);
        }

        [AuthAdmin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Polls poll = pollManager.Find(x => x.PollID == id.Value);
            if (poll == null)
            {
                return HttpNotFound();
            }
            return View(poll);
        }

        [AuthAdmin]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            Polls poll = pollManager.Find(x => x.PollID == id);
            pollManager.Delete(poll);
            return RedirectToAction("Index");
        }
    }
}