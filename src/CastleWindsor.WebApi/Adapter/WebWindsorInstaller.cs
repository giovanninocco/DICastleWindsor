using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using WebApplication1.ApplicationServices;
using WebApplication1.Controllers;

namespace WebApplication1.Adapter
{
    public class WebWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes
                .FromAssemblyContaining<OrderService>()
                .BasedOn<IApplicationService>()
                .LifestylePerWebRequest()
                .WithServiceAllInterfaces());

            //container.Register(Component.For<IOrderService>().ImplementedBy<OrderService>());

            container.Register(Classes
                .FromAssemblyContaining<OrderController>()
                .BasedOn<IController>()
                .LifestylePerWebRequest());
        }
    }
}