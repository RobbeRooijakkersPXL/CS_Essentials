namespace Parkeermeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static DateTime StartSession()
        {
            bool validTimeStamp = false;


            do 
            {
                Console.ForegroundColor = ConsoleColor.Green;


            } while (validTimeStamp);
            

        }

        private static void ShowTitle()
        {
            Console.Clear();
            Console.WriteLine("+-------------+");
            Console.WriteLine("| P(arking)XL |");
            Console.WriteLine("+-------------+");
        }

        private static int ShowMenu()
        {
            string input;

            Console.WriteLine("1 - Start");
            Console.WriteLine("2 - Stop");
            Console.WriteLine("3 - Ticket");
            Console.WriteLine("4 - Sluit");
            Console.Write("Uw keuze: ");
            input = Console.ReadLine();

            if(!int.TryParse(input, out int output))
            {
                
                return -1;
            }
            else
            {
                return output;
            }
        }

        private static void ShowError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();

            Console.ReadKey();
        }

        
    }
}
