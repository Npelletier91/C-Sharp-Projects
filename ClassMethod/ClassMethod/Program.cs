using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of the class to use in program
            DivideMethod math = new DivideMethod();

            //taking user input to use for math operation
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            //setting variable to use when calling the "out" of the method.
            int sum;

            //calling the method with user input
            math.divideOperation(userInput, out sum);

            //printing the method with the "out" value included
            Console.WriteLine($"{userInput} / 2 = {sum}");
            Console.ReadLine();


            Console.WriteLine("Enter a number:");
            Single userInput2 = Convert.ToSingle(Console.ReadLine());

            //calling the overloaded method with two parameters as "floats"
            math.divideOperation(userInput2, 432);
            Console.ReadLine();


            Console.WriteLine("Enter one number at a time to multiply them");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            //printing the static method to the console without creating an instance of the class "DivideMethod"
            Console.WriteLine($"{num1} * {num2} = {MultiplyOperation.Multiply(num1, num2)}");
            Console.ReadLine();

        }
    }
}
