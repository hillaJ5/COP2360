public class Octopus
{
    public readonly string Name;
    public readonly int Legs = 8;

    public Octopus(string name)
    {
        Name = name;
    }

    // Nested class within Octopus
    public class Nested { }

    // Nested enum within Octopus
    public enum Color { Red, Blue, Tan }

    // Example of private member visibility
    private static int x = 42;  // Private member

    public class NestedPrivate
    {
        public static void Foo()
        {
            // Can access the private member of the outer class
            Console.WriteLine(Octopus.x);
        }
    }

    // Example of protected member visibility
    protected class NestedProtected { }
}

// A class that inherits from Octopus to access the protected nested class
public class SubOctopus : Octopus
{
    public SubOctopus(string name) : base(name) { }

    public static void Foo()
    {
        // Can access the protected nested class from a derived class
        new Octopus.NestedProtected();
    }
}

class Program
{
    static void Main()
    {
        // Accessing the nested enum
        Octopus.Color color = Octopus.Color.Red;
        Console.WriteLine($"The octopus color is {color}");

        // Accessing the nested class method that prints the private member
        Octopus.NestedPrivate.Foo();

        // Accessing the protected nested class via inheritance
        SubOctopus.Foo();
    }
}