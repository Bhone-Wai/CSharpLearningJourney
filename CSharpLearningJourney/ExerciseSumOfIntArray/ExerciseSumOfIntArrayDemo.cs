namespace CSharpLearningJourney.ExerciseSumOfIntArray;

public class ExerciseSumOfIntArrayDemo
{
    public static void Run()
    {
        int[] numbers = new int[]
        {
            1, 2, 3, 4, 5
        };

        if (SumOfNumbers(numbers, out int total))
        {
            Console.WriteLine($"Total: {total}");
        }
        else
        {
            Console.WriteLine("No result");
        } 

        Console.WriteLine();
    }

    /*static int SumOfNumbers(int[] numbers)
    {
        if (numbers.Length > 0)
        {
            int total = 0;

            foreach (var item in numbers)
            {
                total += item;
            }

            return total;
        }

        return -1;
    }*/
    
    static bool SumOfNumbers(int[] numbers, out int total)
    {
        total = 0;
        
        if (numbers.Length > 0)
        {
            foreach (var item in numbers)
            {
                total += item;
            }

            return true;
        }

        return false;
    }
}