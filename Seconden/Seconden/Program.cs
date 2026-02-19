namespace Seconden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aantal seconden");
            string input = Console.ReadLine();

            if(int.TryParse(input, out int totaalSeconden))
            {
                int uren = totaalSeconden / 3600;
                int minuten = (totaalSeconden % 3600) / 60;
                int seconden = totaalSeconden % 60;

                Console.WriteLine($"H:{uren} M:{minuten} S:{seconden}");
            }
            else
            {
                Console.WriteLine("Dit is geen nummer...");
            }
        }
    }
}
