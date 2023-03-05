using FacadePattern.Ebay.Pages.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl.Contracts
{
    public interface IWikipediaMainPage
    {
        void Navigate(string part = "");
        WikipediaMainPageValidator Validate();
        void Search(string searchTerm);
        void ToggleHideContents();
        void ToggleShowContents();
    }
}
