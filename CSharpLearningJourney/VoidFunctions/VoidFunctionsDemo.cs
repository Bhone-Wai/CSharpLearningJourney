namespace CSharpLearningJourney.VoidFunctions;

public class VoidFunctionsDemo
{
    public static void Run()
    {
       /*bool success = int.TryParse("123", out int result);
       Console.WriteLine(success);*/
       
       CreateAndPrintArray();
    }

    static void CreateAndPrintArray()
    {
        int[] numbers = new int[5] {  1, 2, 3, 4, 5 };
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}