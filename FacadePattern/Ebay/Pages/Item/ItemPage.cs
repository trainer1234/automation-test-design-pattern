using ATDP.Core;

namespace FacadePattern.Ebay.Pages.Item
{
    public class ItemPage : BasePageSingletonDerived<ItemPage, ItemPageMap, ItemPageValidator>
    {
        private ItemPage() { }

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
