using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ServiceLifetime = ATDP.Core.Enums.ServiceLifetime;

namespace ATDP.Core.DependencyInjection
{
    public static class ServiceContainer
    {
        //private static IUnityContainer container;
        private static ServiceProvider container;
        //private static Container container;

        static ServiceContainer()
        {
            // Unity
            //container = new UnityContainer();
            //container.RegisterType<IWikipediaMainPage, WikipediaMainPage>(new ContainerControlledLifetimeManager());

            // .net dependency injection
            //var services = new ServiceCollection();
            //services.AddSingleton<IWikipediaMainPage, WikipediaMainPage>();
            //container = services.BuildServiceProvider();

            // Simple Injector
            //container = new Container();
            //container.Register<IWikipediaMainPage, WikipediaMainPage>();

            //container.Verify();
        }

        public static void RegisterAllServices(List<(Type contract, Type implementation, ServiceLifetime lifetime)> serviceToRegister)
        {
            var services = new ServiceCollection();
            foreach (var service in serviceToRegister)
            {
                switch (service.lifetime)
                {
                    case ServiceLifetime.Singleton:
                        services.AddSingleton(service.contract, service.implementation);
                        break;
                    case ServiceLifetime.Scoped:
                        services.AddScoped(service.contract, service.implementation);
                        break;
                    case ServiceLifetime.Transient:
                        services.AddTransient(service.contract, service.implementation);
                        break;
                }
            }
            container = services.BuildServiceProvider();
        }

        public static T Get<T>()
        {
            //return container.Resolve<T>(); // unity
            return container.GetService<T>(); // .net
            //var instance = container.GetInstance(typeof(T));  // simple injector
            //return (T) instance;
        }
    }
}
