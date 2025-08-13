using System;
using CSharpLearningJourney.DataTypes;
using CSharpLearningJourney.StringChars;
using CSharpLearningJourney.Conversion;
using CSharpLearningJourney.Boolean;
using CSharpLearningJourney.ConditionalOperator;
using CSharpLearningJourney.ConsoleIO;
using CSharpLearningJourney.Constants;
using CSharpLearningJourney.Exercise;
using CSharpLearningJourney.For;
using CSharpLearningJourney.Format;
using CSharpLearningJourney.If;
using CSharpLearningJourney.Modulus;
using CSharpLearningJourney.Operations;
using CSharpLearningJourney.Switch;
using CSharpLearningJourney.Var;
using CSharpLearningJourney.While;

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
            Console.WriteLine("5 Operations Demo");
            Console.WriteLine("6 Modulus Demo");
            Console.WriteLine("7 Variables Demo");
            Console.WriteLine("8 Constants Demo");
            Console.WriteLine("9 Exercise Demo");
            Console.WriteLine("10 ConsoleIO Demo");
            Console.WriteLine("11 If Demo");
            Console.WriteLine("12 Switch Demo");
            Console.WriteLine("13 For Demo");
            Console.WriteLine("14 While Demo");
            Console.WriteLine("15 Conditional Operator Demo");
            Console.WriteLine("16 Format Demo");
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
                case "5":
                    Console.WriteLine("\n--- Running Operations Demo ---");
                    OperationsDemo.Run();
                    break;
                case "6":
                    Console.WriteLine("\n--- Running Modulus Demo ---");
                    ModulusDemo.Run();
                    break;
                case "7":
                    Console.WriteLine("\n--- Running Variables Demo ---");
                    VarDemo.Run();
                    break;
                case "8":
                    Console.WriteLine("\n--- Running Constants Demo ---");
                    ConstantsDemo.Run();
                    break;
                case "9":
                    Console.WriteLine("\n--- Running Exercises Demo ---");
                    ExerciseDemo.Run();
                    break;
                case "10":
                    Console.WriteLine("\n--- Running ConsoleIO Demo ---");
                    ConsoleIODemo.Run();
                    break;
                case "11":
                    Console.WriteLine("\n--- Running If Demo ---");
                    IfDemo.Run();
                    break;
                case "12":
                    Console.WriteLine("\n--- Running Switch Demo ---");
                    SwitchDemo.Run();
                    break;
                case "13":
                    Console.WriteLine("\n--- Running For Demo ---");
                    ForDemo.Run();
                    break;
                case "14":
                    Console.WriteLine("\n--- Running While Demo ---");
                    WhileDemo.Run();
                    break;
                case "15":
                    Console.WriteLine("\n--- Running Conditional Operator Demo ---");
                    CondationalOperatorDemo.Run();
                    break;
                case "16":
                    Console.WriteLine("\n--- Running Format Demo ---");
                    FormatDemo.Run();
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
