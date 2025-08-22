namespace CSharpLearningJourney.ArrayIndexOf;

public class ArrayIndexOfDemo
{
    public static void Run()
    {
        int[] numbers = new int[]
        {
            90, 12, 69, 101, 7, 21
        };
        
        Console.Write("Enter the number you want to search: ");
        int search = Convert.ToInt32(Console.ReadLine());

        int position = System.Array.IndexOf(numbers, search);

        if (position > -1)
        {
            Console.WriteLine($"Number {search} has been found at position {position + 1}");
        }
        else
        {
            Console.WriteLine($"Number {search} has not been found");
        }
    }
}