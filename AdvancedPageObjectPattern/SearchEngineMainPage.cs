using ATDP.Core;

namespace AdvancedPageObjectPattern
{
    public class SearchEngineMainPage : BasePage<SearchEngineMainPageElementMap, SearchEngineMainPageValidator>
    {
        public void Search(string text)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(text);
            Map.GoButton.Click();
        }
    }
}
