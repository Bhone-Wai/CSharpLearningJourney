namespace CSharpLearningJourney.Constants;

public class ConstantsDemo
{
    public static void Run()
    {
        const int vat = 24;
        const double percentVat = vat / 100D;
        
        int balance = 1000;

        Console.WriteLine(balance * percentVat);
    }
}