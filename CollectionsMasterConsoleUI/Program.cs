using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var task1 = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(task1);



            //TODO: Print the first number of the array
            Console.WriteLine("First number of the array");
            Console.WriteLine(task1.First());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            //TODO: Print the last number of the array
            Console.WriteLine("Last number of the array");
            Console.WriteLine(task1.Last());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(task1);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(task1);
            NumberPrinter(task1);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(task1);
            NumberPrinter(task1);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(task1);
            NumberPrinter(task1);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            /*   Set Up   */
            //TODO: Create an integer List

            var task2 = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(task2.Capacity);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populate(task2);
            
            
            //TODO: Print the new capacity
            Console.WriteLine(task2.Capacity);
            Console.WriteLine();
            NumberPrinter(task2);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool task3;
            int response;


            Console.WriteLine("What number will you search for in the number list?");
            task3 = int.TryParse(Console.ReadLine(), out response);
            while(!task3)
            {
                Console.WriteLine("Numbers Only");
                task3 = int.TryParse(Console.ReadLine(), out response);
            }
            NumberChecker(task2, response);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(task2);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(task2);
            NumberPrinter(task2);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            task2.Sort();
            NumberPrinter(task2);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            Console.WriteLine("Converting List to Array");
            var task5 = task2.ToArray();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();


            //TODO: Clear the list
            task2.Clear();


            #endregion
        }



        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(number => number %2 != 0);
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is in the List");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not in the list");
            }
        }
        

        private static void Populate(List<int> numberList)
        {
            var rd = new Random();
            for(int i = 1; i < 50; i++)
            {
                numberList.Add(rd.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            var rd = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rd.Next(0,50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            for(int i = array.Length ; i>=0; i--)
            {
                Console.WriteLine(i);
            }
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
