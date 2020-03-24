using System;

// Given an array of doubles. Return the sum of all doubles in the array without using helper methods.

namespace ReturnSumOfDoubles
{
    public class Class1
    {
        public static double GetSum(double[] doubles)
        {
            double doubleSum = 0;
            for (int i = 0; i < doubles.Length; i++)
            {
                doubleSum += doubles[i];
            }
            return doubleSum;
        }
    }
}
