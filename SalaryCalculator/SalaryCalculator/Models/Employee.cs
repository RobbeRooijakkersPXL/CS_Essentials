using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator.Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee()
        {

        }


        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private decimal _salary;
        

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int Age
        {
            get { return DateTime.Now.Year - BirthDate.Year; }
        }

        public void IncreaseSalary(int percentage)
        {
            
            Salary += (Salary * percentage/100M);


        }
    }
}
