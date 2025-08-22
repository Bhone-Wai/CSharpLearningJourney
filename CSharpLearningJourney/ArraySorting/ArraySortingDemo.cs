namespace CSharpLearningJourney.ArraySorting;

public class ArraySortingDemo
{
    public static void Run()
    {
        int[] numbers = new int[]
        {
            2, 3, 0, 1, 1, 8, 9, 4, 5, 6
        };
        
        System.Array.Sort(numbers);

        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
    }
}