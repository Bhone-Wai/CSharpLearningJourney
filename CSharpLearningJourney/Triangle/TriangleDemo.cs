namespace CSharpLearningJourney.Triangle;

public class TriangleDemo
{
    public static void Run()
    {
        /*const int angleCount = 3;
        int[] angles = new int[angleCount];

        for (int i = 0; i < angles.Length; i++)
        {
            Console.Write($"Enter angle {i + 1}: ");
            angles[i] = Convert.ToInt32(Console.ReadLine());
        }

        int angleSum = 0;

        foreach (int angle in angles)
        {
            angleSum += angle;
        }
        // Console.WriteLine($"Sum of angles: {angleSum}");

        Console.WriteLine(angleSum == 180 ? "valid" :  "invalid");*/

        int angleCount = 3;
        int angleSum = 0;
        for (int i = 0; i < angleCount; i++)
        {
            Console.Write($"Enter angle {i + 1}: ");
            angleSum += Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(angleSum == 180 ? "valid" : "invalid");
    }
}