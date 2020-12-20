using ADVT.Core;

namespace AdvancedPageObjectPattern
{
    public class SearchEngineMainPage : BasePage<SearchEngineMainPageElementMap, SearchEngineMainPageValidator>
    {
        public SearchEngineMainPage() 
            : base(@"searchEngineUrl")
        {
        }

        public void Search(string text)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(text);
            Map.GoButton.Click();
        }
    }
}
