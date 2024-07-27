
namespace FactoryMethodPattern.ModifiedImplementation.Factory;

public abstract class IAnimalFactory
{
    public IAnimal MakeAnimal()
    {
        Console.WriteLine("IAnimalFactory.MakeAnimal() - You cannot ignore parent rules.");

        /*
        At this point, it doesn't know whether it will get a Dog or Tiger.
        It will be decided by the subclasses i.e., DogFactory or TigerFactory.
        But it knows that it will Speak and it will have a prefered way of Action.
        */
        IAnimal animal = CreateAnimal();

        animal.Speak();
        animal.Action();

        return animal;
    }

    // So, the following method is acting like a factory (of creation)
    public abstract IAnimal CreateAnimal();
}
