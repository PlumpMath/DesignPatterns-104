namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Decorator
{
    public class ArtificialScentDecorator : Decorator
    {
        public ArtificialScentDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            Name = "Artificial Scent";
            Price = 3.0;
        }
    }
}
