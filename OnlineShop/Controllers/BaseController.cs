using OnlineShop.DataAccess;
using System.Web.Mvc;

namespace OnlineShop
{
    public abstract class BaseController : Controller
    {
            protected DatabaseContext db { get; set; }

            protected override void Dispose(bool disposing)
            {
            if (db == null)
                return;
            db.Dispose();
                base.Dispose(disposing);
            }
       
    }
}