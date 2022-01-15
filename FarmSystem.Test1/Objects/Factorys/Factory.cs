using FarmSystem.Test.Objects;

namespace FarmSystem.Test1
{
    public enum AnimalEnum {Cow, Horse, Hen, Sheep};

    public static class AnimalFactory
    {
        public static Animal GetAnimal(AnimalEnum animal) 
        {
            switch (animal)
            {
                case AnimalEnum.Cow:
                    return new Cow();
                case AnimalEnum.Horse:
                    return new Horse();
                case AnimalEnum.Hen:
                    return new Hen();
                case AnimalEnum.Sheep:
                    return new Sheep();
                default:
                    throw new System.Exception("Unknown Animal");
            }
        }
    }
}
