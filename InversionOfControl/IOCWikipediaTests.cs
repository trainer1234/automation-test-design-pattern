using System.Configuration;
using ATDP.Core;
using InversionOfControl.Contracts;
using Microsoft.Practices.Unity.Configuration;
using Unity;
using Unity.Lifetime;

namespace InversionOfControl
{
    [TestClass]
    public class IOCWikipediaTests
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void TestWikiContentsToggle()
        {
            var wikiPage = PageFactory.Get<IWikipediaMainPage>();
            wikiPage.Navigate();
            wikiPage.Search("Quality assurance");
            wikiPage.Validate().TocHeader();
            wikiPage.Validate().ContentsListVisible();

            wikiPage.ToggleHideContents();

            wikiPage.Validate().TocDropdownShown();
            wikiPage.Validate().ContentsListHidden();

            wikiPage.ToggleShowContents();

            wikiPage.Validate().TocHeader();
            wikiPage.Validate().ContentsListVisible();
        }
    }
}