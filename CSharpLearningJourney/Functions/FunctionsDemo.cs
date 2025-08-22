using System.Globalization;

namespace CSharpLearningJourney.Functions;

class Test
{
    public void Something()
    {
        Console.WriteLine("Something");
    }
}

public class FunctionsDemo
{
    public static void Run()
    {
        // Test.Something();
        Test test = new Test();
        test.Something();
        
        
        WelcomeMessage();
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to C# learning journey!");
    }
}