namespace CSharpLearningJourney.ConsoleIO;

public class ConsoleIODemo
{
    public static void Run()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();
        int age = Convert.ToInt32(ageInput);
        
        Console.Write("Your name is " + name + " nad your age is " + age);
    }
}