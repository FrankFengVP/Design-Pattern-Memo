namespace PatternStore.Decorator.Coffe_Sample
{
    class Sugar : Decorator
    {
        public Sugar(IDrink drink) : base(drink)
        {
        }

        public override string Description()
        {
            return base.Description() + "╪слг";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + (decimal)1.5;
        }
    }
}