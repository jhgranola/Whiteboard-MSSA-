using System;

namespace PrimeCounter
{
    class Program
    {
        public static bool isPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i < num; ++i)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        public static int GetPrimeSum(int n)
        {
            int primeSum = 0, primeCounter = 2;
            int numberOfPrimes = 0;
            while (numberOfPrimes < n)
            {
                if (isPrime(primeCounter))
                {
                    primeSum += primeCounter;
                    numberOfPrimes++;
                }
                primeCounter++;
            }
            return primeSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrimeSum(5));
        }
    }
}
