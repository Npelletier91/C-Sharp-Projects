using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationMethod math = new OperationMethod();

            int integer = 5;

            int result1 = math.operation(integer);
            Console.WriteLine(integer + " - 5 = " + result1);
            Console.ReadLine();

            int result2 = math.operation(Convert.ToDecimal(integer));
            Console.WriteLine(integer + " * 1000 = " + result2);
            Console.ReadLine();

            int result3 = math.operation(Convert.ToString(integer));
            Console.WriteLine(integer + " * " + math.RandomNumber + " = " + result3);
            Console.ReadLine();

        }
    }
}
