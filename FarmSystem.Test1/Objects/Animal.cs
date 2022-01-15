using System;

namespace FarmSystem.Test.Objects
{
    public abstract class Animal
    {
        public Animal()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        protected int NoOfLegs { get; set; }

        protected string Sound { get; set; }

        public void Talk()
        {
            Console.WriteLine($"{GetType().Name} say {Sound}!");            
        }

        public void Run()
        {
            Console.WriteLine($"{GetType().Name} is running.");
        }
    }
}