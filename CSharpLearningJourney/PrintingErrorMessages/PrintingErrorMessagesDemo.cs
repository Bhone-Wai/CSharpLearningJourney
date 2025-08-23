namespace CSharpLearningJourney.PrintingErrorMessages;

public class PrintingErrorMessagesDemo
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}