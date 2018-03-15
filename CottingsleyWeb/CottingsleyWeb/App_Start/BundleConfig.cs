using System.Web;
using System.Web.Optimization;

namespace CottingsleyWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", "~/Scripts/jquery.unobstrusive-ajax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/cottingsleyscript").Include(
                       "~/Scripts/app.js",
                      "~/Scripts/carousel-swipe.js",
                      "~/Scripts/inputmask.min.js",
                      "~/Scripts/jquery.inputmask.min.js",
                      "~/Scripts/jquery.appear.js",
                      "~/Scripts/jquery.drawsvg.min.js",
                      "~/Scripts/jquery.parallax.min.js",
                      "~/Scripts/pushy.min.js",
                      "~/Scripts/consoleFix.js",
                      "~/Scripts/jquery.matchHeight.js",
                      "~/Scripts/common.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/cottingsleystyle").Include(
                      "~/Content/font-awesome.min.css",
                      "~/Content/base-sizing.css",
                      "~/Content/color-change.css",
                      "~/Content/template.css"));
        }
    }
}
