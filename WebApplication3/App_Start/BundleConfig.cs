using System.Web;
using System.Web.Optimization;
using System.Web.Optimization.React;

namespace WebApplication3
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new BabelBundle("~/bundles/main").Include(
                    "~/Scripts/remarkable.min.js",
                    "~/Scripts/Tutorial.jsx"
                ));
        }
    }
}
