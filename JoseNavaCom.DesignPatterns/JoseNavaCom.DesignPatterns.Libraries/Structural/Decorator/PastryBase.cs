namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Decorator
{
    public class PastryBase : BakeryComponent
    {
        private string _name = "Pastry Base";
        private double _price = 20.0;

        public override string GetName()
        {
            return _name;
        }

        public override double GetPrice()
        {
            return _price;
        }
    }
}
