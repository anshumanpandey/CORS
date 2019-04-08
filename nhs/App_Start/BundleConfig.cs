using System.Web;
using System.Web.Optimization;

namespace NHS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            // "~/Scripts/jquery.validate*"));

                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/js").Include(
            //          "~/Scripts/js/jquery-1.12.4.min.js",
            //          "~/Scripts/js/jquery-ui.min.js",
            //          "~/Scripts/js/bootstrap.min.js",
            //          "~/Scripts/js/modernizr-2.8.3.min.js",
            //          "~/Scripts/js/respond-1.4.2.min.js",
            //          "~/Scripts/js/custom.js"
            //          ));

            //bundles.Add(new StyleBundle("~/css/css").Include(
            //          "~/css/bootstrap.min.css",
            //          "~/css/font-awesome.min.css",
            //          "~/css/jquery-ui.min.css",
            //          "~/css/responsive.css",
            //          "~/css/style.css"));
        }
    }
}
