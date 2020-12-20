using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace ADVT.Core
{
    public class BasePageValidator<M> where M : BasePageElementMap, new()
    {
        protected M Map => new M();
    }
}
