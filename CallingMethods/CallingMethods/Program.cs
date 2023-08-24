using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a number to do math operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());


            Operations operation = new Operations();

            int result1 = operation.AddTen(userInput);
            int result2 = operation.Square(userInput);
            int result3 = operation.Triple(userInput);

            Console.WriteLine(userInput + " + 10 = " + result1);
            Console.WriteLine(userInput + "^2 = " + result2);
            Console.WriteLine(userInput + " * 3 = " + result3);


            Console.ReadLine();
        }
    }
}
