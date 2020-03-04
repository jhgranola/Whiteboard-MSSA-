using System;

namespace ArrayPractice1
{
    public class Class1
    {
        public static int DistinctElements(int[] numbers)
        {
            int distinctCounter = numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number1 = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    int number2 = numbers[j];
                    if (number1 == number2 && i != j)
                    {
                        distinctCounter--;
                        break;
                    }
                }
            }
            return distinctCounter;
        }
    }
}
