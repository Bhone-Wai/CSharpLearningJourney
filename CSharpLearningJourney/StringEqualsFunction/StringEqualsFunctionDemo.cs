namespace CSharpLearningJourney.StringEqualsFunction;

public class StringEqualsFunctionDemo
{
    public static void Run()
    {
        string message = "Hello";
        string compare = "Hello";

        if (message == compare)
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Different");
        }

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        if (!name.Equals(""))
        {
            Console.WriteLine($"Your name is {name}");
        }
        else
        {
            Console.WriteLine("Invalidate name input");
        }
        
        char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
        object newCompare = new string(chars);

        if (message.Equals(newCompare))
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Different");
        }
    }
}