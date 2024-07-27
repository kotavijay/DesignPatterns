using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.ConcreteFactory;

namespace AbstractFactoryPattern;

public class AbstractFactoryPatternDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("************************************************************");
        Console.WriteLine("***************** Abstract Factory Pattern *****************");
        Console.WriteLine("************************************************************");
        Console.WriteLine("\n\n");

        // Making a wild dog through WildAnimalFactory
        IAnimalFactory wildAnimalFactory = new WildAnimalFactory();

        IDog wildDog = wildAnimalFactory.GetDog();
        wildDog.Speak();
        wildDog.Action();

        // Making a wild tiger through WildAnimalFactory
        ITiger wildTiger = wildAnimalFactory.GetTiger();
        wildTiger.Speak();
        wildTiger.Action();

        Console.WriteLine("\n************************************************************\n");

        // Making a pet dog through PetAnimalFactory
        IAnimalFactory petAnimalFactory = new PetAnimalFactory();

        IDog petDog = petAnimalFactory.GetDog();
        petDog.Speak();
        petDog.Action();

        // Making a pet tiger through PetAnimalFactory
        ITiger petTiger = petAnimalFactory.GetTiger();
        petTiger.Speak();
        petTiger.Action();
    }
}
