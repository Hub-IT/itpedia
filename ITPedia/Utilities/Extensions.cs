using System.Web.Mvc;

/**
 * Credits: http://www.codingeverything.com/2014/05/mvcbootstrapactivenavbar.html
 * @author Rizart Dokollari <r.dokollari@gmail.com>
 * @since 9/1/2015
 */
namespace ITPedia.Utilities
{
    public static class Extensions
    {
        public static string IsActive(this HtmlHelper html, string control, string action)
        {
            var routeData = html.ViewContext.RouteData;
            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            var returnActive = control == routeControl && action == routeAction;

            return returnActive ? "active" : "";
        }
    }
}