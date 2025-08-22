namespace CSharpLearningJourney.NumberSplit;

public class NumberSplitDemo
{
    public static void Run()
    {
        List<int> odd = new List<int>();
        List<int> even = new List<int>();

        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                even.Add(i);
            }
            else
            {
                odd.Add(i);
            }
        }

        foreach (var num in even)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();
        
        foreach (var num in odd)
        {
            Console.Write($"{num} ");
        }
    }
}