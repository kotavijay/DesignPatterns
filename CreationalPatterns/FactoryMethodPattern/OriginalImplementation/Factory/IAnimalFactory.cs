namespace FactoryMethodPattern.OriginalImplementation.Factory;

public abstract class IAnimalFactory
{
    /*
    Remember the GOF definition which says "... Factory method lets a class defer instantiation to subclasses."
    Following method will create a Tiger or Dog but at this point it does not know whether it will get a Dog or a Tiger.
    It will be decided by the subclasses i.e., DogFactory or TigerFactory.
    So, the following method is acting like a factory (of creation).
    */

    public abstract IAnimal CreateAnimal();
}
