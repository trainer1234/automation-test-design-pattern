using FluentAssertions;
using OpenQA.Selenium;

namespace PageObjectPattern
{
    public class SearchEngineMainPageValidator
    {
        private readonly IWebDriver browser;

        public SearchEngineMainPageValidator(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected SearchEngineMainPageElementMap Map => new SearchEngineMainPageElementMap(this.browser);

        public void ResultsCount(string expectedCount)
        {
            this.Map.ResultsCountDiv.Text.Should()
                .Contain(expectedCount, "The results DIV doesn't contains the specified text.");
        }
    }
}
