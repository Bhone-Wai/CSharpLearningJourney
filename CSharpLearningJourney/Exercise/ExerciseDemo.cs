namespace CSharpLearningJourney.Exercise;

public class ExerciseDemo
{
    public static void Run()
    {
        var name = "Bhone Wai";
        var age = 22;
        var phoneNo = 800932347;

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(phoneNo);

        int num1 = 10;
        int num2 = 3;
        int remainder = num1 % num2;
        Console.WriteLine(remainder);

        num1 = 11;
        remainder = num1 % num2;
        Console.WriteLine(remainder);
    }
}