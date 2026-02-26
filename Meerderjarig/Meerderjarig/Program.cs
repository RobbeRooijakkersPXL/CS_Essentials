namespace Meerderjarig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je geboortejaar in");
            if (!int.TryParse(Console.ReadLine(), out int geboorteJaar))
            {
                Console.WriteLine("Geen geldig getal");
                return;
            }

            int leeftijd = 0;
            int jaar = DateTime.Now.Year;

            if (geboorteJaar >= 1900 && geboorteJaar <= jaar)
            {
                leeftijd = jaar - geboorteJaar;
                Console.WriteLine($"Je bent {leeftijd} jaar oud");
                if(leeftijd >= 18)
                {
                    Console.WriteLine("Je bent volwassen");
                }
                else
                {
                    Console.WriteLine("Je bent NIET volwassen");
                }



            }
            else
            {
                Console.WriteLine("Je bent of al lang overleden, of je hebt iets verkeerd ingegeven");
            }

        }   
    }
}   
