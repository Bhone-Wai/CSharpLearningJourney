namespace CSharpLearningJourney.PasswordChecker;

public class PasswordCheckerDemo
{
    public static void Run()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        
        Console.Write("Enter password again: ");
        string passwordC = Console.ReadLine();

        Console.WriteLine(password);
        Console.WriteLine(passwordC);

        if (!password.Equals(string.Empty))
        {
            if (!passwordC.Equals(string.Empty))
            {
                if (password.Length >= 6 && passwordC.Length >= 6)
                {
                    if (password.Equals(passwordC))
                    {
                        Console.WriteLine("Passwords are matched");
                    }
                    else
                    {
                        Console.WriteLine("Passwords are not matched");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter 6 or more characters!");
                }
            }
            else
            {
                Console.WriteLine("Please enter password confirmation");
            }
        }
        else
        {
            Console.WriteLine("Please enter password");
        }
    }
}