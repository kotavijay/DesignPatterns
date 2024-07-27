namespace FactoryMethodPattern.ModifiedImplementation.Factory;

public class TigerFactory : IAnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        // Creating a Tiger instance
        return new Tiger();
    }
}
