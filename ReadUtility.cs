using System;

namespace Array_and_List
{
    static class ReadUtility
    {
        public static int ReadInt32()
        {
            var number = 0;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            }
            return number;
        }

        public static int IsParsableToInt32(string toParse)
        {
            var number = -1;
            try
            {
                //number = Int32.Parse(toParse);
                number = Convert.ToInt32(toParse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return number;
        }

    }
}
