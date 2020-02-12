namespace PatternStore.Builder.Computer_Sample
{
    interface IComputer
    {
        void SetCPU(ICPU cpu);
        void SetMemory(IMemory memory);
        void SetHardDisk(IHardDisk hardDisk);
        void SetMonitor(IMonitor monitor);

        void Show();
        string Brand { get; set; }
        string PCType { get; set; }
    }
}