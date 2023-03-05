using InversionOfControl.Contracts;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using ATDP.Core.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using Unity;
using Unity.Lifetime;
using ServiceLifetime = ATDP.Core.Enums.ServiceLifetime;

namespace InversionOfControl
{
    public static class PageFactory
    {
        static PageFactory()
        {
            var servicesToBeRegistered = new List<(Type contract, Type implementation, ServiceLifetime lifetime)>
            {
                (typeof(IWikipediaMainPage), typeof(WikipediaMainPage), ServiceLifetime.Singleton)
            };
            ServiceContainer.RegisterAllServices(servicesToBeRegistered);
        }

        public static T Get<T>()
        {
            return ServiceContainer.Get<T>();
        }
    }
}
