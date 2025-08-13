namespace CSharpLearningJourney.While;

public class WhileDemo
{
    public static void Run()
    {
        /*int i = 0;

        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }*/
        
        Console.Write("Enter the first number: ");
        string numberAInput = Console.ReadLine();
        int numberA = Convert.ToInt32(numberAInput);
        
        Console.Write("Enter the second number: ");
        string numberBInput = Console.ReadLine();
        int numberB = Convert.ToInt32(numberBInput);
        
        int answer = numberA * numberB;
        int actualAnswer = 0;
        
        Console.Write("value of " + numberA + " x " + numberB + ": ");
        Console.WriteLine();

        /*while (answer != actualAnswer)
        {
            Console.Write("Enter the answer: ");
            string answerInput = Console.ReadLine();
            actualAnswer = Convert.ToInt32(answerInput);
            
            if (answer != actualAnswer)
            {
                Console.WriteLine("Close but it was wrong!");
                Console.WriteLine();
            }
        }*/

        do
        {
            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine();
            actualAnswer = Convert.ToInt32(numberInput);

            if (answer != actualAnswer)
            {
                Console.WriteLine("Close but it was wrong!");
                Console.WriteLine();
            }
        } while (answer != actualAnswer);
        
        Console.WriteLine("Well done!");
    }
}