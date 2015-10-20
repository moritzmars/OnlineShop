using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineShop.DataAccess;
using OnlineShop.Models;
using log4net;

namespace OnlineShop
{
    public class BillingAddressesController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BillingAddressesController).FullName);

        // GET: BillingAddresses/Create
        public ActionResult Create()
        {
            log.Debug("public ActionResult Create()");
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }
        }

        // POST: BillingAddresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Country,FirstName,LastName,OrganisationName,City,Postal,Street")] BillingAddress billingAddress)
        {
            log.Debug(" public ActionResult Create(...)");

            try
            {
                if (ModelState.IsValid)
                {
                    Session["BillingAddress"] = billingAddress;
                    return RedirectToAction("Create", "PaymentInformations");
                }

                return View(billingAddress);
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }
        }
    }
}
