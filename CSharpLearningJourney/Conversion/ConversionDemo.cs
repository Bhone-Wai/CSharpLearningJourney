namespace CSharpLearningJourney.Conversion;

public class ConversionDemo
{
    public static void Run()
    {
        string textAge = "-22";
        int age = Convert.ToInt32(textAge);
        Console.WriteLine(age);

        string textBigNumber = "-9000000";
        long bigNumber = Convert.ToInt64(textBigNumber);
        Console.WriteLine(bigNumber);

        string textNegative = "-55.2";
        double negative = Convert.ToDouble(textNegative);
        Console.WriteLine(negative);

        string textPercision = "5.001";
        float percision = Convert.ToSingle(textPercision);
        Console.WriteLine(percision);

        string textMoney = "69.69";
        decimal money = Convert.ToDecimal(textMoney);
        Console.WriteLine(money);
    }
}