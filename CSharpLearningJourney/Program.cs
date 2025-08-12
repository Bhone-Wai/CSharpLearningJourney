using System;
using CSharpLearningJourney.DataTypes;
using CSharpLearningJourney.StringChars;
using CSharpLearningJourney.Conversion;
using CSharpLearningJourney.Boolean;

namespace CSharpLearningJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Learning Journey ===");
            Console.WriteLine("Choose a demo to run:");
            Console.WriteLine("1. Data Types Demo");
            Console.WriteLine("2. String & Chars Demo");
            Console.WriteLine("3. Conversion Demo");
            Console.WriteLine("4 Boolean Demo");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n--- Running Data Types Demo ---");
                    DataTypesDemo.Run();
                    break;
                case "2":
                    Console.WriteLine("\n--- Running String & Chars Demo ---");
                    StringCharsDemo.Run();
                    break;
                case "3":
                    Console.WriteLine("\n--- Running Conversion Demo ---");
                    ConversionDemo.Run();
                    break;
                case "4":
                    Console.WriteLine("\n--- Running Boolean Demo ---");
                    BooleanDemo.Run();
                    break;
                case "0":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
