using ATDP.Core;
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
            SearchEngineMainPage.Instance.Navigate()
                .Search("hello")
                .Validate(SearchEngineMainPage.Instance).ResultsCount("Results")
                .ClickImagesTab()
                .ClickFilterButton()
                .SetSize()
                .SetColor()
                .SetTypes()
                .SetPeople()
                .SetDate()
                .SetLicense();
        }
    }
}
