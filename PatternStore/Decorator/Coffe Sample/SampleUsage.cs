using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStore.Decorator.Coffe_Sample
{
    public class SampleUsage
    {
        public static void Run()
        {
            IDrink coffe = new Coffee();
            Decorator sugar = new Sugar(coffe);
            Decorator milk = new MilkCover(sugar);
            Console.WriteLine(milk.Description());
        }
    }
    class Coffee : IDrink
    {
        public decimal GetPrice()
        {
            return 10;
        }

        public string Description()
        {
            return "一杯纯咖啡";
        }
    }
}
