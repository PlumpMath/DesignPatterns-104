namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Flyweight
{
    public class Shapes
    {
        public IShape GetFromName(string name)
        {
            ShapeObjectFactory factory = new ShapeObjectFactory();
            IShape shape = factory.GetShape("Rectangle");
            return shape;
        }
    }
}
