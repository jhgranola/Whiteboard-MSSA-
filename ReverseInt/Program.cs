using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ReverseInt(12345));
        }
        public static int ReverseInt(int number)
        {
            int reverse = 0;
            while (number > 0)
            {   // Reverse holds the numbers that have already been iterated through.
                // The % 10 takes the last value and places it in the opposite index.
                reverse = reverse * 10 + number % 10;
                number = number / 10; // Removes the multplier above.
            }
            return reverse;
        }
    }
}
