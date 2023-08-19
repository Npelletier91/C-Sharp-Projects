using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Answer using true or false.");
            string haveDUI = Console.ReadLine();
            bool haveDUIBool = Convert.ToBoolean(haveDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsInt = Convert.ToInt32(tickets);

            bool over15 = ageInt > 15;
            bool speedingTickets = ticketsInt < 3;

            Console.WriteLine("Qualified?");
            Console.WriteLine(over15 == true && haveDUIBool != true && speedingTickets == true);
            Console.ReadLine();








        }
    }
}
