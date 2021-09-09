using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {

        }

        public override void Operation()
        {
            base.Operation();
            NewFeature();
        }

        public void NewFeature()
        {
            Console.WriteLine("This is NewFeature()");
        }
    }
}
