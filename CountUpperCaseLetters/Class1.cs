using System;

// Given a string, count the numer of upper case letters and return that count as an integer.

namespace CountUpperCaseLetters
{
    public class Class1
    {
        public static int CountUpper(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
