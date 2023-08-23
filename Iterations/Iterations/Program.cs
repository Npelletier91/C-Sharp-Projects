using System;
using System.Collections.Generic;


namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------------------PART 1-3----------------------------------------------
            //--------------------------------------------------------------------------

            string[] names = { "Nic", "Daniel", "Jesse", "John", "James", "Abby", "Anna", "Derek" };
            Console.WriteLine("Modify each string by adding text here:");
            string userInput = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + userInput;
            }

            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();


            //--------------------PART 4----------------------------------------------
            //--------------------------------------------------------------------------


            List<string> students = new List<string>() { "Nic", "Daniel", "Jesse", "John", "James", "Abby", "Anna", "Derek" };
            List<string> matchingList = new List<string>();

            Console.WriteLine("Search for a student with the first letter in their name:");
            char userLetter = Console.ReadLine()[0];

            for (int i = 0; i < students.Count; i++)
            {
                string student = students[i];
                if (student[0] == userLetter)
                {
                    matchingList.Add(student + " [" + i + "]");
                }
            }

            if (matchingList.Count > 0)
            {
                Console.WriteLine("Students matching the letter " + userLetter + ":");
                foreach (string matchingStudent in matchingList)
                {
                    Console.WriteLine(matchingStudent);
                }
            }
            else
            {
                Console.WriteLine("No names with " + userLetter + " were found in the student list.");
            }

            Console.ReadLine();


            //--------------------PART 5----------------------------------------------
            //--------------------------------------------------------------------------


            List<string> friends = new List<string>() { "Nic", "Daniel", "Jesse", "John", "James", "Abby", "Anna", "Derek", "Nic" };
            List<string> indices = new List<string>();

            Console.WriteLine("Search for a name in the list (for example \"Nic\"):");
            string searchName = Console.ReadLine();

            for (int i = 0; i < friends.Count; i++)
            {
                string name = friends[i];
                if (name.Contains(searchName))
                {
                    indices.Add("Index [" + i.ToString() + "]");
                }
            }

            if (indices.Count > 0)
            {
                Console.WriteLine("That name is at the below indices: ");
                foreach (string matchingName in indices)
                {
                    Console.WriteLine(matchingName);
                }
            }
            else
            {
                Console.WriteLine("That name is not on the list");
            }

            Console.ReadLine();



            //--------------------PART 6----------------------------------------------
            //--------------------------------------------------------------------------


            List<string> people = new List<string>() { "Nic", "Daniel", "Jesse", "John", "James", "Abby", "Anna", "Derek", "Nic" };
            List<string> secondList = new List<string>();

            Console.WriteLine("Press Enter to see list:");
            Console.ReadLine();

            foreach (string person in people)
            {
                if (secondList.Contains(person))
                {
                    secondList.Add(person);
                    Console.WriteLine(person + "(already appeared)");
                }
                else
                {
                    secondList.Add(person);
                    Console.WriteLine(person);
                }

            }
            
            Console.ReadLine();

















            //int[] testScores = { 98, 95, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();




            //string[] names = { "nic", "eric", "jesse", "daniel" };

            //for (int i = 0; i < names.Length; i++) 
            //{
            //        Console.WriteLine(names[i]);
            //}
            //Console.ReadLine();




            //List<int> testScores = new List<int>();

            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);
            //testScores.Add(55);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("passing score: " + score);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() { "Nic", "Jesse", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //        Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 98, 99, 43, 53, 83 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 82)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();


        }
    }
}
