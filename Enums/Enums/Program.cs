using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day of the week:");
            string userInput = Console.ReadLine();
            DaysOfTheWeek today = DaysOfTheWeek.Monday;

            try
            {
                DaysOfTheWeek selectedDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);

                if (today == selectedDay)
                {
                    Console.WriteLine(today + " is the currenty date!");
                }
                else
                {
                    Console.WriteLine(selectedDay + " is not a valid day");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter an actual day of the week.");
            }


            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
