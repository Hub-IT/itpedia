using System.Web.Mvc;

namespace DB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Acknowledgment()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}