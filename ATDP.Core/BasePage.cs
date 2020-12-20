using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using OpenQA.Selenium;

namespace ADVT.Core
{
    public class BasePage<M> where M : BasePageElementMap, new()
    {
        protected readonly string url;

        public BasePage(string url)
        {
            this.url = url;
        }

        protected M Map => new M();

        public void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(url);
        }
    }

    public class BasePage<M, V> : BasePage<M>
        where M : BasePageElementMap, new()
        where V : BasePageValidator<M>, new()
    {
        public BasePage(string url)
            : base(url)
        {
            
        }

        public V Validate() => new V();
    }
}
