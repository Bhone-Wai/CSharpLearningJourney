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

        Console.WriteLine(Add());
    }

    static void Something()
    {
        // Conversion
        // Calculation
    }

    static void Conversion()
    {
        
    }

    static void Calculation()
    {
        
    }

    static int Add()
    {
        return 5 + 5;
    }

    static int[] CreateRandomArray()
    {
        return new int[3] { 1, 2, 3 };
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