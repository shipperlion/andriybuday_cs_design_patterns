using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            IToyFactory factory = new WoodenToyFactory();
            Bear bear = factory.GetBear();
            Cat cat = factory.GetCat();
            Console.WriteLine("I've got a bear made of {0} and a cat made of {1}", bear.Material, cat.Material);
            // testing different concrete factories

            factory = new TeddyToyFactory();
            bear = factory.GetBear();
            cat = factory.GetCat();
            Console.WriteLine("I've got a bear made of {0} and a cat made of {1}", bear.Material, cat.Material);
        }
    }
}
