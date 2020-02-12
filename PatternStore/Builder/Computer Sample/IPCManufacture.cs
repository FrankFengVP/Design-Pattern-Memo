namespace PatternStore.Builder.Computer_Sample
{
    interface IPCManufacture
    {
        ComputerBulder Builder { get; set; }
        IComputer CreateComputer();
    }
}