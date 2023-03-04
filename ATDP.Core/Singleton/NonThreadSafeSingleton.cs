using System;
using System.Collections.Generic;
using System.Text;

namespace ATDP.Core.Singleton
{
    public abstract class NonThreadSafeSingleton<T>
        where T : new()
    {
        private static T instance;
        private NonThreadSafeSingleton()
        {
        }

        public static T Instance 
        {
            get 
            { 
                if (instance == null) instance = new T();
                return instance;
            }
        }
    }
}
