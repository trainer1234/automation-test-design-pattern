using ATDP.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AdvancedPageObjectPattern
{
    public class SearchEngineMainPageElementMap : BasePageElementMap
    {
        public IWebElement SearchBox => this.browser.FindElement(By.Id("sb_form_q"));

        public IWebElement GoButton => this.browser.FindElement(By.Id("search_icon"));

        public IWebElement ResultsCountDiv => this.browser.FindElement(By.Id("b_tween"));
        public IWebElement ImagesTab => this.browser.FindElement(By.Id("b-scopeListItem-images"));
        public IWebElement FilterButton => this.browser.FindElement(By.Id("fltIdtLnk"));
        
        public IWebElement SizeDropdown => this.browser.FindElement(By.XPath("//div[@id='ftrB']/ul/li/span/span[text()='Image size']"));
        public IWebElement ColorDropdown => this.browser.FindElement(By.XPath("//div[@id='ftrB']/ul/li/span/span[text()='Color']"));
        public IWebElement TypeDropdown => this.browser.FindElement(By.XPath("//div[@id='ftrB']/ul/li/span/span[text()='Type']"));
        public IWebElement LayoutDropdown => this.browser.FindElement(By.XPath("//div[@id='ftrB']/ul/li/span/span[text()='Layout']"));
        public IWebElement PeopleDropdown => this.browser.FindElement(By.XPath("//div[@id='ftrB']/ul/li/span/span[text()='People']"));
        public IWebElement DateDropdown => this.browser.FindElement(By.XPath("//div[@id='ftrB']/ul/li/span/span[text()='Date']"));
        public IWebElement LicenseDropdown => this.browser.FindElement(By.XPath("//div[@id='ftrB']/ul/li/span/span[text()='License']"));


    }
}
