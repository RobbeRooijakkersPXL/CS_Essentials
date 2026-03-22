namespace Inkomen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Maandsalaris: ");
            int income = int.Parse(Console.ReadLine());

            Console.Write("Aantal jaren: ");
            int years = int.Parse(Console.ReadLine());

            ShowIncome(income, years);
            Console.WriteLine($"[ShowIncomeWithReturnValue] Inkomen over {years} jaren is {ShowIncomeWithReturnValue(income, years):c}");

            ShowIncomeWithOutParam(income, years, out int yearSalary);
            Console.WriteLine($"[ShowIncomeWithOutParam] Inkomen over {years} jaren is {yearSalary:c}");
            
            ShowIncomeWithRefParam(income, years, ref income);
            Console.WriteLine($"[ShowIncomeWithRefParam] Inkomen over {years} jaren is {income:c}");
            Console.ReadKey();
        }

        // Void-methode
        static void ShowIncome(int monthSalary, int numberOfYears)
        {
            int income = monthSalary * 12 * numberOfYears;
            Console.WriteLine($"[ShowIncome] Inkomen over {numberOfYears} jaren is {income:c}");
        }

        // Function-methode die resultaat teruggeeft
        static int ShowIncomeWithReturnValue(int monthSalary, int numberOfYears)
        {
            return monthSalary * 12 * numberOfYears;
        }

        // Void-methode met out parameter
        static void ShowIncomeWithOutParam(int monthSalary, int years, out int income)
        {
            income = monthSalary * 12 * years;
        }

        // Void-methode met ref parameter
        static void ShowIncomeWithRefParam(int monthSalary, int years, ref int income)
        {
            income = monthSalary * 12 * years;
        }
    }
}