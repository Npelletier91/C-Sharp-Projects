using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class MathOperation
    {
        public void operation (int number1, int number2)
        {
            int result = number1 * 10;
            Console.WriteLine(number1 + " * 10 = " + result);
            Console.WriteLine("The second integer parameter is: " + number2 + "\n");
        }
    }
}
