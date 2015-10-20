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
    public class PaymentInformationsController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(PaymentInformationsController).FullName);

        // GET: PaymentInformations/Create
        public ActionResult Create()
        {
            log.Debug("public JsonResult GetStockCount(int? id)");
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

        // POST: PaymentInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CreditCartOwner,CreditCardNumber,ExpirationDate")] PaymentInformation paymentInformation)
        {
            log.Debug(" public ActionResult Create(...)");

            try
            {
                if (ModelState.IsValid)
                {
                    Session["PaymentInformation"] = paymentInformation;
                    return RedirectToAction("Create", "Orders");
                }

                return View(paymentInformation);
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }
        }

    }
}
