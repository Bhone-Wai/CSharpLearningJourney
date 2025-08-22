namespace CSharpLearningJourney.PrintStringInReverse;
using System.Threading;

public class PrintStringInReverseDemo
{
    public static void Run()
    {
        Console.Write("Enter your message: ");
        string message = Console.ReadLine();

        /*Console.WriteLine(message[0]);
        Console.WriteLine(message.Length);*/

        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
            Thread.Sleep(200);
        }

        Console.WriteLine();

        for (int i = message.Length - 1; i >= 0; i--)
        {
            Console.Write(message[i]);
            Thread.Sleep(200);
        }
    }
}