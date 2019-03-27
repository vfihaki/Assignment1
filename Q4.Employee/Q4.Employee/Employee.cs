using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4.Employee
{
    class Employee
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public int YearStarted { get; set; }
        public Employee(string firstName, string lastName)
        {
            FirsName = firstName;
            LastName = lastName;

            Console.WriteLine("Creating new Employee record...");
        }
        public string GetFullName()
        {
            return FirsName + " " + LastName;
        }
        public string GetYearWorked()
        {
            return $"{2019 - YearStarted} years";
        }
    }
}
