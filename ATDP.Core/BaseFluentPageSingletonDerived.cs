using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using ATDP.Core;
using ATDP.Core.Singleton;
using OpenQA.Selenium;

namespace ATDP.Core
{
    public abstract class BaseFluentPageSingletonDerived<S, M> : ThreadSafeNestedConstructorSingleton<S>
        where S : BaseFluentPageSingletonDerived<S, M>
        where M : BasePageElementMap, new()
    {
        protected M Map => new M();

        public virtual void Navigate(string url)
        {
            Driver.Browser.Navigate().GoToUrl(url);
        }
    }

    public abstract class BaseFluentPageSingletonDerived<S, M, V> : BaseFluentPageSingletonDerived<S, M>
        where S : BaseFluentPageSingletonDerived<S, M, V>
        where M : BasePageElementMap, new()
        where V : BaseFluentPageValidator<S, M, V>, new()
    {
        public V Validate(S instance)
        {
            var validator = new V();
            validator.PassPageInstance(instance);
            return validator;
        }
    }
}
