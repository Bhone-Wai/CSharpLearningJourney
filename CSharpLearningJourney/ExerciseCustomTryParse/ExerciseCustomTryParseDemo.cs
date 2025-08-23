namespace CSharpLearningJourney.ExerciseCustomTryParse;

public class ExerciseCustomTryParseDemo
{
    public static void Run()
    {
        bool success = false;
        
        /*try
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            success = true;
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        Console.WriteLine(success ? "Yey" : "Oh no");*/

        Console.Write("Enter the number: ");
        if (TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine("Yey " + result);
        }
        else
        {
            Console.WriteLine("Oh no");
        }
        
        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}