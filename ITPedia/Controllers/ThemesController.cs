using System.Web.Mvc;

namespace DB.Controllers
{
    public class ThemesController : Controller
    {
        // GET: Themes
        public ActionResult Index(string id = "sandstone")
        {
            System.Web.HttpContext.Current.Session["theme_name"] = id;

            if (ControllerContext.HttpContext.Request.UrlReferrer != null)
                return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());

            return RedirectToAction("Index", "Configuration");
        }
    }
}