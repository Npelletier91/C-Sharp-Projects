using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1001 };
            Employee employee2 = new Employee() { FirstName = "Sample2", LastName = "Student2", ID = 1002 };

            employee.SayName();

            if (employee == employee2)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} and {employee2.FirstName} {employee2.LastName} have the same ID");
            }
            else
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} and {employee2.FirstName} {employee2.LastName} have different IDs");
            }

            IQuittable quittableEmployee = employee;
            quittableEmployee.Quit();

            Console.ReadLine();



        }
    }
}
