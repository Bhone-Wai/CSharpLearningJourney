namespace CSharpLearningJourney.Array;

public class ArrayDemo
{
    public static void Run()
    {
        // int[] numbers = new int[4];
        /*numbers[0] = 5;
        numbers[1] = 10;
        numbers[2] = 15;*/

        /*Console.Write("Enter a number: ");
        numbers[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number: ");
        numbers[1] = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter a number: ");
        numbers[2] = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter a number: ");
        numbers[3] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}");*/

        int[] numbers = new int[4];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        /*for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }*/

        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
    }
}