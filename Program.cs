using System;
using System.Collections.Generic;

namespace Array_and_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var names = new List<String>();

            var count = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Roses are red, violets are blue …");
                Console.WriteLine(Facebook.CheckLikability(count,names));
                
                Console.WriteLine("\n\nEnter a name or just press ENTER to finish:");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name)) break;
                names.Add(name);
                count++;
            }

        }
    }
}
