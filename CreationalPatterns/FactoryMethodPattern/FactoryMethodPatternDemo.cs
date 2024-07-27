using FactoryMethodPattern.ModifiedImplementation;
using FactoryMethodPattern.ModifiedImplementation.Factory;
// using FactoryMethodPattern.OriginalImplementation;
// using FactoryMethodPattern.OriginalImplementation.Factory;

namespace FactoryMethodPattern;

public class FactoryMethodPatternDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("************************************************************");
        Console.WriteLine("****************** Factory Method Pattern ******************");
        Console.WriteLine("************************************************************");
        Console.WriteLine("\n\n");

        // /*
        // OriginalImplementation
        // */
        // // Creating a Tiger Factory
        // IAnimalFactory tigerFactory = new TigerFactory();

        // // Creating a tiger using the Factory Method
        // IAnimal tiger = tigerFactory.CreateAnimal();

        // // Calling the default methods of IAnimal
        // tiger.Speak();
        // tiger.Action();

        // // Creating a Dog Factory
        // IAnimalFactory dogFactory = new DogFactory();

        // // Creating a dog using the Factory Method
        // IAnimal dog = dogFactory.CreateAnimal();

        // // Calling the default methods of IAnimal
        // dog.Speak();
        // dog.Action();

        /*
        ModifiedImplementation
        Notice that in each case you see the following warning: "... You cannot ignore parent rules."
        */
        // Creating a Tiger Factory
        IAnimalFactory tigerFactory = new TigerFactory();

        // Creating a tiger using the Factory Method
        IAnimal tiger = tigerFactory.MakeAnimal();

        // Creating a Dog Factory
        IAnimalFactory dogFactory = new DogFactory();

        // Creating a dog using the Factory Method
        IAnimal dog = dogFactory.MakeAnimal();
    }
}
