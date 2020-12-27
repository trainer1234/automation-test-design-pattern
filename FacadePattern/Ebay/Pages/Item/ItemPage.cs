using ATDP.Core;

namespace FacadePattern.Ebay.Pages.Item
{
    public class ItemPage : BasePage<ItemPageMap, ItemPageValidator>
    {
        public void BuyNow()
        {
            Map.BuyNowButton.Click();
        }

        public void CheckoutAsGuest()
        {
            Map.CheckoutAsGuestButton.Click();
        }
}
}
