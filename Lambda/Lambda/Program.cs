using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>()
            {
                new Employee { FirstName = "Nic", LastName = "Pelletier", ID = 1},
                new Employee { FirstName = "Alice", LastName = "Johnson", ID = 2 },
                new Employee { FirstName = "John", LastName = "Doe", ID = 3 },
                new Employee { FirstName = "Jane", LastName = "Brown", ID = 4 },
                new Employee { FirstName = "Joe", LastName = "Williams", ID = 5 },
                new Employee { FirstName = "Robert", LastName = "Miller", ID = 6 },
                new Employee { FirstName = "Emily", LastName = "Davis", ID = 7 },
                new Employee { FirstName = "Joe", LastName = "Jones", ID = 8 },
                new Employee { FirstName = "Olivia", LastName = "Wilson", ID = 9 },
                new Employee { FirstName = "Samuel", LastName = "Taylor", ID = 10 }
            };

            List<Employee> joeList = new List<Employee>();

            foreach (Employee employee in empList)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} ID: {employee.ID}");
                };
            }
            Console.ReadLine();




            List<Employee> joeList2 = empList.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee2 in joeList2)
            {
                Console.WriteLine($"{employee2.FirstName} {employee2.LastName} ID: {employee2.ID}");
            }
            Console.ReadLine();




            List<Employee> IDList = empList.Where(x => x.ID > 5).ToList();

            foreach (Employee employee3 in IDList)
            {
                Console.WriteLine($"{employee3.FirstName} {employee3.LastName} ID: {employee3.ID}");
            }
            Console.ReadLine();

        }
    }
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
    }
}
