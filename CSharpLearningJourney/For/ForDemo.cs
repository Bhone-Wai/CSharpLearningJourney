namespace CSharpLearningJourney.For;

public class ForDemo
{
    public static void Run()
    {
        /*for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("KYS");
        }*/
        
        Console.Write("What would you like to repeat?: ");
        string message = Console.ReadLine();
        Console.Write("And how many times would you like to repeat it?: ");
        int loopCounter = Convert.ToInt32(Console.ReadLine());

        if (loopCounter <= 0)
        {
            Console.WriteLine("Sorry, please enter a value above 0 or greater!");
        }
        else
        {
            for (int i = 0; i < loopCounter; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}