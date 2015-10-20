using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
using OnlineShop.DataAccess;
using log4net;

namespace OnlineShop
{
    public class OrdersController : BaseController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(OrdersController).FullName);

        // GET: OrdersController2/Create
        public ActionResult Create()
        {
            log.Debug("public ActionResult Create()");

            try
            {
                if ((ShoppingCart)Session["UserShoppinCart"] == null)
                    return null;
                Order order = new Order();
                order.BillingAddress = (BillingAddress)Session["BillingAddress"];
                order.DeliveryAddress = (DeliveryAddress)Session["DeliveryAddress"];
                order.PaymentInformation = (PaymentInformation)Session["PaymentInformation"];

                ShoppingCart shoppingCart = (ShoppingCart)Session["UserShoppinCart"];
                order.ProductsCount = shoppingCart.ProductsCount;
                order.Sum = shoppingCart.Sum;

                return View(order);
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaymentInformation,DeliveryAddress,BillingAddress")] Order order)
        {
            log.Debug("public ActionResult Create(...)");

            try
            {
                if (ModelState.IsValid)
                {
                    ShoppingCart shoppingCart;

                    if (Session["UserShoppinCart"] != null)
                    {
                        shoppingCart = (ShoppingCart)Session["UserShoppinCart"];
                        order.BillingAddress = (BillingAddress)Session["BillingAddress"];
                        order.DeliveryAddress = (DeliveryAddress)Session["DeliveryAddress"];
                        order.PaymentInformation = (PaymentInformation)Session["PaymentInformation"];
                        order.ProductsCount = shoppingCart.ProductsCount;
                        order.Sum = shoppingCart.Sum;
                        order.Products = shoppingCart.Producta;

                    }
                    using (db = DatabaseContextFactory.CreateDatabaseContext())
                    {
                        foreach (Product product in order.Products)
                        {
                            db.Products.Attach(product);
                            db.Products.Single(p => p.ID == product.ID).StockCount--;
                        }
                        db.Orders.Add(order);
                        db.SaveChanges();
                    }

                    Session["UserShoppinCart"] = null;
                    Session["BillingAddress"] = null;
                    Session["DeliveryAddress"] = null;
                    Session["PaymentInformation"] = null;

                    return RedirectToAction("Index", "Products");
                }

                return View(order);
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }

        }

    }
}
