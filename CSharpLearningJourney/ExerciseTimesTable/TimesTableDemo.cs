namespace CSharpLearningJourney.ExerciseTimesTable;

public class TimesTableDemo
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2} ", i, number, i * number);
        }
    }
}