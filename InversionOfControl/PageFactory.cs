using InversionOfControl.Contracts;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using Unity;
using Unity.Lifetime;

namespace InversionOfControl
{
    public static class PageFactory
    {
        //private static IUnityContainer container;
        private static ServiceProvider container;
        //private static Container container;

        static PageFactory()
        {
            // Unity
            //container = new UnityContainer();
            //container.RegisterType<IWikipediaMainPage, WikipediaMainPage>(new ContainerControlledLifetimeManager());

            // .net dependency injection
            var services = new ServiceCollection();
            services.AddSingleton<IWikipediaMainPage, WikipediaMainPage>();
            container = services.BuildServiceProvider();

            // Simple Injector
            //container = new Container();
            //container.Register<IWikipediaMainPage, WikipediaMainPage>();

            //container.Verify();
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
