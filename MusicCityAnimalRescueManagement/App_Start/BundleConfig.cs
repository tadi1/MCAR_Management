using System.Web;
using System.Web.Optimization;

namespace MusicCityAnimalRescueManagement
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js",
                        "~/scripts/typeahead.bundle.js",
                        "~/scripts/toastr.js"
                      )); ;

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-cerulean.css",
                      "~/Content/bootstrap-cerulean.min.css",
                      "~/Content/bootstrap-theme.css",
                      "~/content/datatables/css/datatables.bootstrap.css",
                      "~/content/typeahead.css",
                      "~/content/toastr.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-1.10.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            "~/Scripts/jquery-ui.js"));

            bundles.Add(new StyleBundle("~/Content/themes/base/").Include(
                "~/Content/themes/base/jquery.ui.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                "~/scripts/datatables/jquery.datatables.js"));


            bundles.Add(new StyleBundle("~/Content/dataTables").Include(
                      "~/Content/DataTables/css/jquery.dataTables.css",
                      "~/Content/DataTables/css/jquery.dataTables.min.css"));


            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
          "~/Scripts/DataTables/jquery.dataTables.js",
          "~/Scripts/DataTables/dataTables.bootstrap.js",
          "~/Scripts/DataTables/sum().js",
          "~/Scripts/DataTables/jquery.dataTables.min.js"));
        }
    }
}
