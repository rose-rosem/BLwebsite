using System.Web;
using System.Web.Optimization;

namespace BLwebsite
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Layout/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/edua-icons.css",
                      "~/Content/animate.min.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/owl.transitions.css",
                      "~/Content/cubeportfolio.min.css",
                      "~/Content/settings.css",
                      "~/Content/bootsnav.css",
                      "~/Content/style.css",
                      "~/Content/loader.css"
                      ));

            bundles.Add(new ScriptBundle("~/Layout/js").Include(
                      "~/Scripts/jquery-2.2.3.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootsnav.js",
                      "~/Scripts/jquery.appear.js",
                      "~/Scripts/jquery-countTo.js",
                      "~/Scripts/jquery.parallax-1.1.3.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/jquery.cubeportfolio.min.js",
                      "~/Scripts/jquery.themepunch.tools.min.js",
                      "~/Scripts/jquery.themepunch.revolution.min.js",
                      "~/Scripts/revolution.extension.layeranimation.min.js",
                      "~/Scripts/revolution.extension.navigation.min.js",
                      "~/Scripts/revolution.extension.parallax.min.js",
                      "~/Scripts/revolution.extension.slideanims.min.js",
                      "~/Scripts/revolution.extension.video.min.js",
                      "~/Scripts/revolution.extension.video.min.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/functions.js"));
        }
    }
}
