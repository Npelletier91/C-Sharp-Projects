using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    public class Employee : Person
    {

        public static bool operator ==(Employee employee, Employee employee2)
        {
            return employee?.ID == employee2?.ID;
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            return !(employee == employee2);
        }
    }
}
