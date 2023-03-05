using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATDP.Core;
using FacadePattern.Ebay.Pages.Home;
using InversionOfControl.Contracts;

namespace InversionOfControl
{
    public class WikipediaMainPage : BasePage<WikipediaMainPageMap, WikipediaMainPageValidator>, IWikipediaMainPage
    {
        public WikipediaMainPage()
            : base(@"https://en.wikipedia.org/")
        {
        }

        public void Search(string searchTerm)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(searchTerm);
            Map.SearchButton.Click();
        }

        public void ToggleHideContents()
        {
            Map.TocToggleHideButton.Click();
        }

        public void ToggleShowContents()
        {
            Map.TocDropdown.Click();
            Map.TocDropdownMoveToSidebar.Click();
        }
    }
}
