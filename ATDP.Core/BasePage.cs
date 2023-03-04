﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using ATDP.Core;
using OpenQA.Selenium;

namespace ATDP.Core
{
    public class BasePage<M> where M : BasePageElementMap, new()
    {
        private static BasePage<M> instance;

        protected BasePage()
        {
        }

        public static BasePage<M> Instance => instance ?? (instance = new BasePage<M>());
        protected M Map => new M();

        public virtual void Navigate(string url)
        {
            Driver.Browser.Navigate().GoToUrl(url);
        }
    }

    public class BasePage<M, V> : BasePage<M>
        where M : BasePageElementMap, new()
        where V : BasePageValidator<M>, new()
    {
        public V Validate() => new V();
    }
}
