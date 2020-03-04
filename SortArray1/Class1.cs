using System;

//  Create an algorithm for sorting a stack of playing cards.

namespace SortArray1
{
    public class ArraySort
    {
        public static int[] Sort(int[] arr)
        {
            int p; // value placeholder
            for (int i = 0; i <= arr.Length; i++) // Comparing the value of the integer at [i] to the value at [i+1]
            {
                if (arr[i] > arr[i+1])      // If the value is higher
                {
                    for (int x = i; x < arr.Length; x++) //   Shifts the value [i] to [i + 1]
                    {
                        if (arr[x] >arr[x+1])   //      
                        {
                            p = arr[x + 1];
                            arr.SetValue(arr[x], x + 1);
                            arr.SetValue(p, x);
                        }
                    }
                }
            }
            return arr;
        }    
    }
}
