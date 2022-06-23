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
    public class CustomerController : Controller
    {
        private CustomerManager customerManager = new CustomerManager();

        [AuthAdmin]
        // GET: Customer
        public ActionResult Index()
        {
            return View(customerManager.List());
        }

        [AuthAdmin]
        public ActionResult Create()
        {
            return View();
        }

        [AuthAdmin]
        [HttpPost]
        public ActionResult Create(Customers customer)
        {

            if (ModelState.IsValid)
            {
                customerManager.Insert(customer);
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        [AuthAdmin]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customers customer = customerManager.Find(x => x.CustomerID == id.Value);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [AuthAdmin]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            Customers company = customerManager.Find(x => x.CustomerID == id);
            customerManager.Delete(company);
            return RedirectToAction("Index");
        }
    }
}