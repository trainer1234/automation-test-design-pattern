using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ATDP.Core
{
    public static class DataContext
    {
        private static Dictionary<object, object> _dataPool;

        public static Dictionary<object, object> DataPool => _dataPool ??= new Dictionary<object, object>();
    }
}
