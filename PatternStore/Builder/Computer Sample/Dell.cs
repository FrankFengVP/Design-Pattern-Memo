namespace PatternStore.Builder.Computer_Sample
{
    class Dell : IPCManufacture
    {
        private readonly ComputerBulder _builder;

        public Dell(ComputerBulder builder)
        {
            _builder = builder;
        }
        public ComputerBulder Builder { get; set; }
        public IComputer CreateComputer()
        {
            var product = _builder.CreateComputer();
            product.Brand = "Dell";
            return product;
        }
    }
}