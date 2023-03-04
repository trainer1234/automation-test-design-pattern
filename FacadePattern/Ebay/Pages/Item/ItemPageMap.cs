using ATDP.Core;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.Item
{
    public class ItemPageMap : BasePageElementMap
    {
        public IWebElement Name => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#LeftSummaryPanel div[data-testid='x-item-title']")));
        public IWebElement Price => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#mainContent div[data-testid='x-buybox'] div[data-testid='x-price-primary'] span[itemprop='price']")));
        public IWebElement ConvertedPrice => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#mainContent div[data-testid='x-buybox'] div[data-testid='x-price-approx'] .x-price-approx__price")));
        public IWebElement BuyNowButton => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("div[data-testid='x-bin-action']")));
        public IWebElement CheckoutAsGuestButton => Driver.BrowserWait.Until(d => d.FindElement(By.ClassName("ux-bin-nudge__guestCheckOut")));
    }
}
