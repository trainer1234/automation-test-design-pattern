using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATDP.Core;
using FacadePattern.Ebay.Model;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.SearchResult
{
    public class SearchResultPage : BasePage<SearchResultPageMap, SearchResultPageValidator>
    {
        public void ClickAndSaveSearchResultInfo(int index)
        {
            SaveSearchResultInfo(index);
            var searchResult = Map.SearchResultImages?.ElementAt(index);
            searchResult?.Click();
            searchResult?.Click(); // Not sure why but have to click this element twice
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
