namespace CSharpLearningJourney.StringFormatting;

public class StringFormattingDemo
{
    public static void Run()
    {
        string name = "Kuzu";
        int age = 22;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);

        Console.WriteLine();

        Console.WriteLine("Name: " + name + "\nAge: " + age);

        Console.WriteLine("My name is {0} and my age is {1}", name, age);
        Console.WriteLine("Name: {0}\nAge: {1}", name, age);
    }
}