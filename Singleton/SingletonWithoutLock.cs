using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonWithoutLock
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly SingletonWithoutLock instance = new SingletonWithoutLock();

        private SingletonWithoutLock()
        {

        }

        public static SingletonWithoutLock GetSingletonWithoutLock()
        {
            return instance;
        }
    }
}
