using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4FormsAuth.Web.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            //var test = System.Web.HttpContext.Current.Request.ServerVariables["SERVER_PROTOCOL"].ToString();
            //new comment line
            return View();
        }
    }
}
