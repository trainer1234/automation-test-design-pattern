using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace ATDP.Core
{
    public class BaseFluentPageValidator<S, M, V>
        where S : BaseFluentPageSingletonDerived<S, M, V>
        where M : BasePageElementMap, new()
        where V : BaseFluentPageValidator<S, M, V>, new()
    {
        protected S PageInstance;
        
        public BaseFluentPageValidator()
        {
        }

        public void PassPageInstance(S currentPageInstance)
        {
            PageInstance = currentPageInstance;
        }

        protected M Map => new M();
    }

    public class BasePageValidator<M> where M : BasePageElementMap, new()
    {
        protected M Map => new M();
    }


}
