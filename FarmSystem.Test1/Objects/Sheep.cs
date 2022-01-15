using System;

namespace FarmSystem.Test.Objects
{
    public class Sheep : Animal 
    {
        public Sheep() : base()
        {
            NoOfLegs = 4;
            Sound = "baa";
        }
    }
}