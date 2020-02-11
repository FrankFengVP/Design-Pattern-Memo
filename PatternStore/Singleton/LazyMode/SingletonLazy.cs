using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternStore.Singleton.LazyMode
{
    public class SingletonLazy
    {
        private SingletonLazy()
        {

        }

        public static Lazy<SingletonLazy> Lazy = new Lazy<SingletonLazy>(() => new SingletonLazy(), LazyThreadSafetyMode.ExecutionAndPublication);

        public void GetDescription()
        {
            Console.WriteLine("I'm lazy singleton");
        }
    }
}
