using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;


            while (!isGuessed)
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed " + number + "! try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed " + number +"! try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine(number + "  is correct! Play again?");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + number + ", you are wrong, try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }










            Console.WriteLine("Guess a second number!");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool isGuessed2 = number  == 66;

            do
            {
                switch (number2)
                {
                    case 44:
                        Console.WriteLine("You guessed 44, try again");
                        Console.WriteLine("Guess a number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 33:
                        Console.WriteLine("You guessed 33, try again");
                        Console.WriteLine("Guess a number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 66:
                        Console.WriteLine("66 is correct!");
                        Console.ReadLine();
                        isGuessed2 = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong, try again");
                        Console.WriteLine("Guess a number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed2);
        }
    }
}
