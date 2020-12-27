using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ATDP.Core
{
    public static class DataContext
    {
        private static Dictionary<object, object> dataPool;

        public static Dictionary<object, object> DataPool => dataPool ?? (dataPool = new Dictionary<object, object>());
    }
}
