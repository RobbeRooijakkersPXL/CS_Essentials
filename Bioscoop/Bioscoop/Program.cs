namespace Bioscoop
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const decimal NormalTarif = 9.10M;
            const decimal DiscountTarif = 8.10M;
            const decimal StudentTarif = 6.90M;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WELKOM IN HET KINOPOLIS BIOSCOOPTHEATERZAALACHTIGETOESTAND ");
            Console.ResetColor();

            Console.WriteLine($"Het normaal tarief is: {NormalTarif}");
            Console.WriteLine($"Het kortings tarief is: {DiscountTarif}");
            Console.WriteLine($"Het studenten tarief is: {StudentTarif}");

            Console.Write("Geef het aantal tickets voor normaal tarief: ");
            string normal = Console.ReadLine();
            Console.Write("Geef het aantal tickets voor korting tarief: ");
            string discount = Console.ReadLine();
            Console.Write("Geef het aantal tickets voor studenten tarief: ");
            string student = Console.ReadLine();


            if(int.TryParse(normal, out int normalCount))
            {
                if(int.TryParse(discount, out int discountCount))
                {
                    if(int.TryParse(student, out int studentCount))
                    {
                        decimal normalTotal = NormalTarif * normalCount;
                        decimal discountTotal = DiscountTarif * discountCount;
                        decimal studentTotal = StudentTarif * studentCount;
                        decimal total = normalTotal + discountTotal + studentTotal;  

                        Console.WriteLine($"Totaal normale tickets: {normalTotal:c}");
                        Console.WriteLine($"Totaal discount tickets: {discountTotal:c}");
                        Console.WriteLine($"Totaal student tickets: {studentTotal:c}");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Totaal bedrag: {total}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("Dat was geen getal dombo");
                    }
                }
                else
                {
                    Console.Write("Dat was geen getal dombo");
                }
            }
            else
            {
                Console.Write("Dat was geen getal dombo");
            }

        }
    }
}
