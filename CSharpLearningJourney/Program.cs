using System;
using CSharpLearningJourney.Array;
using CSharpLearningJourney.ArrayClearing;
using CSharpLearningJourney.ArrayIndexOf;
using CSharpLearningJourney.ArrayOfMultiples;
using CSharpLearningJourney.ArrayReversal;
using CSharpLearningJourney.ArraySorting;
using CSharpLearningJourney.DataTypes;
using CSharpLearningJourney.StringChars;
using CSharpLearningJourney.Conversion;
using CSharpLearningJourney.Boolean;
using CSharpLearningJourney.ConditionalOperator;
using CSharpLearningJourney.ConsoleIO;
using CSharpLearningJourney.Constants;
using CSharpLearningJourney.Dictionary;
using CSharpLearningJourney.EmptyString;
using CSharpLearningJourney.ExceptionHandling;
using CSharpLearningJourney.Exercise;
using CSharpLearningJourney.ExerciseAreaOfTriangle;
using CSharpLearningJourney.ExerciseCustomTryParse;
using CSharpLearningJourney.ExerciseSumOfIntArray;
using CSharpLearningJourney.For;
using CSharpLearningJourney.Format;
using CSharpLearningJourney.FunctionParameters;
using CSharpLearningJourney.Functions;
using CSharpLearningJourney.If;
using CSharpLearningJourney.IsNullOrEmpty;
using CSharpLearningJourney.Lists;
using CSharpLearningJourney.Modulus;
using CSharpLearningJourney.NamedParameters;
using CSharpLearningJourney.NumberSplit;
using CSharpLearningJourney.Operations;
using CSharpLearningJourney.OptionalParameters;
using CSharpLearningJourney.OutParameters;
using CSharpLearningJourney.PasswordChecker;
using CSharpLearningJourney.PrintingErrorMessages;
using CSharpLearningJourney.PrintStringInReverse;
using CSharpLearningJourney.ReferenceParameters;
using CSharpLearningJourney.ReturnTypeFunctions;
using CSharpLearningJourney.StringEqualsFunction;
using CSharpLearningJourney.StringFormatting;
using CSharpLearningJourney.StringInterpolation;
using CSharpLearningJourney.StringIteration;
using CSharpLearningJourney.Switch;
using CSharpLearningJourney.Triangle;
using CSharpLearningJourney.TryCatch;
using CSharpLearningJourney.TryParse;
using CSharpLearningJourney.Var;
using CSharpLearningJourney.VerbatimStringLiteral;
using CSharpLearningJourney.VoidFunctions;
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
            Console.WriteLine("17 Try Parse Demo");
            Console.WriteLine("18 Times Table Exercise Demo");
            Console.WriteLine("19 FizzBuzz Exercise Demo");
            Console.WriteLine("20 Verbatim String Literal Demo");
            Console.WriteLine("21 String Format Demo");
            Console.WriteLine("22 String Interpolation Demo");
            Console.WriteLine("23 Empty String Demo");
            Console.WriteLine("24 String Equals Demo");
            Console.WriteLine("25 String Iteration Demo");
            Console.WriteLine("26 Is Null Or Empty Demo");
            Console.WriteLine("27 Print String In Reverse Demo");
            Console.WriteLine("28 Password Checker Demo");
            Console.WriteLine("29 Array Demo");
            Console.WriteLine("30 Triangle Demo");
            Console.WriteLine("31 Array Sorting Demo");
            Console.WriteLine("32 Array Reversal Demo");
            Console.WriteLine("33 Array Clearing Demo");
            Console.WriteLine("34 Array Index Of Demo");
            Console.WriteLine("35 Lists Demo");
            Console.WriteLine("36 Dictionary Demo");
            Console.WriteLine("37 Number Split Demo");
            Console.WriteLine("38 Array Of Multiples Demo");
            Console.WriteLine("39 Functions Demo");
            Console.WriteLine("40 Void Functions Demo");
            Console.WriteLine("41 Return Types Functions Demo");
            Console.WriteLine("42 Function Parameters Demo");
            Console.WriteLine("43 Optional Parameters Demo");
            Console.WriteLine("44 Named Parameters Demo");
            Console.WriteLine("45 Out Parameters Demo");
            Console.WriteLine("46 Reference Parameters Demo");
            Console.WriteLine("47 Exercise Area Of Triangle Demo");
            Console.WriteLine("48 Exercise Sum Of Int Array Demo");
            Console.WriteLine("49 Exception Handling Demo");
            Console.WriteLine("50 Try Catch Demo");
            Console.WriteLine("51 Printing Error Messages Demo");
            Console.WriteLine("52 Exercise Custom Try Parse Demo");
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
                case "17":
                    Console.WriteLine("\n--- Running Try Parse Demo ---");
                    TryParseDemo.Run();
                    break;
                case "18":
                    Console.WriteLine("\n--- Running Times Table Exercise Demo ---");
                    ExerciseTimesTable.TimesTableDemo.Run();
                    break;
                case "19":
                    Console.WriteLine("\n--- Running FizzBuzz Exercise Demo ---");
                    ExerciseFizzBuzzGame.FizzBuzzGameDemo.Run();
                    break;
                case "20":
                    Console.WriteLine("\n--- Running Verbatim String Literal Demo ---");
                    VerbatimStringLiteralDemo.Run();
                    break;
                case "21":
                    Console.WriteLine("\n--- Running String Format Demo ---");
                    StringFormattingDemo.Run();
                    break;
                case "22":
                    Console.WriteLine("\n--- Running String Interpolation Demo ---");
                    StringInterpolationDemo.Run();
                    break;
                case "23":
                    Console.WriteLine("\n--- Running Empty String Demo ---");
                    EmptyStringDemo.Run();
                    break;
                case "24":
                    Console.WriteLine("\n--- Running String Equals Demo ---");
                    StringEqualsFunctionDemo.Run();
                    break;
                case "25":
                    Console.WriteLine("\n--- Running String Iteration Demo ---");
                    StringIterationDemo.Run();
                    break;
                case "26":
                    Console.WriteLine("\n--- Running Is Null Or Empty Demo ---");
                    IsNullOrEmptyDemo.Run();
                    break;
                case "27":
                    Console.WriteLine("\n--- Running Print String In Reverse Demo ---");
                    PrintStringInReverseDemo.Run();
                    break;
                case "28":
                    Console.WriteLine("\n--- Running Password Checker Demo ---");
                    PasswordCheckerDemo.Run();
                    break;
                case "29":
                    Console.WriteLine("\n--- Running Array Demo ---");
                    ArrayDemo.Run();
                    break;
                case "30":
                    Console.WriteLine("\n--- Running Triangle Demo ---");
                    TriangleDemo.Run();
                    break;
                case "31":
                    Console.WriteLine("\n--- Running Array Sorting Demo ---");
                    ArraySortingDemo.Run();
                    break;
                case "32":
                    Console.WriteLine("\n--- Running Array Reversal Demo ---");
                    ArrayReversalDemo.Run();
                    break;
                case "33":
                    Console.WriteLine("\n--- Running Array Clearing Demo ---");
                    ArrayClearingDemo.Run();
                    break;
                case "34":
                    Console.WriteLine("\n--- Running Array Index Of Demo ---");
                    ArrayIndexOfDemo.Run();
                    break;
                case "35":
                    Console.WriteLine("\n--- Running Lists Demo ---");
                    ListsDemo.Run();
                    break;
                case "36":
                    Console.WriteLine("\n--- Running Dictionary Demo ---");
                    DictionaryDemo.Run();
                    break;
                case "37":
                    Console.WriteLine("\n--- Running Number Split Demo ---");
                    NumberSplitDemo.Run();
                    break;
                case "38":
                    Console.WriteLine("\n--- Running Array Of Multiples Demo ---");
                    ArrayOfMultiplesDemo.Run();
                    break;
                case "39":
                    Console.WriteLine("\n--- Running Functions Demo ---");
                    FunctionsDemo.Run();
                    break;
                case "40":
                    Console.WriteLine("\n--- Running Void Functions Demo ---");
                    VoidFunctionsDemo.Run();
                    break;
                case "41":
                    Console.WriteLine("\n--- Running Return Types Functions Demo ---");
                    ReturnTypeFunctionsDemo.Run();
                    break;
                case "42":
                    Console.WriteLine("\n--- Running Function Parameters Demo ---");
                    FunctionParametersDemo.Run();
                    break;
                case "43":
                    Console.WriteLine("\n--- Running Optional Parameters Demo ---");
                    OptionalParametersDemo.Run();
                    break;
                case "44":
                    Console.WriteLine("\n--- Running Named Parameters Demo ---");
                    NamedParametersDemo.Run();
                    break;
                case "45":
                    Console.WriteLine("\n--- Running Out Parameters Demo ---");
                    OutParametersDemo.Run();
                    break;
                case "46":
                    Console.WriteLine("\n--- Running Reference Parameters Demo ---");
                    ReferenceParametersDemo.Run();
                    break;
                case "47":
                    Console.WriteLine("\n--- Running Exercise Area Of Triangle Demo ---");
                    ExerciseAreaOfTriangleDemo.Run();
                    break;
                case "48":
                    Console.WriteLine("\n--- Running Exercise Sum Of Int Array Demo ---");
                    ExerciseSumOfIntArrayDemo.Run();
                    break;
                case "49":
                    Console.WriteLine("\n--- Running Exception Handling Demo ---");
                    ExceptionhandlingDemo.Run();
                    break;
                case "50":
                    Console.WriteLine("\n--- Running Try Catch Demo ---");
                    TryCatchDemo.Run();
                    break;
                case "51":
                    Console.WriteLine("\n--- Running Printing Error Messages Demo ---");
                    PrintingErrorMessagesDemo.Run();
                    break;
                case "52":
                    Console.WriteLine("\n--- Running Exercise Custom Try Parse Demo ---");
                    ExerciseCustomTryParseDemo.Run();
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
