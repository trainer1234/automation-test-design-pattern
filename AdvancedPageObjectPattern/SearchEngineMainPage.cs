using ATDP.Core;
using System.ComponentModel;

namespace AdvancedPageObjectPattern
{
    public class SearchEngineMainPage : BaseFluentPageSingletonDerived<SearchEngineMainPage, SearchEngineMainPageElementMap, SearchEngineMainPageValidator>
    {
        // mark as private to prevents creation of a default constructor
        // because the instance has already been instantiated in BasePageSingletonDerived
        private SearchEngineMainPage() { }

        public SearchEngineMainPage Search(string text)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(text);
            Map.GoButton.Click();
            return this;
        }

        public SearchEngineMainPage ClickImagesTab()
        {
            this.Map.ImagesTab.Click();
            return this;
        }

        public SearchEngineMainPage ClickFilterButton()
        {
            Map.FilterButton.Click();
            return this;
        }

        public SearchEngineMainPage SetSize()
        {
            this.Map.SizeDropdown.Click();
            return this;
        }
        public SearchEngineMainPage SetColor()
        {
            this.Map.ColorDropdown.Click();
            return this;
        }
        public SearchEngineMainPage SetTypes()
        {
            this.Map.TypeDropdown.Click();
            return this;
        }
        public SearchEngineMainPage SetLayout()
        {
            this.Map.LayoutDropdown.Click();
            return this;
        }
        public SearchEngineMainPage SetPeople()
        {
            this.Map.PeopleDropdown.Click();
            return this;
        }
        public SearchEngineMainPage SetDate()
        {
            this.Map.DateDropdown.Click();
            return this;
        }
        public SearchEngineMainPage SetLicense()
        {
            this.Map.LicenseDropdown.Click();
            return this;
        }

        public SearchEngineMainPage Navigate(string url = "https://bing.com")
        {
            base.Navigate(url);
            return this;
        }
    }
}
