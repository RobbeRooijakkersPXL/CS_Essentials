namespace Diploma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je naam op: ");
            string name = Console.ReadLine();

            Console.WriteLine("Geef aan hoeveel je op 20 had voor de volgende Olods:");

            int shortagePoints = 0;
            int average = 0;


            Console.Write("Web Essentials: ");
            if (!int.TryParse(Console.ReadLine(), out int numberWeb)) {
                Console.WriteLine("Verkeerde input");
                return;
            }
            if (numberWeb > 20 || numberWeb < 0)
            {
                Console.WriteLine("Nummer moet tussen de 0 en 20 liggen");
                return;
            }
            else
            {
                if(numberWeb < 10)
                {
                    shortagePoints += (10 - numberWeb) * 6;
                }

            }

            Console.Write("Data Essentials: ");
            if (!int.TryParse(Console.ReadLine(), out int numberData))
            {
                Console.WriteLine("Verkeerde input");
                return;
            }
            if (numberData > 20 || numberData < 0)
            {
                Console.WriteLine("Nummer moet tussen de 0 en 20 liggen");
                return;

            }
            else
            {
                if (numberData < 10)
                {
                    shortagePoints += (10 - numberData) * 4;
                }

            }

            Console.Write("C# Essentials: ");
            if (!int.TryParse(Console.ReadLine(), out int numberCS))
            {
                Console.WriteLine("Verkeerde input");
                return;
            }
            if (numberCS > 20 || numberCS < 0)
            {
                Console.WriteLine("Nummer moet tussen de 0 en 20 liggen");
                return;
            }
            else
            {
                if (numberCS < 10)
                {
                    shortagePoints += (10 - numberCS) * 7;
                }
            }

            Console.Write("Comm skills: ");
            if (!int.TryParse(Console.ReadLine(), out int numberComm))
            {
                Console.WriteLine("Verkeerde input");
                return;
            }
            if (numberComm > 20 || numberComm < 0)
            {
                Console.WriteLine("Nummer moet tussen de 0 en 20 liggen");
                return;
            }
            else
            {
                if (numberComm < 10)
                {
                    shortagePoints += (10 - numberComm) * 3;
                }
            }

            Console.Write("IT-Org: ");
            if (!int.TryParse(Console.ReadLine(), out int numberOrg))
            {
                Console.WriteLine("Verkeerde input");
                return;
            }
            if (numberOrg > 20 || numberOrg < 0)
            {
                Console.WriteLine("Nummer moet tussen de 0 en 20 liggen");
                return;
            }
            else
            {
                if (numberOrg < 10)
                {
                    shortagePoints += (10 - numberOrg) * 4;
                }
            }

            switch (shortagePoints)
            {
                case > 10:
                    Console.WriteLine($"{name} behaalde een ");
                    break;

            }



        }
    }
}
