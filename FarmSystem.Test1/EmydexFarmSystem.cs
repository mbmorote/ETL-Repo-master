using FarmSystem.Test.Objects;
using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private readonly Queue<Animal> _animals;
        
        public EmydexFarmSystem()
        {
            _animals = new Queue<Animal>();
        }       

        //TEST 1
        public void Enter(Animal animal)
        {   
            _animals.Enqueue(animal);
            Console.WriteLine($"{animal.GetType().Name} has entered the Emydex farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (Animal animal in _animals)
            {
                animal.Talk();
            };            
        }

        //TEST 3
        public void MilkAnimals()
        {                        
            foreach (IMilkableAnimal milkable in _animals.Where(a => a is IMilkableAnimal))
            {
                milkable.ProduceMilk();
            }                               
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            for (int i = _animals.Count(); i > 0  ; i--)
            {
              Animal animal = _animals.Dequeue();
              Console.WriteLine($"{animal.GetType().Name} has left the farm");
            }

            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}