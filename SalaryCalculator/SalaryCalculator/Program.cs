using SalaryCalculator.Models;

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Voornaam: ");
            string firstName = Console.ReadLine();

            Console.Write("Achternaam: ");
            string lastName = Console.ReadLine();

            Console.Write("Geboortedatum: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Salaris: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Employee employee = new Employee(firstName, lastName);
            employee.Salary = salary;
            employee.BirthDate = birthDate;
            int percentage = 0;

            do 
            {
                ShowDetails(employee);
                Console.Write("Opslag Percentage: ");

            } while (!int.TryParse(Console.ReadLine(), out percentage) || percentage < 0 || percentage > 10);

            Console.Clear();
            
            employee.IncreaseSalary(percentage);
            ShowDetails(employee);



        }

        static void ShowDetails(Employee emp)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Werknemer: {emp.FirstName} {emp.LastName}");
            Console.WriteLine($"Geboortedatum: {emp.BirthDate.ToLongDateString()} + ({emp.Age})");
            Console.WriteLine($"Salary: {emp.Salary:c}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Samenvatting: {emp.ToString()}");
            Console.WriteLine("--------------------");
        }

        

    }

    
}