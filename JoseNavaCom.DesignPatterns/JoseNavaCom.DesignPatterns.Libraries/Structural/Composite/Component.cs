namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Composite
{
    public abstract class Component
    {
        protected string Name;

        public Component(string name)
        {
            Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }
}
