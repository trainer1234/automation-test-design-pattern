using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObjectPattern
{
    public class SearchEngineMainPageElementMap
    {
        private readonly IWebDriver browser;

        public SearchEngineMainPageElementMap(IWebDriver browser)
        {
            this.browser = browser;
        }

        public IWebElement SearchBox => this.browser.FindElement(By.Id("sb_form_q"));

        public IWebElement GoButton => this.browser.FindElement(By.Id("sb_form_go"));

        public IWebElement ResultsCountDiv => this.browser.FindElement(By.Id("b_tween"));
    }
}
