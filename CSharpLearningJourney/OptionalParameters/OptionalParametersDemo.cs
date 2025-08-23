using System.Runtime.InteropServices;

namespace CSharpLearningJourney.OptionalParameters;

public class OptionalParametersDemo
{
    public static void Run()
    {
        int result = Add(9);

        Console.WriteLine(result);

        Console.WriteLine(PrintName("Kuzu"));
    }

    static string PrintName(string name = "Bhone Wai")
    {
        return $"My name is {name}";
    }

    static int Add(int x, [Optional] int y)
    {
        Console.WriteLine($"y = {y}");
        return x + y;
    }
}