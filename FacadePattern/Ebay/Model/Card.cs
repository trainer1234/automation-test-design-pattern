using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Ebay.Model
{
    public class Card
    {
        public string CardNumber { get; set; }
        public short ExpiryDateMonth { get; set; }
        public short ExpiryDateYear { get; set; }
        public int Cvv2 { get; set; }
        public string CardholderFirstName { get; set; }
        public string CardholderLastName { get; set; }
    }
}
