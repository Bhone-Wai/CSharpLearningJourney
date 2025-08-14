namespace CSharpLearningJourney.StringInterpolation;

public class StringInterpolationDemo
{
    public static void Run()
    {
        string name = "Kuzu";
        int age = 22;

        Console.WriteLine($"Your name is {name} and age is {age}");
        
        string test = string.Concat("Your name is ", name, " and age is ", age);
        Console.WriteLine(test);
    }
}