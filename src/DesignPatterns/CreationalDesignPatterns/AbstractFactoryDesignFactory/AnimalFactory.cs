using static DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesignFactory.Animals;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesignFactory;

internal abstract class AnimalFactory
{
    public abstract IAnimal? GetAnimal(string animalType);

    public static AnimalFactory CreateAnimalFactory(string factoryType)
    {
        return factoryType.Equals("Sea") ? new SeaAnimalFactory() : new LandAnimalFactory();
    }

    private class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal? GetAnimal(string animalType)
        {
            return animalType switch
            {
                "Dog" => new Dog(),
                "Cat" => new Cat(),
                "Lion" => new Lion(),
                _ => null
            };
        }
    }

    private class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal? GetAnimal(string animalType)
        {
            return animalType switch
            {
                "Shark" => new Shark(),
                "Octopus" => new Octopus(),
                _ => null
            };
        }
    }
}
