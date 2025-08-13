namespace CSharpLearningJourney.Operations;

public class OperationsDemo
{
    public static void Run()
    {
        double age = 22;

        // + - * /

        age++;
        age = age + 1;
        age += 1;
        age -= 1;
        age *= 1;
        age /= 10;
        Console.WriteLine(age);

        age--;
        Console.WriteLine(age);

        string name = "Mda";
        name += " is coding";

        Console.WriteLine(name);

        char ch = 'a';
        ch += 'b';
        Console.WriteLine(ch);

        int i = 0;
        Console.WriteLine(i++);
        Console.WriteLine(i);

        Console.WriteLine(++i);
        Console.WriteLine(i);
    }
}