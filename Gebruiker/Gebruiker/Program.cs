using Gebruiker.Models;
using Gebruiker.Services;

namespace Gebruiker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager manager = new UserManager();

            ShowRegisterScreen(manager);
            ShowLoginScreen(manager);


        }
        

        static void ShowRegisterScreen(UserManager manager)
        {
            Console.WriteLine("----Register----");
            Console.WriteLine("----------------");
            Console.Write("Username: ");
            string inputUsername = Console.ReadLine();
            Console.Write("Password: ");
            string inputPassword = Console.ReadLine();

            
            manager.Register(inputUsername, inputPassword);

            Console.WriteLine("Press Enter to contintue...");
            Console.ReadLine();
        }

        static void ShowLoginScreen(UserManager manager)
        {
            Console.Clear();
            Console.WriteLine("----Login----");
            Console.WriteLine("-------------");
            Console.Write("Username: ");
            string inputUsername = Console.ReadLine();
            Console.Write("Password: ");
            string inputPassword = Console.ReadLine();

            Login inputCredentials = new Login();
            inputCredentials.Username = inputUsername;
            inputCredentials.Password = inputPassword;

            
            bool isValid = manager.TryLogin(inputCredentials);

            if (isValid)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login succesfull");
                Console.WriteLine($"Username: {inputUsername}, Password: {inputPassword}");
                manager.ShowHash();
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect username or password");
                Console.ResetColor();
            }

            Console.WriteLine("Press Enter to contintue...");
            Console.ReadLine();
        }
    }
}
