namespace CSharpLearningJourney.NamedParameters;

public class NamedParametersDemo
{
    public static void Run()
    {
        string nameInput = "Bhone Wai";
        int ageInput = 22;
        string addresInputs = "Bangkok";
        
        PrintDetails(age: ageInput, name: nameInput, address: addresInputs);
    }

    static void PrintDetails(string name, int age, string address)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
    }
}