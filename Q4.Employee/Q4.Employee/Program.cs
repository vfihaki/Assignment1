﻿using System;
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
        
            Boolean code = true;
            do
            {
                Console.WriteLine("Enter details of new employee below\n");

                Console.Write("Enter First Name: ");
                string FName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                string LName = Console.ReadLine();

                Employee employee = new Employee(FName, LName);

                Console.Write("Year employee started at the company?: ");
                employee.YearStarted = int.Parse(Console.ReadLine());

                Console.WriteLine("\n******************************************");
                Console.WriteLine($"Employee {employee.GetFullName()}, has worked for the company for {employee.GetYearWorked()}");

                Console.WriteLine("\n\nDo you want to enter another employee? <y/n>");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {  
                    Console.WriteLine($"Press any key to exit the program");
                    Console.ReadKey();
                    code = false;
                }
                
                Console.Clear();
            } while (code);
        }
    }
    
    
}
