using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4.Employee
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine("Enter details of new employee below\n");

            Console.Write("Enter First Name: ");
            string FName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string LName = Console.ReadLine();
           

            Employee newEmployee = new Employee(FName, LName);


            Console.Write("Year employee started at the company?: ");
            newEmployee.YearStarted = int.Parse(Console.ReadLine());

            Console.WriteLine("\n******************************************");
            Console.WriteLine($"Employee {newEmployee.GetFullName()}, has worked for the company for {newEmployee.GetYearWorked()}");

            Console.ReadLine();
        }
    }
    
}
