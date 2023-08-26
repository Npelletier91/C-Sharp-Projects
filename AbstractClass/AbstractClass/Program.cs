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
            employee.SayName();

            IQuittable quittableEmployee = employee;
            quittableEmployee.Quit();

            Console.ReadLine();


        }
    }
}
