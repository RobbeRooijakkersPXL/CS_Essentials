namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lotto");
            Console.ResetColor();

            Random random = new Random();
            int amountOfLottoNumbers = 6;

            string input;

            do
            {
                
                
                for (int i = 0; i < amountOfLottoNumbers; i++)
                {
                    int randomLottoNumber = random.Next(1, 46);
                    Console.WriteLine(randomLottoNumber);
                }
                do
                {
                    Console.Write("Wil je andere getallen? (J/N): ");
                    input = Console.ReadLine();
                } while (!input.Equals("N") && !input.Equals("J"));

            } while (input.Equals("J"));


           

            
          

            
        }
    }
}
