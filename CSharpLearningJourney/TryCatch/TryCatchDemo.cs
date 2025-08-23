namespace CSharpLearningJourney.TryCatch;

public class TryCatchDemo
{
    public static void Run()
    {
        bool looping = true;

        while (looping)
        {
            try
            {
                Console.Write("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                looping = false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please only enter number less than 2 billions");
                looping = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter number");
                looping = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
                looping = true;
            }   
        }
    }
}