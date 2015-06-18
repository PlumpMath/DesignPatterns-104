namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Composite
{
    public class Tree
    {
        public void Display()
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf One"));
            root.Add(new Leaf("Leaf Two"));

            Composite comp = new Composite("Composite One");
            comp.Add(new Leaf("Leaf One One"));
            comp.Add(new Leaf("Leaf One Two"));

            root.Add(comp);
            root.Add(new Leaf("Leaf Three"));

            Leaf leaf = new Leaf("Leaf Four");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
        }
    }
}
