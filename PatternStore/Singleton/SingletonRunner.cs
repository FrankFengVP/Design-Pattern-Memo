using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternStore.Singleton.ClassicMode;
using PatternStore.Singleton.LazyMode;

namespace PatternStore.Singleton
{
    public class SingletonRunner
    {
        public static void Run()
        {
            SingletonClassic.GetInstance().GetDescription();

            SingletonLazy.Lazy.Value.GetDescription();
        }
    }
}
