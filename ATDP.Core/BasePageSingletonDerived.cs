using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using ATDP.Core;
using ATDP.Core.Singleton;
using OpenQA.Selenium;

namespace ATDP.Core
{
    public abstract class BasePageSingletonDerived<S, M> : ThreadSafeNestedConstructorSingleton<S>
        where S : BasePageSingletonDerived<S, M>
        where M : BasePageElementMap, new()
    {
        protected M Map => new M();

        public virtual void Navigate(string url)
        {
            Driver.Browser.Navigate().GoToUrl(url);
        }
    }

    public abstract class BasePageSingletonDerived<S, M, V> : BasePageSingletonDerived<S, M>
        where S : BasePageSingletonDerived<S, M, V>
        where M : BasePageElementMap, new()
        where V : BasePageValidator<M>, new()
    {
        public V Validate() => new V();
    }
}
