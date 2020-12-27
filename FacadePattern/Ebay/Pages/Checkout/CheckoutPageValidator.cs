using System.Linq;
using ATDP.Core;
using FacadePattern.Ebay.Model;
using FluentAssertions;

namespace FacadePattern.Ebay.Pages.Checkout
{
    public class CheckoutPageValidator : BasePageValidator<CheckoutPageMap>
    {
        public void Subtotal()
        {
            var itemInfo = DataContext.DataPool["itemInfo"].As<ItemInfo>();
            Map.Subtotal.Text.Should().Be(itemInfo.BasePrice);
        }

        public void Total()
        {
            var total = Map.Total.Text.Split();
            string currencyCode = total[0];
            string price = total[1];

            currencyCode.Length.Should().Be(2);
            price.Should().Contain("$");
        }
    }
}
