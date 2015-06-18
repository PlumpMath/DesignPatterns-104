using System;
using System.Collections.Generic;

namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Composite
{
    public class Composite : Component
    {
        private List<Component> _components;

        public Composite(string name) : base(name)
        {
            _components = new List<Component>();
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);

            foreach(Component component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
