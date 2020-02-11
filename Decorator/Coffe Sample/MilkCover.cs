namespace PatternStore.Decorator.Coffe_Sample
{
    class MilkCover : Decorator
    {
        public MilkCover(IDrink drink) : base(drink)
        {
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 6;
        }

        public override string Description()
        {
            return base.Description() + "╪сдл╦г";
        }
    }
}