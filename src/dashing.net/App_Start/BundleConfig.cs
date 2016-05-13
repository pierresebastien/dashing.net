﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using dashing.net.Infrastructure;

namespace dashing.net.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var application = new ScriptBundle("~/bundles/application-js")
                .Include("~/libs/bower/jquery/dist/jquery.js")
                .Include("~/libs/bower/es5-shim/es5-shim.js")
                .Include("~/Scripts/batman.js")
                .Include("~/Scripts/batman.jquery.js")
                .Include("~/Scripts/dashing.coffee")
                .Include("~/Scripts/gridster/jquery.leanModal.min.js")
                .Include("~/Scripts/jquery.knob.js")
                .Include("~/Scripts/d3.v2.min.js")
                .Include("~/Scripts/rickshaw.min.js")
                .Include("~/Scripts/gridster/jquery.gridster.js")
                .Include("~/Scripts/dashing.gridster.coffee")
                .IncludeDirectory("~/Widgets", "*.coffee", true)
                .Include("~/Scripts/application.coffee");
                            
            application.Transforms.Add(new CoffeeTransform());
            bundles.Add(application);

            var styles = new Bundle("~/bundles/application-css")
                .Include("~/libs/bower/font-awesome/css/font-awesome.css")
                .Include("~/Assets/stylesheets/jquery.gridster.css")
                .IncludeDirectory("~/Widgets", "*.scss", true)
                .Include("~/Assets/stylesheets/application.scss");

            styles.Transforms.Add(new ScssTransform());
            bundles.Add(styles);

            BundleTable.EnableOptimizations = true;
        }
    }
}