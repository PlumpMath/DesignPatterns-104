namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Decorator
{
    public abstract class Decorator : BakeryComponent
    {
        private readonly BakeryComponent _baseComponent;

        protected string Name = "Undefined Decorator";
        protected double Price = 0.0;

        protected Decorator(BakeryComponent baseComponent)
        {
            _baseComponent = baseComponent;
        }

        public override string GetName()
        {
            return string.Format("{0}, {1}", _baseComponent.GetName(), Name);
        }

        public override double GetPrice()
        {
            return Price + _baseComponent.GetPrice();
        }
    }
}
