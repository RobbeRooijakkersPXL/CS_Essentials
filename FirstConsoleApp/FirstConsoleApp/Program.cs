namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Hello, World!");
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hallo " + name);

            Console.ResetColor();

        }
    }
}
