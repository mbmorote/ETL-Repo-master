using System;

namespace FarmSystem.Test.Objects
{
    public class Horse: Animal
    {        
        public Horse() : base()
        {
            NoOfLegs = 4;
            Sound = "neigh";
        }        
    }
}