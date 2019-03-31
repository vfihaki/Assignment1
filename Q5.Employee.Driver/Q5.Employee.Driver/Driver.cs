using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5.Employee.Driver
{
    class Driver : Employee
    {
        public string Vehicle { get; set; }
        public string DriverLicenseNo { get; set; }
        public Driver(string firstName, string lastName, string vehicle)
        {
            FirstName = firstName;
            LastName = lastName;
            Vehicle = vehicle;

            Console.WriteLine($"Adding Employee as a new Driver to drive {Vehicle}...");
        }
        public string ProcessDriver()
        {
            return $"Driver name: {FirstName} {LastName}\nDriver licence No: {DriverLicenseNo}\nVehicle: {Vehicle}";
        }

    }
}
