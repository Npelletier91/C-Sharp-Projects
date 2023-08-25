using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    public class DivideMethod
    {
        public void divideOperation(int number1, out int sum)
        {
            sum = number1 / 2;
        }
        public void divideOperation(Single number1, Single number2)
        {
            Single result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");
        }
        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
