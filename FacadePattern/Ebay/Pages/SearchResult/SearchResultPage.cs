using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATDP.Core;
using FacadePattern.Ebay.Model;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.SearchResult
{
    public class SearchResultPage : BasePageSingletonDerived<SearchResultPage, SearchResultPageMap, SearchResultPageValidator>
    {
        private SearchResultPage() { }

        public void SwitchToItemPage(int index)
        {
            string originalWindow = Driver.Browser.CurrentWindowHandle;

            var searchResult = Map.SearchResultImages?.ElementAt(index);
            searchResult?.Click();
            Driver.BrowserWait.Until(wd => wd.WindowHandles.Count == 2);

            foreach (string window in Driver.Browser.WindowHandles)
            {
                if (originalWindow != window)
                {
                    Driver.Browser.SwitchTo().Window(window);
                    break;
                }
            }
        }

        public void SaveSearchResultInfo(int index)
        {
            var searchResultItemInfo = new SearchResultItemInfo
            {
                Name = Map.SearchResultTitles.ElementAt(index).Text,
                Price = Map.SearchResultPrices.ElementAt(index).Text
            };

            DataContext.DataPool.Add("searchResultItemInfo", searchResultItemInfo);
        }
    }
}
