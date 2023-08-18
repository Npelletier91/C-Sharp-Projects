using System;


namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            // this is a simple program
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNumberInt = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursWorked = Console.ReadLine();
            int hoursworkedInt = Convert.ToInt32(hoursWorked);

            Console.WriteLine("Thank you for your answers" + yourName + ". An Instructor will respond to this shortly. Have a great day!");



        }
    }
}
