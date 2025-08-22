namespace CSharpLearningJourney.ArrayClearing;

public class ArrayClearingDemo
{
    public static void Run()
    {
        int[] numbers = new int[]
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        };
        
        System.Array.Clear(numbers, 5, 5);

        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }
    }
}