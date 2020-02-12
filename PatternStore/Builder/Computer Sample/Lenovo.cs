namespace PatternStore.Builder.Computer_Sample
{
    class Lenovo : IPCManufacture
    {
        private readonly ComputerBulder _builder;

        public Lenovo(ComputerBulder builder)
        {
            _builder = builder;
        }
        public ComputerBulder Builder { get; set; }
        public IComputer CreateComputer()
        {
            var product = _builder.CreateComputer();
            product.Brand = "Lenovo";
            return product;
        }
    }
}