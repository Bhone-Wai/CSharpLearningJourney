namespace CSharpLearningJourney.IsNullOrEmpty;

public class IsNullOrEmptyDemo
{
    public static void Run()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Your name is {name}");

        /*if (name != "")
        {
            Console.WriteLine(1);
        }*/

        /*if (!name.Equals(""))
        {
            Console.WriteLine(2);
        }*/

        if (!string.IsNullOrEmpty(name))
        {
            if (name.Equals("Kuzu"))
            {
                Console.WriteLine("Correct");
            }
        }
    }
}