namespace rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je eerste getal: ");
            string input1 = Console.ReadLine();
            int getal1 = int.Parse(input1);
            Console.Write("Geef je tweede getal: ");
            string input2 = Console.ReadLine();
            int getal2 = int.Parse(input2);

            Console.WriteLine($"De som van {getal1} + {getal2} = {getal1 + getal2}");
        }
    }
}
