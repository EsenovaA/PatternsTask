using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonWithLock
    {
        static SingletonWithLock instance;

        private static object locker = new object();

        protected SingletonWithLock()
        {

        }

        public static SingletonWithLock GetSingletonWithLock()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SingletonWithLock();
                    }
                }
            }
            return instance;
        }
    }
}
