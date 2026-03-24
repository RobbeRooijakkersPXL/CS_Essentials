using SalaryCalculator.Models;

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Employee employee = new Employee();

            Console.Write($"Voornaam: ");
            employee.FirstName = Console.ReadLine();

            Console.Write($"Achternaam: ");
            employee.LastName = Console.ReadLine();

            Console.Write("Wat is je huidig salaris: ");
            employee.Salary = decimal.Parse(Console.ReadLine());

            employee.IncreaseSalary(10);
            Console.WriteLine($"Nieuwe salaris: {employee.Salary:c}");
        }
    }
}
