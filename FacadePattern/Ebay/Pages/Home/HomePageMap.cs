using ATDP.Core;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.Home
{
    public class HomePageMap : BasePageElementMap
    {
        public IWebElement Logo => Driver.BrowserWait.Until(d => d.FindElement(By.Id("gh-logo")));
        public IWebElement SearchTextBox => Driver.BrowserWait.Until(d => d.FindElement(By.Id("gh-ac")));
        public IWebElement SearchButton => Driver.BrowserWait.Until(d => d.FindElement(By.Id("gh-btn")));
    }
}
