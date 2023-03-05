using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using ATDP.Core;
using OpenQA.Selenium;

namespace ATDP.Core
{
    public class BasePage<M> where M : BasePageElementMap, new()
    {
        protected readonly string url;
        protected BasePage(string url)
        {
            this.url = url;
        }

        public BasePage()
        {
            url = null;
        }

        protected M Map => new M();

        public virtual void Navigate(string part = "")
        {
            Driver.Browser.Navigate().GoToUrl(String.Concat(url, part));
        }
    }

    public class BasePage<M, V> : BasePage<M>
        where M : BasePageElementMap, new()
        where V : BasePageValidator<M>, new()
    {
        public BasePage(string url) : base(url)
        {
        }

        public BasePage()
        {
        }

        public V Validate() => new V();
    }
}
