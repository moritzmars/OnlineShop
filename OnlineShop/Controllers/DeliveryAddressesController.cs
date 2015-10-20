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
    public class DeliveryAddressesController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(DeliveryAddressesController).FullName);

        // GET: DeliveryAddresses/Create
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

        // POST: DeliveryAddresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Country,FirstName,LastName,OrganisationName,City,Postal,Street")] DeliveryAddress deliveryAddress)
        {
            log.Debug("public ActionResult Create(...)");
            try
            {
                if (ModelState.IsValid)
                {
                    Session["DeliveryAddress"] = deliveryAddress;
                    return RedirectToAction("Create", "BillingAddresses");
                }

                return View(deliveryAddress);
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }
        }

    }
}
