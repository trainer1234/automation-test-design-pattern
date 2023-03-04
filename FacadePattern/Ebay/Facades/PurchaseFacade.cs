using System;
using System.Collections.Generic;
using System.Text;
using FacadePattern.Ebay.Model;
using FacadePattern.Ebay.Pages.Checkout;
using FacadePattern.Ebay.Pages.Home;
using FacadePattern.Ebay.Pages.Item;
using FacadePattern.Ebay.Pages.SearchResult;

namespace FacadePattern.Ebay.Facades
{
    public class PurchaseFacade
    {
        private HomePage homePage;
        private SearchResultPage searchResultPage;
        private ItemPage itemPage;
        private CheckoutPage checkoutPage;

        public HomePage HomePage => homePage ??= HomePage.Instance;
        public SearchResultPage SearchResultPage => searchResultPage ??= SearchResultPage.Instance;
        public ItemPage ItemPage => itemPage ??= ItemPage.Instance;
        public CheckoutPage CheckoutPage => checkoutPage ??= CheckoutPage.Instance;

        public void PurchaseItem(string itemName, CustomerInfo customerInfo)
        {
            HomePage.Navigate();
            HomePage.Validate().Logo();
            HomePage.Search(itemName);
            SearchResultPage.Validate().SearchResultCount();
            SearchResultPage.SaveSearchResultInfo(0);
            SearchResultPage.SwitchToItemPage(0);
            ItemPage.Validate().Name();
            ItemPage.Validate().Price();
            ItemPage.BuyNow();
            ItemPage.CheckoutAsGuest();
            CheckoutPage.Validate().Subtotal();
            CheckoutPage.Validate().Total();
            CheckoutPage.FillInShippingInfo(customerInfo);
            CheckoutPage.PayWith(PaymentMethod.Card, customerInfo);
            CheckoutPage.ConfirmAndPay();
        }
    }
}
