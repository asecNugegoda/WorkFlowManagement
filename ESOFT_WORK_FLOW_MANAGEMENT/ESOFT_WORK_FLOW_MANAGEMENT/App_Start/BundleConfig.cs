using System.Web;
using System.Web.Optimization;

namespace ESOFT_WORK_FLOW_MANAGEMENT
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/material-dashboard.css",
                      "~/Content/material-dashboard.min.css",
                      "~/Content/bootstrap-material-datetimepicker.css",
                      "~/Content/bootstrap-material-datetimepicker-bs4.css",
                      "~/Content/bootstrap-material-datetimepicker-bs4.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                      "~/Scripts/Script/core/jquery.min.js",
                      "~/Scripts/Script/core/popper.min.js",
                      "~/Scripts/Process.js",
                      "~/Scripts/Script/core/core/bootstrap-material-design.min.js",
                      "~/Scripts/Script/plugins/perfect-scrollbar.jquery.min.js",
                      "~/Scripts/Script/plugins/chartist.min.js",
                      "~/Scripts/Script/plugins/bootstrap-notify.js",
                      "~/Scripts/Script/plugins/perfect-scrollbar.jquery.min.js",
                      "~/Scripts/material-dashboard.min.js",
                      "~/Scripts/bootstrap-material-datetimepicker.js",
                      "~/Scripts/bootstrap-material-datetimepicker-bs4.min.css",
                      "~/Scripts/bootstrap-material-datetimepicker-bs4.css",
                      "~/Scripts/jquery-1.10.2.min.js",
                      "~/Scripts/jquery-1.10.2.js"));

        }
    }
}
