namespace CSharpLearningJourney.If;

public class IfDemo
{
    public static void Run()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();
        int age = Convert.ToInt32(ageInput);

        Console.WriteLine();
        Console.WriteLine("Your name is " + name + " and your age is " + age);

        if (age < 0 || age > 100)
        {
            Console.WriteLine("You entered an invalid age!");
        }
        else
        {
            if (age >= 18 && age <= 24)
            {
                Console.WriteLine("You are between 18 and 24.");
            }
            else if (age >= 26)
            {
                Console.WriteLine("You are 26 or older.");
            }
            
        }
        
        Console.Write("Enter the first number: ");
        string numberAInput = Console.ReadLine();
        int numberA = Convert.ToInt32(numberAInput);
        
        Console.Write("Enter the second number: ");
        string numberBInput = Console.ReadLine();
        int numberB = Convert.ToInt32(numberBInput);
        
        int answer = numberA * numberB;
        
        Console.Write("value of " + numberA + " x " + numberB + ": ");
        string answerInput = Console.ReadLine();
        int actualAnswer = Convert.ToInt32(answerInput);

        if (answer == actualAnswer)
        {
            Console.WriteLine("Well done!");
        }
        else
        {
            Console.WriteLine("Close but it was wrong!");
        }
    }
}