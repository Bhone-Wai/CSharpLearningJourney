namespace CSharpLearningJourney.ReferenceParameters;

public class ReferenceParametersDemo
{
    public static void Run()
    {
        /*int num = 10;
        string name = "Bhone Wai";
        Assign(ref num, ref name);
        Console.WriteLine(num);
        Console.WriteLine(name);*/
        string name = "Bhone Wai";

        Console.Write("Enter your new name: ");
        string newName = Console.ReadLine();

        if (ChangeName(ref name, newName))
        {
            Console.WriteLine($"Your new name is {name}");
        }
        else
        {
            Console.WriteLine("New name could not be empty");
        }
    }

    static bool ChangeName(ref string name, string newName)
    {
        if (!string.IsNullOrEmpty(newName))
        {
            name = newName;
            return true;
        }

        return false;
    }

    static void Assign(ref int num, ref string name)
    {
        // name = "Kuzu";
        num = 21;
    }
}