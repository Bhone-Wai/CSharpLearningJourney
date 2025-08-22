namespace CSharpLearningJourney.ReturnTypeFunctions;

public class ReturnTypeFunctionsDemo
{
    // private static string message = "Welcome to the Return Type Functions";
    
    public static void Run()
    {
        // PrintIntroduction();

        int[] numbers = new int[3];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ReadNumberConsole();
        }

        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();

        int[] newNumbers = CreateRandomArray();
        
        foreach (var num in newNumbers)
        {
            Console.Write($"{num} ");
        }
    }

    static int[] CreateRandomArray()
    {
        int[] numbers = new int[3]
        {
            0, 1, 2
        };

        return numbers;
    }
    
    static int ReadNumberConsole()
    {
        Console.Write("Enter a number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static string ReturnMessage()
    {
        return "Welcome to the Return Type Functions";
    }

    static void PrintIntroduction()
    {
        string message = ReturnMessage();
        Console.WriteLine(message);
    }
}