using ATDP.Core;
using FacadePattern.Ebay.Facades;
using FacadePattern.Ebay.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace FacadePattern.Test.Purchase
{
    [TestClass]
    public class EbayPurchaseAsGuestTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Driver.StartBrowser();
        }

        [TestMethod]
        public void PurchaseItem()
        {
            var customerInfo = new CustomerInfo
            {
                FirstName = "Minh",
                LastName = "Kha",
                City = "London",
                State = "London",
                CountryCode2 = "GB",
                StreetAddress1 = "xxx yyy zzz",
                StreetAddress2 = "aaa bbb ccc",
                Email = "abc@gmail.com",
                PhoneNumber = "0123456789",
                ZipCode = "70000",
                Card = new Card
                {
                    CardNumber = "4111111111111111",
                    ExpiryDateMonth = 12,
                    ExpiryDateYear = 22,
                    Cvv2 = 123,
                    CardholderFirstName = "Minh",
                    CardholderLastName = "Kha"
                }
            };
            PurchaseFacade purchaseFacade = new PurchaseFacade();
            purchaseFacade.PurchaseItem("I HAD THAT SAME DREAM AGAIN", customerInfo);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Driver.StopBrowser();
        }
    }
}
