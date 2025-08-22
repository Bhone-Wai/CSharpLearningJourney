namespace CSharpLearningJourney.ArrayOfMultiples;

public class ArrayOfMultiplesDemo
{
    public static void Run()
    {
        int num = 7;
        int length = 5;
        int counter = 0;

        int[] result = new int[length];

        for (int i = 1; i <= result.Length; i++, counter++)
        {
            result[counter] = num * i;
        }

        foreach (var item in result)
        {
            Console.Write($"{item} ");
        }
    }
}