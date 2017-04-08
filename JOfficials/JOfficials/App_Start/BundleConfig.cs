using System;
using System.Web.Optimization;

namespace JOfficials.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts/desktop")
                .Include(
                "~/Scripts/jquery-3.1.1.js",
                "~/Scripts/bootstrap.js"
                ).IncludeDirectory("~/Scripts", ".js"));

            bundles.Add(new StyleBundle("~/bundles/css/desktop")
                .Include(
                "~/Content/bootstrap.css"
                ).IncludeDirectory("~/Content", ".css"));
        }
    }
}