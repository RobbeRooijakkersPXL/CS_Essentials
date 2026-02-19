namespace Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatuur in °F: ");
            string input = Console.ReadLine();

            if(double.TryParse(input, out double fahrenheit))
            {
                double celcius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"De graden is celsius is: {celcius}°C");
            }
            else
            {
                Console.WriteLine("Dat is geen geldig getal.");
            }

            
        }
    }
}
