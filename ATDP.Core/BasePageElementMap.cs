using OpenQA.Selenium;

namespace ATDP.Core
{
    public class BasePageElementMap
    {
        protected readonly IWebDriver browser;

        public BasePageElementMap()
        {
            this.browser = Driver.Browser;
        }
    }
}
