using System;

namespace PatternStore.Builder.Computer_Sample
{
    class Computer : IComputer
    {
        private ICPU CPU;
        private IMemory Memory;
        private IHardDisk HardDisk;
        private IMonitor Monitor;

        public void SetCPU(ICPU cpu)
        {
            this.CPU = cpu;
        }

        public void SetMemory(IMemory memory)
        {
            this.Memory = memory;
        }

        public void SetHardDisk(IHardDisk hardDisk)
        {
            this.HardDisk = hardDisk;
        }

        public void SetMonitor(IMonitor monitor)
        {
            this.Monitor = monitor;
        }

        public void Show()
        {
            Console.WriteLine($"I'm {Brand} {PCType}");
        }

        public string Brand { get; set; }
        public string PCType { get; set; }
    }
}