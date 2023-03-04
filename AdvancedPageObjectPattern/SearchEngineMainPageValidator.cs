using ATDP.Core;
using FluentAssertions;

namespace AdvancedPageObjectPattern
{
    public class SearchEngineMainPageValidator : BaseFluentPageValidator<SearchEngineMainPage, SearchEngineMainPageElementMap, SearchEngineMainPageValidator>
    {
        public SearchEngineMainPage ResultsCount(string expectedCount)
        {
            this.Map.ResultsCountDiv.Text.ToLower().Should()
                .Contain(expectedCount.ToLower(), "The results DIV doesn't contains the specified text.");
            return PageInstance;
        }
    }
}
