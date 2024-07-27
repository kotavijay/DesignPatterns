namespace FactoryMethodPattern.OriginalImplementation;

public class Tiger : IAnimal
{
    public void Action()
    {
        Console.WriteLine("Tigers prefer hunting...\n");
    }

    public void Speak()
    {
        Console.WriteLine("Tiger says: Halum.");
    }
}
