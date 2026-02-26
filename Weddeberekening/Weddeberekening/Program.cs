namespace Weddeberekening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je naam op: ");
            string name = Console.ReadLine();

            Console.Write("Geef je uurloon op: ");
            if(!decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                Console.WriteLine("Verkeerde Input");
                return;
            }

            Console.Write("Geef je gewerkte uren op: ");
            if(!int.TryParse(Console.ReadLine(), out int workedHours))
            {
                Console.WriteLine("Verkeerde Input");
                return;
            }

            decimal income = salary * workedHours;
            decimal totalTax = 0;


            if(income > 50000)
            {
                decimal tax = (income - 50000) / 100 * 50;
                totalTax += tax;
                income -= (income - 50000);
            }

            if (income > 25000 && income <= 50000)
            {
                decimal tax = (income - 25000) / 100 * 40;
                totalTax += tax;
                income -= (income - 25000);
            }

            if (income > 15000 && income <= 25000)
            {
                decimal tax = (income - 15000) / 100 * 30;
                totalTax += tax;
                income -= (income - 15000);
            }
            if (income > 10000 && income <= 15000)
            {
                decimal tax = (income - 10000) / 100 * 20;
                totalTax += tax;
                income -= (income - 10000);
            }
            Console.WriteLine($"Hallo {name}, dit is je rapport:");
            Console.WriteLine($"Brutoloon: {salary * workedHours}");
            Console.WriteLine($"Belasting: {totalTax}");
            Console.WriteLine($"Nettoloon: {(salary * workedHours) - totalTax}");



        }
    }
}
