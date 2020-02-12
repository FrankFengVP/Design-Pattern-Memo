using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStore.Builder.Computer_Sample
{
    public class ComputerSampleRunner
    {
        public static void Run()
        {
            IPCManufacture dell = new Dell(new LaptopBuilder());
            var computer = dell.CreateComputer();
            computer.Show();

            IPCManufacture lenovo = new Lenovo(new WorkStationBuilder());
            var workStation = lenovo.CreateComputer();
            workStation.Show();
        }
    }
}
