using ATDP.Core;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.Home
{
    public class HomePage : BasePage<HomePageMap, HomePageValidator>
    {
        public void Search(string itemName)
        {
            Map.SearchTextBox.SendKeys(itemName);
            Map.SearchButton.Click();
        }

        public void SearchWithoutClickingButton(string itemName)
        {
            Map.SearchTextBox.SendKeys(itemName + Keys.Enter);
        }
    }
}
