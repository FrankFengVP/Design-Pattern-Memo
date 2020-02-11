namespace PatternStore.Decorator.Coffe_Sample
{
    abstract class Decorator : IDrink
    {
        private readonly IDrink _drink;

        public Decorator(IDrink drink)
        {
            _drink = drink;
        }

        public virtual decimal GetPrice()
        {
            return _drink.GetPrice();
        }

        public virtual string Description()
        {
            return _drink.Description();
        }
    }
}