namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryDesignFactory;

internal class Animals
{
    public class Cat : IAnimal
    {
        public string Speak() => "Meow Meow Meow";
    }

    public class Lion : IAnimal
    {
        public string Speak() => "Roar";
    }

    public class Dog : IAnimal
    {
        public string Speak() => "Bark bark";
    }

    public class Octopus : IAnimal
    {
        public string Speak() => "SQUAWCK";
    }

    public class Shark : IAnimal
    {
        public string Speak() => "Cannot Speak";
    }
}
