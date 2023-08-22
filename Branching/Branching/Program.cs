using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shippped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int dimensions = packageWidth + packageLength + packageHeight;
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int quote = (packageHeight * packageLength * packageWidth * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }







            //int roomTemp = 70;
            //Console.WriteLine("Hi what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi , " + name + ", what is the tempurature where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //string result = currentTemp > roomTemp ? "it is warmer than room temp" : "it is colder than room temp";


            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("it is room temp");
            //}
            //else if (currentTemp > roomTemp) 
            //{
            //    Console.WriteLine("it is warmer than room temp");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("it is colder than roomtemp");
            //}
            //else
            //{
            //    Console.WriteLine("opps, something went wrong");
            //}



            //int num1 = 6;
            //int num2 = 12;

            //string result = num1 > num2 ? "num1 is greater than num2" : "num2 is greater than num1";
            //Console.WriteLine(result);
            //Console.ReadLine();


            //if (num1 == num2)
            //{
            //    Console.WriteLine("numbers are equal");
            //}
            //else if (num1 > num2)
            //{
            //    Console.WriteLine("number 1 is greater than 2");
            //}
            //else
            //{
            //    Console.WriteLine("numbers are not equal");
            //}
            //Console.ReadLine();
        }
    }
}
