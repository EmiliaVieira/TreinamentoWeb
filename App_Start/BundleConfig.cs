using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace TreinamentoWeb.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/select2.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
               "~/Content/bootstrap.css",
               "~/Content/css/select2.css",
               "~/Content/Site.css",
               "~/Content/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/branches").Include(
                "~/Scripts/branches.js"));


        }
    }
}