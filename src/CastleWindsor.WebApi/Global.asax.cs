using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Routing;
using WebApplication1.Adapter;
using WebApplication1.ApplicationServices;

namespace WebApplication1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //IWindsorContainer container = new WindsorContainer();
            //container.Register(Component.For<IOrderService>().ImplementedBy<OrderService>());

            IWindsorContainer container = new WindsorContainer().Install(new WebWindsorInstaller());

            GlobalConfiguration.Configuration.Services.Replace(
                typeof(IHttpControllerActivator),
                new WindsorCompositionRoot(container));

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
