using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
using System.Web.Script.Serialization;
using OnlineShop.DataAccess;
using log4net;

namespace OnlineShop
{
    public class ProductsController : BaseController
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(ProductsController).FullName);
        // GET: Products
        public ActionResult Index()
        {
            log.Debug("public ActionResult Index()");

            try
            {
                using (db = DatabaseContextFactory.CreateDatabaseContext())
                {
                    return View(db.Products.ToList());
                }
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }

        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            log.Debug("public ActionResult Details(int? id)");

            using (db = DatabaseContextFactory.CreateDatabaseContext())
            {
                try
                {
                    if (id == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }
                    Product product = db.Products.Find(id);
                    if (product == null)
                    {
                        return HttpNotFound();
                    }
                    return View(product);
                }
                catch (Exception ex)
                {
                    log.Error("Exception occurred!", ex);
                    return null;
                }
            }


        }


        [HttpPost]
        public JsonResult GetStockCount(int? id)
        {
            log.Debug("public JsonResult GetStockCount(int? id)");

            try
            {
                using (db = DatabaseContextFactory.CreateDatabaseContext())
                {
                    Product product = db.Products.Find(id);
                    return Json(product.StockCount, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                log.Error("Exception occurred!", ex);
                return null;
            }

        }

    }
}
