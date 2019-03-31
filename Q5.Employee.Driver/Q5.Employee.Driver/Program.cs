using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5.Employee.Driver
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
                Console.Write("Enter vehicle type: ");
                string Vehicle = Console.ReadLine();
                Console.Clear();
                Driver driver = new Driver(FName, LName, Vehicle);

                Console.Write("Please enter licence number for this employee: ");
                driver.DriverLicenseNo = Console.ReadLine();

                Console.WriteLine("\nThe following employee details has been Entered:");
                Console.WriteLine(driver.ProcessDriver());

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
