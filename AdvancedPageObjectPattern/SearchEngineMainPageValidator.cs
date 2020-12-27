using ATDP.Core;
using FluentAssertions;

namespace AdvancedPageObjectPattern
{
    public class SearchEngineMainPageValidator : BasePageValidator<SearchEngineMainPageElementMap>
    {
        public void ResultsCount(string expectedCount)
        {
            this.Map.ResultsCountDiv.Text.Should()
                .Contain(expectedCount, "The results DIV doesn't contains the specified text.");
        }
    }
}
