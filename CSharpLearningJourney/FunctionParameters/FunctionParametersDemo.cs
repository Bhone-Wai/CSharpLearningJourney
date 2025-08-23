namespace CSharpLearningJourney.FunctionParameters;

public class FunctionParametersDemo
{
    public static void Run()
    {
        Console.WriteLine(Add(9, 10));

        /*int num = ReadInt("number");
        Console.WriteLine(num);
        
        int num2 = ReadInt("angle");
        Console.WriteLine(num2);*/

        /*int firstNum = ReadInt("first number");
        int secondNum = ReadInt("second number");
        int result = Add(firstNum, secondNum);*/
        
        // Console.WriteLine(result);
        string name = ReadString("Enter your name");
        int age = ReadInt("Enter your age");

        string details = UserDetails(name, age);

        Console.WriteLine(details);
    }

    static string UserDetails(string name, int age)
    {
        return $"Username is {name} and age is {age}";
    }

    static string ReadString(string message)
    {
        Console.Write($"{message}: ");
        return Console.ReadLine();
    }

    static int ReadInt(string message)
    {
        Console.Write($"{message}: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}