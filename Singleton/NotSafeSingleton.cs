using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class NotSafeSingleton
    {
        static NotSafeSingleton _instance;
        protected NotSafeSingleton()
        {
        }
        public static NotSafeSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new NotSafeSingleton();
            }
            return _instance;
        }
    }
}
