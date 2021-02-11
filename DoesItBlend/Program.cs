using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    /// <summary>
    /// A program that asks the question, does it blend?
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point to the program
        /// </summary>
        /// <param name="args">A list of command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Does it blend?");

            List<Fruit> fruits = new List<Fruit>();
            fruits.Add(new Banana());
            fruits.Add(new Strawberry());
            fruits.Add(new Mango());
            fruits.Add(new Apple());
            fruits.Add(new OveripeBanana());

            Console.WriteLine("As Fruits: ");
            foreach(var fruit in fruits)
            {
                Console.Write(fruit.Blend());
                Console.WriteLine($" ({fruit.Age})");
            }

            Console.WriteLine("Dynamically: ");
            foreach (dynamic fruit in fruits)
            {
                Console.WriteLine(fruit.Blend());
            }

            /*
            List<Object> objects = new List<Object>(fruits);
            objects.Add(new ConcreteBlock());

            Console.WriteLine("Objects Dynamically: ");
            foreach (dynamic obj in objects)
            {
                Console.WriteLine(obj.Blend());
            }
            */

            List<IBlendable> blendables = new List<IBlendable>(fruits);
            blendables.Add(new CellPhone());
            blendables.Add(new IceCubes());

            Console.WriteLine("IBlendables: ");
            foreach (IBlendable blendable in blendables)
            {
                Console.WriteLine(blendable.Blend());
            }

        }
    }
}
