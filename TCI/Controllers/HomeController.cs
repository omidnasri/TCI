using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCI.Controllers
{
    public partial class HomeController : Controller
    {
        // GET: Home
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult _Alert(int? id)
        {
            return !id.HasValue ? PartialView(MVC.Home.Views.Partial._Alert, new Models.Persons() {Id = 12, Name = "omid", Family = "nasri"})
                                : PartialView(MVC.Home.Views.Partial._Alert);
        }
        [ValidateAntiForgeryToken, HttpPost]
        public virtual ActionResult Alert(TCI.Models.Persons model)
        {
            return Json(new { StatusCode = Models.HttpStatusCode.Created_Page/*برای تست*/}, JsonRequestBehavior.AllowGet);
        }
    }

    
}