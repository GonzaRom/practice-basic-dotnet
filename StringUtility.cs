using System;

namespace Array_and_List
{
    public static class StringUtility
    {
        public static string ReverseString(string toReverse)
        {
            if (String.IsNullOrWhiteSpace(toReverse)) return " ";
            var reversArray = toReverse.ToCharArray();
            Array.Reverse(reversArray);
            return new string(reversArray);
        }
    }
}