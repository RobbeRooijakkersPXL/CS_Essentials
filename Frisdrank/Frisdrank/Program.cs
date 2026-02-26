namespace Frisdrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingeworpen munt: 2 EURO");
            const int Coin = 2;
            Console.WriteLine("Prijs van gekocht drankje: ");
            string input = Console.ReadLine();

            if(decimal.TryParse(input, out decimal bedrag)){

                Console.WriteLine($"Wisselgeld is: {Coin - bedrag}");
                decimal change = Coin - bedrag;

                int euroMunt = Coin % 1;
                
            }

        }
    }
}
