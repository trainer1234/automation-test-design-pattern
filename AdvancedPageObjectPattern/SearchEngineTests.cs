using ADVT.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdvancedPageObjectPattern
{
    [TestClass]
    public class SearchEngineTests
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void SearchTextInSearchEngine_Second()
        {
            SearchEngineMainPage page = new SearchEngineMainPage();
            page.Navigate();
            page.Search("hello");
            page.Validate().ResultsCount("204,000 RESULTS");
        }
    }
}
