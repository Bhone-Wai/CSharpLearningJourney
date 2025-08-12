namespace CSharpLearningJourney.DataTypes
{
	class DataTypesDemo
	{
		public static void Run()
		{
            int age = -22;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = -90000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.7D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.00001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 69.69M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.ReadLine();
        }
	}
}

