namespace CSharpLearningJourney.VerbatimStringLiteral;

public class VerbatimStringLiteralDemo
{
    public static void Run()
    {
        string speech = "He is \"yapping about something\"";
        string path = "Local HD:\\Users\\appleclub\\Documents\\Practice 2025\\C#\nNew line test";
        Console.WriteLine(speech);
        Console.WriteLine(path);

        path = @"Local HD:/Users/appleclub/Documents/Practice 2025/C#" + "\nNew line test";
        Console.WriteLine(path);

        string name = @"Hello ""Kuzu""";
        Console.WriteLine(name);
    }
}