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
    public class ShoppingCartsController : BaseController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ShoppingCartsController).FullName);

        public ActionResult AddProductToCart(int? id)
        {
            log.Debug("public ActionResult AddProductToCart(int? id)");
            try
            {
                using (db = DatabaseContextFactory.CreateDatabaseContext())
                {        // Retrieve the album from the database
                    var productToAdd = db.Products
                    .Single(product => product.ID == id);

                    ShoppingCart shoppingCart;
                    if (Session["UserShoppinCart"] == null)
                    {
                        shoppingCart = new ShoppingCart();
                        if (shoppingCart.Producta == null)
                            shoppingCart.Producta = new List<Product>();
                        Session["UserShoppinCart"] = shoppingCart;
                    }
                    shoppingCart = (ShoppingCart)Session["UserShoppinCart"];
                    shoppingCart.Producta.Add(productToAdd);
                    shoppingCart.Sum += productToAdd.Price;
                    shoppingCart.ProductsCount++;
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }
        }

        public ActionResult RemoveProductFromCart(int? id)
        {
            log.Debug("public ActionResult RemoveProductFromCart(int? id)");

            try
            {
                ShoppingCart shoppingCart;

                if (Session["UserShoppinCart"] != null)
                {
                    shoppingCart = (ShoppingCart)Session["UserShoppinCart"];
                    var productToRemove = shoppingCart.Producta.Single(product => product.ID == id);
                    shoppingCart.Producta.Remove(productToRemove);
                    shoppingCart.Sum -= productToRemove.Price;
                    shoppingCart.ProductsCount--;
                    if (shoppingCart.ProductsCount == 0)
                        Session["UserShoppinCart"] = null;
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }
        }
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            log.Debug("public ActionResult CartSummary()");
            try
            {
                ShoppingCart shoppingCart;

                if (Session["UserShoppinCart"] != null)
                {
                    shoppingCart = (ShoppingCart)Session["UserShoppinCart"];
                    ViewData["CartCount"] = shoppingCart.Producta.Count;
                }
                else
                    ViewData["CartCount"] = 0;

                return PartialView("ShoppingCartInfo");
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }
        }
        // GET: ShoppingCarts
        public ActionResult Index()
        {
            log.Debug("public ActionResult Index()");

            try
            {
                ShoppingCart shoppingCart;
                shoppingCart = (ShoppingCart)Session["UserShoppinCart"];
                return View(shoppingCart);
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }

        }


    }
}
