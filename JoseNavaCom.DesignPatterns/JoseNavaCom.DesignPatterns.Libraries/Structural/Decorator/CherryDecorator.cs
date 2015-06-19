namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Decorator
{
    public class CherryDecorator : Decorator
    {
        public CherryDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            Name = "Cherry";
            Price = 2.0;
        }
    }
}
