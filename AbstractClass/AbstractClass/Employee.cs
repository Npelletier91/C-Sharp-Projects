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
            base.SayName();
            Console.WriteLine($"ID: {ID}");
        }
        
        public int ID { get; set; }
        
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }
    }
}
