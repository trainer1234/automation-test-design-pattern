using System;
using ATDP.Core;
using FluentAssertions;

namespace FacadePattern.Ebay.Pages.Home
{
    public class WikipediaMainPageValidator : BasePageValidator<WikipediaMainPageMap>
    {

        public void TocHeader()
        {
            Map.TocHeader.Displayed.Should().BeTrue();
            Map.TocToggleHideButton.Displayed.Should().BeTrue();
        }

        public void ContentsListVisible()
        {
            Map.TocList.Displayed.Should().BeTrue();
        }

        public void TocDropdownShown()
        {
            Map.TocDropdown.Displayed.Should().BeTrue();
        }

        public void ContentsListHidden()
        {
            Map.TocList.Displayed.Should().BeFalse();
        }
    }
}
