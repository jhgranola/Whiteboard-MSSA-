﻿using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            try
            {
                Console.Write("Enter number between 1 and 10: ");
                input = Convert.ToInt32(Console.In.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (input > 10 || input < 1)
            {
                Console.WriteLine("Please enter a valid number: ");
                input = Convert.ToInt32(Console.In.ReadLine());
            }
            else
            {
                Draw_Equilateral_Triangle(input);
                ArrayStar(input);
            }
        }
        public static void Draw_Equilateral_Triangle(int num)
        {
            if (num > 10 || num < 1)
            {
                Console.WriteLine("Please enter a number between 1 and 10");
            }
            for (int i = 0; i < num; i++)
            {
                // Draw some sapces before we start drawing the asterisks sequence
                for (int j = num - i; j > 0; j--)
                    Console.Write(" ");
                // Draw asterisks and one space because we want an equilateral triangle
                for (int j = 0; j <= i; j++)
                    Console.Write("*" + " ");
                // Create new line for the next asterisks sequence
                Console.WriteLine();
            }
        }
        public static void ArrayStar(int input)
        {
            //creates an empty character array 
            char[,] starArray = new char[(2 * input) - 1, input];

            //determines the midpoint index of a row
            int midPoint = starArray.GetLength(0) / 2;

            //stores the stars at inteneded locations in the array
            for (int i = 0; i < starArray.GetLength(1); i++)
            {
                //even index rows have a star at the midpoint
                if (i % 2 == 0)
                {
                    starArray[midPoint, i] = '*';
                }

                //all rows have stars at every other paired index from the midpoint determined by the row they are on
                for (int j = i; j > 0; j -= 2)
                {
                    starArray[midPoint + j, i] = '*';
                    starArray[midPoint - j, i] = '*';
                }
            }
            //prints each index of the array
            for (int y = 0; y < starArray.GetLength(1); y++)
            {
                for (int x = 0; x < starArray.GetLength(0); x++)
                {
                    Console.Write(starArray[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
// TODO: Attempt reducing to two for loops and a 2-D array.
