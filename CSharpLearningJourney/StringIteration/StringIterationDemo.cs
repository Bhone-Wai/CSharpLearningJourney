namespace CSharpLearningJourney.StringIteration;
using System.Threading;

public class StringIterationDemo
{
    public static void Run()
    {
        string message = "C# is awesome";

        /*Console.WriteLine(message[0]);
        Console.WriteLine(message[1]);
        Console.WriteLine(message[2]);
        Console.WriteLine(message[3]);*/

        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
            Thread.Sleep(100);
        }
        
        Console.WriteLine();

        Console.WriteLine(message.Contains("C"));

        bool contains = false;

        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] == 'C')
            {
                contains = true;
            }
        }
        
        Console.WriteLine(contains);
    }
}