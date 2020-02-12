using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //装饰模式 - 咖啡
            PatternStore.Decorator.Coffe_Sample.SampleUsage.Run();

            //单例模式
            PatternStore.Singleton.SingletonRunner.Run();

            //建造者模式
            PatternStore.Builder.Computer_Sample.ComputerSampleRunner.Run();
        }
    }
}
