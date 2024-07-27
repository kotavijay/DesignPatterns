namespace SingletonPattern;

public sealed class Singleton
{
    // Ensure a class has only one instance, and provide a global point of access to it.
    // Creating a single instance.
    // Thread safe as this will be created once.
    private static readonly Singleton _instance = new Singleton();
    private int numberOfInstances = 0;

    // Private constructor is used to prevent creation of instances with 'new' keyword outside this class.
    // Private constructor will be executed once.
    private Singleton()
    {
        numberOfInstances++;
        Console.WriteLine("Instantiating inside the private constructor.");
        Console.WriteLine($"Number of instances created {numberOfInstances}.");
    }

    public static Singleton Instance
    {
        get
        {
            Console.WriteLine("We already have an instance now. Use it.");
            return _instance;
        }
    }
}