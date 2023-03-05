using ATDP.Core;
using FacadePattern.Ebay.Model;
using FluentAssertions;

namespace FacadePattern.Ebay.Pages.Item
{
    public class ItemPageValidator : BasePageValidator<ItemPageMap>
    {
        public void Name()
        {
            var searchResultItemInfo = DataContext.DataPool["searchResultItemInfo"].As<SearchResultItemInfo>();
            Map.Name.Text.Should().Contain(searchResultItemInfo.Name);
        }

        public void Price()
        {
            var searchResultItemInfo = DataContext.DataPool["searchResultItemInfo"].As<SearchResultItemInfo>();
            Map.ConvertedPrice.Text.Should().Be(searchResultItemInfo.Price);

            var itemInfo = new ItemInfo
            {
                Name = searchResultItemInfo.Name,
                ConvertedPrice = searchResultItemInfo.Price,
                BasePrice = Map.Price.Text
            };
            DataContext.DataPool.Add("itemInfo", itemInfo);
        }
    }
}
