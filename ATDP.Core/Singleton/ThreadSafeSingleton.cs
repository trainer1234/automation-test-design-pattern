using System;
using System.Collections.Generic;
using System.Text;

namespace ATDP.Core.Singleton
{
    public abstract class ThreadSafeSingleton<T>
        where T : new()
    {
        private static T instance;
        private static readonly object lockObject = new object();

        private ThreadSafeSingleton()
        {
            
        }

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null) instance = new T();
                    }
                }

                return instance;
            }
        }
    }
}
