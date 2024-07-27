namespace SingletonPattern;

// Sealed keyword. So, we cannot inhert the class.
public class SingletonPatternDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("************************************************************");
        Console.WriteLine("******************** Singleton Pattern *********************");
        Console.WriteLine("************************************************************");
        Console.WriteLine("\n\n");

        // Private constructor. So, we cannot use 'new' keyword.
        Console.WriteLine("Trying to create instance s1.");
        Singleton s1 = Singleton.Instance;

        Console.WriteLine("Trying to create instance s2.");
        Singleton s2 = Singleton.Instance;

        if (s1 == s2)
        {
            Console.WriteLine("Only one instance exists.");
        }
        else
        {
            Console.WriteLine("Different instances exists.");
        }
    }
}