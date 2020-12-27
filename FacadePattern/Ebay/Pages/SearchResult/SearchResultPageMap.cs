﻿using System;
using System.Collections.Generic;
using System.Linq;
using ATDP.Core;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.SearchResult
{
    public class SearchResultPageMap : BasePageElementMap
    {
        public IWebElement SearchResultCount => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector(".srp-controls__count-heading span:first-child")));

        public IReadOnlyCollection<IWebElement> SearchResultTitles => Driver.BrowserWait.Until(d =>
            d.FindElements(By.CssSelector("h3.s-item__title")));
        public IReadOnlyCollection<IWebElement> SearchResultPrices => Driver.BrowserWait.Until(d =>
            d.FindElements(By.ClassName("s-item__price")));
        public IReadOnlyCollection<IWebElement> SearchResultImages => Driver.BrowserWait.Until(d =>
            d.FindElements(By.ClassName("s-item__image")));
    }
}
