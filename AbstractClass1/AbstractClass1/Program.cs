using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student",};
            Employee employee2 = new Employee() { firstName = "Sample2", lastName = "Student2"};

            employee.SayName();
            employee2.SayName();

            Console.ReadLine();

        }
    }
}
