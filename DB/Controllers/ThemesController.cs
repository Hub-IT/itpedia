using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DB.Controllers
{
    public class ThemesController : Controller
    {
        // GET: Themes
        public ActionResult Index(string name)
        {
            return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());
        }
    }
}