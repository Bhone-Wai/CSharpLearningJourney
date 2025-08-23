namespace CSharpLearningJourney.ExerciseAreaOfTriangle;

public class ExerciseAreaOfTriangleDemo
{
    public static void Run()
    {
        int height = ReadInput("Enter the height: ");
        int width = ReadInput("Enter the width: ");

        Console.WriteLine(height);
        Console.WriteLine(width);
        
        int result = CalculateArea(height, width);
        Console.WriteLine($"The area of the triangle is: {result}");
    }

    static int CalculateArea(int height, int width)
    {
        return (height * width) / 2;
    }

    static int ReadInput(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}