using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Chapt2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);

            //var defaults = new RouteValueDictionary{{"name","*"},{"id","*"}};
            //RouteTable.Routes.MapPageRoute("", "employees/{name}/{id}", "~/Default.aspx", true, defaults);

            RouteTable.Routes.RouteExistingFiles = true;

            var defaults = new RouteValueDictionary(){{"areacode","010"},{"days",2}};

            var contains = new RouteValueDictionary() { { "areacode", @"0\d{2,3}" }, { "days", "[1-3]{1}" },{"httpMethod",new HttpMethodConstraint("GET")} };

            var tokens = new RouteValueDictionary(){{"defaultCity","beijing"},{"defaultDays","2"}};

            RouteTable.Routes.MapPageRoute("default", "weather/{areacode}/{days}", "~/weather.aspx", false, defaults, null, tokens);
        }
    }
}