namespace Kassa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Geef de prijs van je product: ");
            string input1 = Console.ReadLine();
            if(double.TryParse(input1, out double bedrag)) {
                Console.Write("Geef het aantal in: ");
                string input2 = Console.ReadLine();

                if(double.TryParse(input2, out double aantal))
                {
                    Console.WriteLine($"het bedrag is {bedrag * aantal:c}");
                }
                else
                {
                    Console.Write("Eerst geef je een mooi getal, en nu niet... BEN JE LOMP???");
                }

            }
            else
            {
                Console.WriteLine("Onjuiste waarde, geef een getal retard");
            }
        }
    }
}
