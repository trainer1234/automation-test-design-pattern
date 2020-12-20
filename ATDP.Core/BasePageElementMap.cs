using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace ADVT.Core
{
    public class BasePageElementMap
    {
        protected readonly IWebDriver browser;

        public BasePageElementMap()
        {
            this.browser = Driver.Browser;
        }
    }
}
