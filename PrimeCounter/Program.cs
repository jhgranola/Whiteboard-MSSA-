using System;

// Given an integer, I need to return the sum of that number of primes going in ascending order.
// Example: Given the integer 5, I will need to calculate the sum of 2, 3, 5, 7, and 11, and the return should be 28.

namespace PrimeCounter
{
    class Program
    {
        // First, I will need to create a method to determine whether or not the numbers being encountered are primes.
        public static bool IsPrime(int num)
        {
            if (num < 2) return false; // This if statement refutes the number 1.
            for (int i = 2; i < num/2; ++i) // I am using a for loop to evaluate each number given to it. Only go halfway up in order to improve efficiency.
            {
                if (num % i == 0) return false; // I am diving things by 2, if there is no remainder, then the number is not a prime.
            }
            return true;
        }
        public static int GetPrimeSum(int n)
        {
            int primeSum = 0, counter = 0, numberOfPrimes = 0;
            while (numberOfPrimes < n) // This loop ensures that I sum the number of primes given.
            {
                if (IsPrime(counter)) // This uses the method I created above.
                {
                    primeSum += counter;
                    numberOfPrimes++; // If the counter reaches a prime, it is added to the number of primes, as well as the sum.
                }
                counter++; // If the number being evaluated is not a prime, it simply moves on to the next number.
            }
            return primeSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrimeSum(5));
        }
    }
}
