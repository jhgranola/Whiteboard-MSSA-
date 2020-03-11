using System;

// Given a string, return an integer representing the number of capital letters within the string.

namespace CountCapitals
{
    class Program
    {
        public static int CountCapitals(string input)
        {
            int capCount = 0;
            char[] arr = input.ToCharArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != char.ToLower(arr[i]))
                {
                    capCount++;
                }
            }

            return capCount;
        }

        public static int CountCap(string input)
        {
            int capCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] <= 'Z' && input[i] >= 'A')
                {
                    capCount++;
                }
            }
            return capCount;
        }
        static void Main(string[] args)
        {
            // Setting up stopwatches as a first attempt at comparing the efficiency of different methods.
            var watch = new System.Diagnostics.Stopwatch();
            var watch2 = new System.Diagnostics.Stopwatch();
            var watch3 = new System.Diagnostics.Stopwatch();
            var watch4 = new System.Diagnostics.Stopwatch();
            var watch5 = new System.Diagnostics.Stopwatch();
            var watch6 = new System.Diagnostics.Stopwatch();

            watch.Start();
            Console.WriteLine(CountCapitals("Mooses Eat Food"));
            watch.Stop();
            Console.WriteLine($"Execution time for first version first test: {watch.ElapsedMilliseconds} ms");

            watch2.Start();
            Console.WriteLine(CountCapitals("Dan likes To Code lots of Things"));
            watch2.Stop();
            Console.WriteLine($"Execution time for first version first test: {watch.ElapsedMilliseconds} ms");

            watch3.Start();
            Console.WriteLine(CountCapitals("Jeremy hates Asking Danny for Help"));
            watch3.Stop();
            Console.WriteLine($"Execution time for first version first test: {watch.ElapsedMilliseconds} ms");

            watch4.Start();
            Console.WriteLine(CountCap("Mooses Eat Food"));
            watch4.Stop();
            Console.WriteLine($"Execution time for first version first test: {watch.ElapsedMilliseconds} ms");

            watch5.Start();
            Console.WriteLine(CountCap("Dan likes To Code lots of Things"));
            watch5.Stop();
            Console.WriteLine($"Execution time for first version first test: {watch.ElapsedMilliseconds} ms");

            watch6.Start();
            Console.WriteLine(CountCap("Jeremy hates Asking Danny for Help"));
            watch6.Stop();
            Console.WriteLine($"Execution time for first version first test: {watch.ElapsedMilliseconds} ms");
        }
    }
}
