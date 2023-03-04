using ATDP.Core;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.Home
{
    public class HomePage : BasePageSingletonDerived<HomePage, HomePageMap, HomePageValidator>
    {
        private HomePage() { }

        public void Search(string itemName)
        {
            Map.SearchTextBox.SendKeys(itemName);
            Map.SearchButton.Click();
        }

        public void SearchWithoutClickingButton(string itemName)
        {
            Map.SearchTextBox.SendKeys(itemName + Keys.Enter);
        }

        public void Navigate(string url = "https://ebay.com")
        {
            base.Navigate(url);
        }
    }
}
