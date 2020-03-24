using System;

// Given an array of integers, return the number of unique values in the array wihtout using helper methods.

namespace ReturnNumberOfDistinct
{
    public class Class1
    {
        public static int CountDistinctElements(int[] ints)
        {
            int distinctCount = 0;

            if (ints == null)
            {
                return 0;
            }

            for (int i = 0; i < ints.Length; i++)
            {
                int j = 0;
                for (j = 0; j < i ; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    distinctCount++;
                }
            }
            return distinctCount;
        }
    }
}
