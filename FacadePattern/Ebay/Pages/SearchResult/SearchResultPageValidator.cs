using ATDP.Core;
using FluentAssertions;

namespace FacadePattern.Ebay.Pages.SearchResult
{
    public class SearchResultPageValidator : BasePageValidator<SearchResultPageMap>
    {
        public void SearchResultCount()
        {
            Map.SearchResultCount.Displayed.Should().BeTrue();
            int.TryParse(Map.SearchResultCount.Text, out int count);
            count.Should().BeGreaterOrEqualTo(0);
        }
    }
}
