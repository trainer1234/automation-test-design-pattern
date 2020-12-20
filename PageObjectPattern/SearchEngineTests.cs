using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PageObjectPattern
{
    [TestFixture]
    public class SearchEngineTests
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [SetUp]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }

        [TearDown]
        public void TearDown()
        {
            this.Driver.Quit();
        }

        [Test]
        public void SearchTextInSearchEngine_Second()
        {
            SearchEngineMainPage page = new SearchEngineMainPage(Driver);
            page.Navigate();
            page.Search("hello");
            page.Validate().ResultsCount("204,000 RESULTS");
        }
    }
}
