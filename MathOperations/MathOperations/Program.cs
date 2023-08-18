using System;


namespace MathOperations
{
    class Program
    {
        static void Main()
        {





            //----------------------------------------------------------------------------------------------
            //--------------------------MATH AND COMPARISON OPERATORS ASSIGNMENT----------------------------
            //----------------------------------------------------------------------------------------------

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            string hourlyRate1 = Console.ReadLine();
            int hourlyRateInt1 = Convert.ToInt32(hourlyRate1);

            Console.WriteLine("Hours worked per week:");
            string hoursPerWeek1 = Console.ReadLine();
            int hoursPerWeekInt1 = Convert.ToInt32(hourlyRate1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            string hourlyRate2 = Console.ReadLine();
            int hourlyRateInt2 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("Hours worked per week:");
            string weeksWorked2 = Console.ReadLine();
            int hoursPerWeekInt2 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("Annual salary of Person 1:");
            int person1Salary = hourlyRateInt1 * hoursPerWeekInt1 * 52;
            Console.WriteLine(person1Salary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            int person2Salary = hourlyRateInt1 * hoursPerWeekInt2 * 52;
            Console.WriteLine(person2Salary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = person1Salary > person2Salary;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();





            //int num1 = 34;
            //int num2 = 17;
            //int num5 = 5;
            //int total = num1 / num2;
            //int combined = total + num5;
            //Console.WriteLine("34 divided 17 plus 5 = " + combined.ToString());
            //Console.ReadLine();

            //int num3 = 4;
            //float num4 = 7.5f;
            //float total2 = num3 + num4;
            //// or int total2 = num1 + (Int32)num2; for returning an int
            //Console.WriteLine(total2);
            //Console.ReadLine();

            //string name = ("Nic");
            //int age = 32;
            //Console.WriteLine(name + age);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;

            ////bool isWarm = currentTemp > roomTemp;
            ////bool isWarm = currentTemp == roomTemp;
            //bool isWarm = currentTemp != roomTemp;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            //Console.WriteLine("Enter number to multiply it by 50");
            //string inputNumber1 = Console.ReadLine();
            //long num1 = Convert.ToInt64(inputNumber1);
            //long total1 = num1 * 50;
            //Console.WriteLine("The answer is " + total1);
            //Console.ReadLine();


            //Console.WriteLine("Enter number to add it by 25");
            //string inputNumber2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(inputNumber2);
            //int total2 = num2 + 25;
            //Console.WriteLine("The answer is " + total2);
            //Console.ReadLine();


            //Console.WriteLine("Enter number to d
            //ivide it by 12.5");
            //string inputNumber3 = Console.ReadLine();
            //float num3 = Convert.ToSingle(inputNumber3);
            //float total3 = num3 / 12.5f;
            //Console.WriteLine("The answer is " + total3);
            //Console.ReadLine();


            //Console.WriteLine("Enter number to check if it is greater than 50");
            //string inputNumber4 = Console.ReadLine();
            //float num4 = Convert.ToSingle(inputNumber4);
            //bool tureOrFalse = num4 > 50;
            //Console.WriteLine(tureOrFalse);
            //Console.ReadLine();

            //Console.WriteLine("Enter number to get remainder of it when divided by 7");
            //string inputNumber5 = Console.ReadLine();
            //int num5 = Convert.ToInt32(inputNumber5);
            //int remainder = num5 % 7;
            //Console.WriteLine("The remainder is " + remainder);
            //Console.ReadLine();
        }
    }
}
