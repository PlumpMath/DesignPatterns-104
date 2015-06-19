using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Decorator
{
    public class NameCardDecorator : Decorator
    {
        private int _discountRate = 5;

        public NameCardDecorator(BakeryComponent baseComponent) : base(baseComponent)
        {
            Name = "Name Card";
            Price = 4.0;
        }

        public override string GetName()
        {
            return string.Format("Please Collect your discount card for {0}%", _discountRate);
        }
    }
}
