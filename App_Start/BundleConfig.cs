using System.Web.Optimization;

namespace MiniProjectMVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Styling for this project is inlined in _Layout.cshtml for a
            // zero-dependency setup. Add script/style bundles here if you
            // install jQuery/Bootstrap via NuGet later.
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Site.css"));
        }
    }
}
