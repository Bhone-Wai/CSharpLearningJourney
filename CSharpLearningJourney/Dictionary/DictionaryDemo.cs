using System.Globalization;

namespace CSharpLearningJourney.Dictionary;
using System.Collections.Generic;

public class DictionaryDemo
{
    public static void Run()
    {
        Dictionary<int, string> names = new Dictionary<int, string>()
        {
            { 1, "Katsu" },
            { 4, "Katsu" },
            { 2, "o-san" },
            { 3, "Noriko" }
        };

        /*for (int i = 0; i < names.Count; i++)
        {
            KeyValuePair<int, string> pair = names.ElementAt(i);
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }*/

        /*foreach (KeyValuePair<int, string> pair in names)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }*/
        
        /*names.Add(1, "Katsu");
        names.Add(2, "o-san");
        names.Add(3, "Noriko");*/

        Dictionary<string, string> teachers = new Dictionary<string, string>()
        {
            { "Meth", "Bhone Wai" },
            { "English", "Noriko" }
        };

        // Console.WriteLine(teachers["meth"]);
        if (teachers.TryGetValue("Meth", out string teacher))
        {
            Console.WriteLine(teacher);

            teachers["Meth"] = "Kuzu";
        }
        else
        {
            Console.WriteLine("Not found");
        }
        
        teachers.Remove("Meth");

        foreach (var pair in teachers)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}