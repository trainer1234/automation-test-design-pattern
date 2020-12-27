using System;
using ATDP.Core;
using FluentAssertions;

namespace FacadePattern.Ebay.Pages.Home
{
    public class HomePageValidator : BasePageValidator<HomePageMap>
    {
        public void Logo()
        {
            Map.Logo.Displayed.Should().BeTrue();
        }
    }
}
