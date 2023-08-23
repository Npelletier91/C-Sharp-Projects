using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> years = new List<int>() { 1990, 2000, 1998, 1975, 2020, 2010, 1999 };
                List<int> dividedYears = new List<int>();

                Console.WriteLine("Type a number to divide each year by this number:");
                int divider = Convert.ToInt32(Console.ReadLine());

                foreach (int year in years)
                {
                    dividedYears.Add(year);
                    Console.WriteLine(year / divider);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please do not use the number 0.");
            }
            finally
            {
                Console.WriteLine("Continuing program.");
            }
            Console.ReadLine();
                









            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("please write a whole number");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("please dont divide by zero");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally // always shows after try. even when "return;" in first catch
            //{
            //    Console.ReadLine();

            //}



        }
    }
}
