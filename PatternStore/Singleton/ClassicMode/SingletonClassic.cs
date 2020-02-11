using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternStore.Singleton.ClassicMode
{
    public class SingletonClassic
    {
        private static object _syncRoot = new object();
        private static SingletonClassic _instance;

        private SingletonClassic()
        {

        }

        public static SingletonClassic GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonClassic();
                    }
                }
            }
            return _instance;
        }

        public void GetDescription()
        {
            Console.WriteLine("I'm classic singleton");
        }
    }
}
