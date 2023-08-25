using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation math = new MathOperation();

            math.operation(6, 7);
            math.operation(number1: 231, number2: 654);
            math.operation(number2: 1000, number1: 5);

            Console.ReadLine();
        }
    }
}
