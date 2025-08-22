namespace CSharpLearningJourney.ArrayReversal;

public class ArrayReversalDemo
{
    public static void Run()
    {
        int[] numbers = new int[]
        {
            0, 1, 2, 3, 4, 5
        };
        
        System.Array.Reverse(numbers);

        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
    }
}