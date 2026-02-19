namespace Gemiddelden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het 1e getal: ");
            string input1 = Console.ReadLine();
            Console.Write("Geef het 2e getal: ");
            string input2 = Console.ReadLine();
            Console.Write("Geef het 3e getal: ");
            string input3 = Console.ReadLine();
            Console.Write("Geef het 4e getal: ");
            string input4 = Console.ReadLine();

            if (int.TryParse(input1, out int number1)
                && int.TryParse(input2, out int number2) 
                && int.TryParse(input3, out int number3)
                && int.TryParse(input4, out int number4))        
            {
                int gemiddelde = (number1 + number2 + number3 + number4) / 4;
                Console.WriteLine($"Het gemiddelde van de getallen: {number1}, {number2}, {number3} en {number4} is {gemiddelde}");
            }
            else
            {
                Console.WriteLine("GEEF EEN NUMMER IN DWAAS");
            }
        }
    }
}
