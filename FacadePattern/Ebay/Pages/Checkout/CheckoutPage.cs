using System;
using ATDP.Core;
using FacadePattern.Ebay.Model;
using FluentAssertions;
using OpenQA.Selenium.Support.UI;

namespace FacadePattern.Ebay.Pages.Checkout
{
    public class CheckoutPage : BasePage<CheckoutPageMap, CheckoutPageValidator>
    {
        public void FillInShippingInfo(CustomerInfo customerInfo)
        {
            new SelectElement(Map.ShippingCountry).SelectByValue(customerInfo.CountryCode2);
            Map.IsSpinnerNotDisplayed.Should().BeTrue();
            Map.ShippingFirstName.SendKeys(customerInfo.FirstName);
            Map.ShippingLastName.SendKeys(customerInfo.LastName);
            Map.ShippingAddress.SendKeys(customerInfo.StreetAddress1);
            Map.ShippingAddress2.SendKeys(customerInfo.StreetAddress2);
            Map.ShippingCity.SendKeys(customerInfo.City);
            Map.ShippingState.SendKeys(customerInfo.State);
            Map.ShippingZipCode.SendKeys(customerInfo.ZipCode);
            Map.ShippingEmail.SendKeys(customerInfo.Email);
            Map.ShippingConfirmEmail.SendKeys(customerInfo.Email);
            //Map.ShippingTelephoneCode.Click();
            //new SelectElement(Map.ShippingTelephoneCode).SelectByValue(customerInfo.CountryCode2.ToLower());
            Map.ShippingPhoneNumber.SendKeys(customerInfo.PhoneNumber);
            Map.AddShippingAddressButton.Click();
            Map.IsSpinnerNotDisplayed.Should().BeTrue();
        }

        public void PayWith(PaymentMethod paymentMethod = PaymentMethod.Card, CustomerInfo customerInfo = null)
        {
            if (paymentMethod == PaymentMethod.Card)
            {
                if (customerInfo == null) 
                    throw new ArgumentNullException(nameof(customerInfo), "Card details and customer info must be provided for Card payment method");
                if (customerInfo.Card == null)
                    throw new ArgumentNullException(nameof(customerInfo.Card), "Card details and customer info must be provided for Card payment method");

            }

            switch (paymentMethod)
            {
                case PaymentMethod.Card:
                    var billingAdress = $"{customerInfo.FirstName} {customerInfo.LastName}, {customerInfo.StreetAddress1}, {customerInfo.StreetAddress2}, {customerInfo.City}, {customerInfo.State} {customerInfo.ZipCode}, {CountryCode.ToDict()[customerInfo.CountryCode2]}";
                    var cardInfo = customerInfo.Card;

                    Map.PayWithCardRadioButton.Click();
                    Map.CardNumber.SendKeys(cardInfo.CardNumber);
                    Map.CardExpiryDate.SendKeys(cardInfo.ExpiryDateMonth.ToString() + cardInfo.ExpiryDateYear);
                    Map.CardSecurityCode.SendKeys(cardInfo.Cvv2.ToString());
                    Map.CardHolderFirstName.Clear();
                    Map.CardHolderFirstName.SendKeys(cardInfo.CardholderFirstName);
                    Map.CardHolderLastName.Clear();
                    Map.CardHolderLastName.SendKeys(cardInfo.CardholderLastName);
                    Map.BillingAddress.Text.Should().Be(billingAdress);
                    Map.AddCardButton.Click();
                    Map.IsSpinnerNotDisplayed.Should().BeTrue();
                    break;
                default:
                    break;
            }
        }

        public void ConfirmAndPay()
        {
            Map.ConfirmAndPayButton.Click();
        }
    }
}
