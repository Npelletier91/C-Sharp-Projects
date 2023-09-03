using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now.ToString());

            Console.WriteLine("Enter a number");
            double number = Convert.ToInt32(Console.ReadLine());

            DateTime newTime = (DateTime.Now.AddHours(number));

            Console.WriteLine(newTime);
            Console.ReadLine();



            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGrad = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGrad = yearOfGrad - yearOfBirth;


            //Console.WriteLine("Enter a number");
            //string number = Console.ReadLine();

            //using (StreamWriter input = new StreamWriter(@"C:\Users\Nicol\Logs\log1.txt", false))
            //{
            //    input.WriteLine(number);
            //}

            //number = File.ReadAllText(@"C:\Users\Nicol\Logs\log1.txt");
            //Console.WriteLine(number);
            //Console.ReadLine();
        }
    }
}
