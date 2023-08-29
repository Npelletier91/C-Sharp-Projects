using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"ID: {ID}");
        }

        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }













        //public List<T> things { get; set; }
        //public int ID { get; set; }

        //public static bool operator ==(Employee employee, Employee employee2)
        //{
        //    return employee?.ID == employee2?.ID;  
        //}
        //public static bool operator !=(Employee employee, Employee employee2)
        //{
        //    return !(employee == employee2);
        //}
    }
}
