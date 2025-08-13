namespace CSharpLearningJourney.ConditionalOperator;

public class CondationalOperatorDemo
{
    public static void Run()
    {
        int age = 22;
        
        string result = age >= 0 ? "Valid" : "Invalid";
        Console.WriteLine(result);
    }
}