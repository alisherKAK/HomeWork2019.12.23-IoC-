using Castle.Windsor;
using HomeWork2019._12._23_CastleWindsor_.Web.CastleWindsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HomeWork2019._12._23_CastleWindsor_.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new WindsorContainer();

            container.Install(new ApplicationCastleInstaller());

            var castleControllerFactory = new CastleControllerFactory(container);

            ControllerBuilder.Current.SetControllerFactory(castleControllerFactory);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
