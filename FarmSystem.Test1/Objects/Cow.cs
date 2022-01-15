using FarmSystem.Test2;
using System;

namespace FarmSystem.Test.Objects
{
    public class Cow: Animal, IMilkableAnimal
    {
        public Cow() : base()
        {
            NoOfLegs = 4;
            Sound = "Moo";
        }

        public void Walk()
        {
            Console.WriteLine($"{GetType().Name} is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine($"{GetType().Name} was milked");
        }
    }
}