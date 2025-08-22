namespace CSharpLearningJourney.Lists;

public class ListsDemo
{
    public static void Run()
    {
        int[] numbers = new int[3]
        {
            1, 2, 3
        };

        List<int> listNumbers = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter the number: ");
            listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
        }

        for (int i = 0; i < listNumbers.Count; i++)
        {   
            Console.Write($"{listNumbers[i]} ");
        }

        /*foreach (var num in listNumbers)
        {
            Console.Write($"{num} ");
        }*/
    }
}