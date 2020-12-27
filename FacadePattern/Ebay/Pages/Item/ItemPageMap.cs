using ATDP.Core;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.Item
{
    public class ItemPageMap : BasePageElementMap
    {
        public IWebElement Name => Driver.BrowserWait.Until(d => d.FindElement(By.Id("itemTitle")));
        public IWebElement Price => Driver.BrowserWait.Until(d => d.FindElement(By.Id("prcIsum")));
        public IWebElement ConvertedPrice => Driver.BrowserWait.Until(d => d.FindElement(By.Id("convbinPrice")));
        public IWebElement BuyNowButton => Driver.BrowserWait.Until(d => d.FindElement(By.Id("binBtn_btn")));
        public IWebElement CheckoutAsGuestButton => Driver.BrowserWait.Until(d => d.FindElement(By.Id("sbin-gxo-btn")));
    }
}
