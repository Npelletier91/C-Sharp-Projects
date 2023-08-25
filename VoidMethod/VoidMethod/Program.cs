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

            int example1 = 123;
            int example2 = 456;

            math.operation(example1, example2);

            Console.ReadLine();
        }
    }
}
