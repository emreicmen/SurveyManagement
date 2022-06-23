using BussinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UILayer.Filters;

namespace UILayer.Controllers
{
    
    [Auth]
    [ExecutionHandle]
    public class CompanyController : Controller
    {

        private CompanyManager companyManager = new CompanyManager();

        [AuthAdmin]
        // GET: Companies
        public ActionResult Index()
        {
            return View(companyManager.List());
        }

        [AuthAdmin]
        public ActionResult Create()
        {
            return View();
        }

        [AuthAdmin]
        [HttpPost]
        public ActionResult Create(Companies company)
        {

            if (ModelState.IsValid)
            {
                companyManager.Insert(company);
                return RedirectToAction("Index");
            }

            return View(company);
        }

        [AuthAdmin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Companies company = companyManager.Find(x => x.CompanyID == id.Value);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        [AuthAdmin]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            Companies company = companyManager.Find(x => x.CompanyID == id);
            companyManager.Delete(company);
            return RedirectToAction("Index");
        }
    }
}