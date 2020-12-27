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

        public HomePage HomePage => homePage ?? (homePage = new HomePage());
        public SearchResultPage SearchResultPage => searchResultPage ?? (searchResultPage = new SearchResultPage());
        public ItemPage ItemPage => itemPage ?? (itemPage = new ItemPage());
        public CheckoutPage CheckoutPage => checkoutPage ?? (checkoutPage = new CheckoutPage());

        public void PurchaseItem(string itemName, CustomerInfo customerInfo)
        {
            HomePage.Navigate("https://ebay.com");
            HomePage.Validate().Logo();
            HomePage.Search(itemName);
            SearchResultPage.Validate().SearchResultCount();
            SearchResultPage.ClickAndSaveSearchResultInfo(0);
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
