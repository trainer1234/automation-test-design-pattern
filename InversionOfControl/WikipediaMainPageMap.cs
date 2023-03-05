using ATDP.Core;
using OpenQA.Selenium;

namespace FacadePattern.Ebay.Pages.Home
{
    public class WikipediaMainPageMap : BasePageElementMap
    {
        public IWebElement SearchBox => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#p-search input")));
        public IWebElement SearchButton => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#p-search button")));
        public IWebElement TocHeader => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#vector-toc .vector-pinnable-header")));
        public IWebElement TocToggleHideButton => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#vector-toc .vector-pinnable-header-unpin-button")));
        public IWebElement TocDropdown => Driver.BrowserWait.Until(d => d.FindElement(By.Id("vector-page-titlebar-toc")));
        public IWebElement TocDropdownMoveToSidebar => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#vector-page-titlebar-toc .vector-pinnable-header-pin-button")));

        public IWebElement TocList => Driver.BrowserWait.Until(d => d.FindElement(By.CssSelector("#vector-toc ul")));
    }
}
