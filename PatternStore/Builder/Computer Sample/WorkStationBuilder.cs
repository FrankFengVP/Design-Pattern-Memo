namespace PatternStore.Builder.Computer_Sample
{
    class WorkStationBuilder : ComputerBulder
    {
        protected override void BuildCPU(ICPU cpu)
        {
            this.ComputerProduct.SetCPU(cpu);
        }

        protected override void BuildMemory(IMemory memory)
        {
            this.ComputerProduct.SetMemory(memory);
        }

        protected override void BuildHardDisk(IHardDisk hardDisk)
        {
            this.ComputerProduct.SetHardDisk(hardDisk);
        }

        protected override void BuildMonitor(IMonitor monitor)
        {
            this.ComputerProduct.SetMonitor(monitor);
        }
        public override IComputer CreateComputer()
        {
            this.BuildCPU(new AmdCpu());
            this.BuildMemory(new KinstonMemory());
            this.BuildHardDisk(new SumsungHardDisk());
            this.BuildMonitor(new Aoc());
            this.ComputerProduct.PCType = "Laptop";
            return base.CreateComputer();
        }
    }
}