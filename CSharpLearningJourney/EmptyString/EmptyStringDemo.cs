namespace CSharpLearningJourney.EmptyString;

public class EmptyStringDemo
{
    public static void Run()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (name != string.Empty)
        {
            Console.WriteLine($"Your name is {name}");
        }
        else
        {
            Console.WriteLine("Your name is empty");
        }
    }
}