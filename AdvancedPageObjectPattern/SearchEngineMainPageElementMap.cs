using ATDP.Core;
using OpenQA.Selenium;

namespace AdvancedPageObjectPattern
{
    public class SearchEngineMainPageElementMap : BasePageElementMap
    {
        public IWebElement SearchBox => this.browser.FindElement(By.Id("sb_form_q"));

        public IWebElement GoButton => this.browser.FindElement(By.Id("sb_form_go"));

        public IWebElement ResultsCountDiv => this.browser.FindElement(By.Id("b_tween"));
    }
}
