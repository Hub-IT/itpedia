using System.Web;
using System.Web.Optimization;

namespace ItPedia
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.min.js",
                      "~/Scripts/select2.min.js"));

            bundles.Add(new StyleBundle("~/Content/App.css").Include(
                      "~/Content/bootstrap-cerulean.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/css/select2.min.css",
                      "~/Content/select2-bootstrap.css",
                      "~/Content/Site.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
