namespace FactoryMethodPattern.ModifiedImplementation.Factory;

public class DogFactory : IAnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        // Creating a Dog instance
        return new Dog();
    }
}
