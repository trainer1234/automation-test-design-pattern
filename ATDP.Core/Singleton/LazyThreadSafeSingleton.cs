using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ATDP.Core.Singleton
{
    public abstract class LazyThreadSafeSingleton<T>
        where T : new()
    {
        private static readonly Lazy<T> instance = new Lazy<T>(() => new T());

        public static T Instance => instance.Value;
    }
}
