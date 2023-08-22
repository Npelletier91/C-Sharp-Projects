using System;
using System.Collections.Generic;


namespace ArraysandLists
{
    class Program
    {
        static void Main()
        {

            //ARRAY OF STRINGS

            string[] stringArray = { "Hello", "my name is", "Nic", "and I love to code" };
            Console.WriteLine("Select an index of the string Array between 0-3");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection >= 4)
                Console.WriteLine("That index does not exist.");
            else
                Console.WriteLine(stringArray[selection]);
                Console.ReadLine();



            //ARRAY OF INTEGERS

            int[] intArray = { 5, 3, 7, 5, 10, 4389, 123, 9876324 };
            Console.WriteLine("Select an index of the integer Array between 0-7");
            int intSelection = Convert.ToInt32(Console.ReadLine());
            if (intSelection >= 8)
                Console.WriteLine("That index does not exist.");
            else
                Console.WriteLine(intArray[intSelection]);
                Console.ReadLine();



            //LIST OF STRINGS

            List<string> stringList = new List<string>();

            stringList.Add("\"This\"");
            stringList.Add("\"Is\"");
            stringList.Add("\"My\"");
            stringList.Add("\"String\"");
            stringList.Add("\"List\"");

            Console.WriteLine("Select an index of the string list");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer >= 5)
                Console.WriteLine("That index does not exist.");
            else
                Console.WriteLine(stringList[answer]);
                Console.ReadLine();






            // LIST FUNDAMENTALS

            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();


            //List<string> stringList = new List<string>();
            //stringList.Add("hello");
            //stringList.Add("my name is");
            //stringList.Add("Nic");

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

            //List<int> intList1 = new List<int>();




            //ARRAY FUNDAMENTALS

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //// 
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            ////easier and faster
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 655;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();





        }
    }
}
