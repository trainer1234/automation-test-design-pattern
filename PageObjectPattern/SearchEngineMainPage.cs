using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace PageObjectPattern
{
    public class SearchEngineMainPage
    {
        private readonly IWebDriver browser;
        private readonly string url = @"searchEngineUrl";

        public SearchEngineMainPage(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected SearchEngineMainPageElementMap Map => new SearchEngineMainPageElementMap(browser);

        public SearchEngineMainPageValidator Validate()
        {
            return new SearchEngineMainPageValidator(browser);
        }

        public void Navigate()
        {
            browser.Navigate().GoToUrl(url);
        }

        public void Search(string text)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(text);
            Map.GoButton.Click();
        }
    }
}
