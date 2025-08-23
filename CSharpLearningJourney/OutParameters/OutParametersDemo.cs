using System.Globalization;

namespace CSharpLearningJourney.OutParameters;

public class OutParametersDemo
{
    public static void Run()
    {
        List<string> shoppingList = new List<string>
        {
            "coffee", "milk", "sugar"
        };

        Console.Write("Enter a list name to search: ");
        string name = Console.ReadLine();

        if (FindInList(name, shoppingList, out int index))
        {
            Console.WriteLine($"Found {name} at index {index}");
        }
        else
        {
            Console.WriteLine("No item found");
        }

        /*int index = -1;

        for (int i = 0; i < shoppingList.Count; i++)
        {
            if (shoppingList[i].ToLower().Equals("Coffee"))
            {
                index = i;
            }
        }

        bool found = index > -1;
        Console.WriteLine(found ? "Found" : "Not Found");*/

        // Console.WriteLine(shoppingList.IndexOf("milk"));

        /*Console.Write("Enter an item name to search: ");
        string search = Console.ReadLine();

        if (FindInList(search, shoppingList, out int index))
        {
            Console.WriteLine($"Found {search} at index {index}");
        }
        else
        {
            Console.WriteLine("No items found");
        }*/
    }

    static bool FindInList(string s, List<string> list, out int index)
    {
        index = -1;

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].ToLower().Equals(s.ToLower()))
            {
                index = i;
            }
        }

        return index > -1;
    }

    /*static int Test(int num)
    {
        return 5;
    }*/

    /*static bool Test(out int num)
    {
        num = 5;
        return true;
    }*/
}