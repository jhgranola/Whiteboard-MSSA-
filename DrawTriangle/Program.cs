using System;

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
    }
}
// TODO: Attempt reducing to two for loops and a 2-D array.
