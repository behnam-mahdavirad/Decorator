using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent concrete = new ConcreteComponent();

            //concrete.Operation();

            ConcreteDecorator concreteDecorator= new ConcreteDecorator(concrete);
            concreteDecorator.Operation();

            Console.ReadLine();
        }
    }
}
