using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Ebay.Model
{
    public class ItemInfo
    {
        public string Name { get; set; }
        public string BasePrice { get; set; }
        public string ConvertedPrice { get; set; }
    }
}
