using System.Web;
using System.Web.Optimization;

namespace KGETech
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));


            // jquery-slimscroll
            bundles.Add(new ScriptBundle("~/bundles/jquery-slimscroll").Include(
                "~/Scripts/jquery.slimscroll.js"));


            // jquery-validate
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));


            // popper
            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                                    "~/Scripts/popper.js"));

            // font-awesome
            bundles.Add(new ScriptBundle("~/bundles/font-awesome").Include(
                "~/Scripts/fontawesome/all.js"));

            

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            
            // modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // bootstrap-datepicker
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker").Include(
                      "~/Scripts/bootstrap-datepicker.js"));

            // custom
            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                "~/Scripts/custom.js"));

            // css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker3.css",
                      "~/Content/fontawesome.css",
                      "~/Content/style.css"));
        }
    }
}
