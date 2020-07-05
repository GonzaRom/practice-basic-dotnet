using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_and_List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int SIZEARRAY = 5;
            var names = new List<string>();
            var numbers = new int[SIZEARRAY];
            var listOfNumbers = new List<int>();
            var count = 0;
            var i = 0;
            var number = 0;

            ///Facebook
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Roses are red, violets are blue …\n");
                Console.WriteLine(Facebook.CheckLikability(count, names));
                Console.WriteLine("\nEnter a name or just press ENTER to finish:");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) break;
                names.Add(name);
                count++;
            }

            ///2.
            while (true)
            {
                Console.WriteLine("\nEnter your name to reverse it or just press ENTER to finish:");
                var toRevertName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(toRevertName)) break;
                Console.WriteLine("Your name: " + StringUtility.ReverseString(toRevertName));
            }

            ///3.
            while (i < SIZEARRAY)
            {
                Console.WriteLine("Enter " + SIZEARRAY + " different numbers:");
                number = ReadUtility.ReadInt32();
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Number has been previously enter. Try again.");
                }
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
                Console.WriteLine("Enter a number or type \"Quit\" to exit");
                var readLine = Console.ReadLine();
                if (readLine.Equals("quit", StringComparison.InvariantCultureIgnoreCase)) break;
                number = ReadUtility.IsParsableToInt32(readLine);
                if (number == -1) continue;
                tempList.Add(number);
            }

            listOfNumbers = tempList.Distinct().ToList();
            Console.WriteLine(string.Join(", ", listOfNumbers));

            while (true)
            {
                Console.WriteLine("Enter a few numbers separated by a hyphen ex(20-21-22-23)");
                var input = Console.ReadLine();
                listOfNumbers.Clear();

                listOfNumbers = new List<int>();
                foreach (var currentNumber in input.Split('-'))
                    listOfNumbers.Add(Convert.ToInt32(number));

                listOfNumbers.Sort();

                var isConsecutive = true;
                for (i = 1; i < listOfNumbers.Count; i++)
                {
                    if (listOfNumbers[i] != listOfNumbers[i - 1] + 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }

                var message = isConsecutive ? "Consecutive" : "Not Consecutive";
                Console.WriteLine(message);

            }
        }
    }
}