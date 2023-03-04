using ATDP.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace FacadePattern.Ebay.Pages.Checkout
{
    public class CheckoutPageMap : BasePageElementMap
    {
        public IWebElement Subtotal => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector(".summary-item tr[data-test-id='SUB_TOTAL'] .amount")));
        public IWebElement Shipping => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector(".summary-item tr[data-test-id='SHIPPING'] .amount")));
        public IWebElement Total => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector(".summary-item tr[data-test-id='TOTAL'] .amount")));
        public IWebElement ConfirmAndPayButton => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector("button[data-test-id='CONFIRM_AND_PAY_BUTTON']")));
        public bool IsSpinnerNotDisplayed => Driver.BrowserWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("checkout-spinner--wrapper")));

        

        public IWebElement ItemReviewTitle => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector("div[data-test-id='CART_DETAILS_SELLER_BUCKET'] .item-details-section .item-title")));
        public IWebElement ItemReviewPrice => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector("div[data-test-id='CART_DETAILS_SELLER_BUCKET'] .price-details")));

        public SelectElement ShippingCountry => new SelectElement(Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("country"))));
        public IWebElement ShippingFirstName => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("firstName")));
        public IWebElement ShippingLastName => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("lastName")));
        public IWebElement ShippingAddress => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("addressLine1")));
        public IWebElement ShippingAddress2 => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("addressLine2")));
        public IWebElement ShippingCity => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("city")));
        public IWebElement ShippingState => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("stateOrProvince")));
        public IWebElement ShippingZipCode => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("postalCode")));
        public IWebElement ShippingEmail => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("email")));
        public IWebElement ShippingConfirmEmail => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("emailConfirm")));
        public IWebElement ShippingTelephoneCode => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("phoneCountryCode")));
        public IWebElement ShippingUSTelephoneCode => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("listbox_btn_us_0")));
        public IWebElement ShippingPhoneNumber => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("phoneNumber")));
        public IWebElement AddShippingAddressButton => Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-test-id='ADD_ADDRESS_SUBMIT']")));

        public IWebElement PayWithCardRadioButton =>
            Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div[data-test-id='PAYMENT_METHODS_PAYMENT_METHOD_SELECTION']")));
        public IWebElement CardNumber => Driver.BrowserWait.Until(d =>
            d.FindElement(By.Id("cardNumber")));
        public IWebElement CardExpiryDate => Driver.BrowserWait.Until(d =>
            d.FindElement(By.Id("cardExpiryDate")));
        public IWebElement CardSecurityCode => Driver.BrowserWait.Until(d =>
            d.FindElement(By.Id("securityCode")));
        public IWebElement CardHolderFirstName => Driver.BrowserWait.Until(d =>
            d.FindElement(By.Id("cardHolderFirstName")));
        public IWebElement CardHolderLastName => Driver.BrowserWait.Until(d =>
            d.FindElement(By.Id("cardHolderLastName")));
        public IWebElement BillingAddress => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector(".billing-summary .text-display span")));
        public IWebElement AddCardButton => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector("#credit-card-details button[data-test-id='ADD_CARD']")));

        public IWebElement Coupon => Driver.BrowserWait.Until(d =>
            d.FindElement(By.Id("redemptionCode")));
        public IWebElement ApplyCouponButton => Driver.BrowserWait.Until(d =>
            d.FindElement(By.CssSelector("button[data-test-id='INCENTIVES_ADD_BUTTON']")));
    }
}
