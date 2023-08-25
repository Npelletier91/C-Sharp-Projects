using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingOptional
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationMethod math = new OperationMethod();


            Console.WriteLine("Input a number:");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input another number or simply press enter:");
            string stringInput = Console.ReadLine();


            if (string.IsNullOrEmpty(stringInput))
            {
                int result1 = math.operation(userInput1);
                Console.WriteLine($"{userInput1} + 10 = {result1}");
            }
            else
            {
                int userInput2 = Convert.ToInt32(stringInput);
                int result2 = math.operation(userInput1, userInput2);
                Console.WriteLine($"{userInput1} + {userInput2} = {result2}");

            }
            Console.ReadLine();
        }
    }
}
