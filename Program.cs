using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace Array_and_List
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZEARRAY = 5;
            var names = new List<String>();
            var numbers = new int[SIZEARRAY];
            var listOfNumbers = new List<Int32>();
            var count = 0;
            var i = 0;

            ///Facebook
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Roses are red, violets are blue …\n");
                Console.WriteLine(Facebook.CheckLikability(count,names));
                Console.WriteLine("\nEnter a name or just press ENTER to finish:");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name)) break;
                names.Add(name);
                count++;
            }
            ///2.
            while (true)
            {
                Console.WriteLine("\nEnter your name to reverse it or just press ENTER to finish:");
                var toReveName = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(toReveName))break;
                Console.WriteLine("Your name: "+ StringUtility.ReverseString(toReveName));
            }
            ///3.
            while (i<SIZEARRAY)
            {
                Console.WriteLine("Enter "+SIZEARRAY+" different numbers:");
                var number = ReadUtility.ReadInt32();
                if(numbers.Contains(number)) Console.WriteLine("Number has been previously enter. Try again.");
                else
                {
                    numbers[i] = number;
                    i++;
                }
            }
            Array.Sort(numbers);
            Console.WriteLine("Array of numbers: " + string.Join(", ", numbers));
            // 4 - Write a program and ask the user to continuously enter
            // a number or type "Quit" to exit. The list of numbers may
            // include duplicates.Display the unique numbers that the user has entered.
            var tempList = new List<int>();
            while (true)
            {
                var number = 0;
                Console.WriteLine("Enter a number or type \"Quit\" to exit");
                var readLine = Console.ReadLine();
                if (readLine.Equals("quit",StringComparison.InvariantCultureIgnoreCase)) break;
                number = ReadUtility.IsParsableToInt32(readLine);
                if (number == -1) continue;
                tempList.Add(number);
            }

            listOfNumbers = tempList.Distinct().ToList();
            Console.WriteLine(string.Join(", ",listOfNumbers));
        }
    }
}
