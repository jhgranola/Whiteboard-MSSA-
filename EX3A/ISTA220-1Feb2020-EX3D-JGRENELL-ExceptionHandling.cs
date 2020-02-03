using System;
/* This is Exercise 3A - Errors and Exceptions
 * Basic Difficulty
   
    Circles, hemispheres, and triangles
   
   For these formulas to work, you must enter a number consisting of digits --- alphabetical characters will not work.
   For these three parts, add a try/catch block for each formula that handles a FormatException error.
   Additionally, for these formulas to return valid values, input must be greater than zero.
   Add a try/catch block for a general exception using a filter or some other technique to guard against users entering numbers equal to or less than zero.
   
    */
namespace EX3A
{
    class Program
    {
       public static void Circle()
        {
            Console.WriteLine("\n\tThis will calculate the circumference and area of a circle.");
            Console.Write("\n\tPlease enter a radius:");
            try
            {
                var circRadius = checkInput();
                double Circumference = 2 * Math.PI * circRadius;
                double Area = Math.Pow(Math.PI * circRadius, 2);
                Console.WriteLine($"\nYour Circumference is {Circumference}");
                Console.WriteLine($"\nYour Area is {Area}");
            }
            catch (Exception)
            {
                Console.WriteLine("\nEntry invalid. Please try again.");
                Circle();
            }
        }
        public static void Hemisphere()
        {   Console.WriteLine("\nThis will calculate the volume of a hemisphere.");
            Console.Write("\nEnter an integer for the radius: ");
            try
            {
                var hemiRadius = checkInput();
                double Volume = ((4 / 3) * Math.PI * Math.Pow(hemiRadius, 3)) / 2;
                Console.WriteLine($"\n\tThe Volume of your hemisphere is {Volume}");
            }
            catch (Exception)
            {
                Console.WriteLine("\nEntry invalid. Please try again.");
                Hemisphere();
            }
        }
        public static void Quadratic()
        {
            Console.WriteLine("\nThis will calculate the quadration equation.");
            try
            {
                Console.Write("\nEnter an integer for  A: ");
                var coeA = checkInput();
                Console.Write("\nEnter an integer for B: ");
                var coeB = checkInput();
                Console.Write("\nEnter an integer for C: ");
                var coeC = checkInput();

                var denominator = (2.0 * coeA);

                double positive_num = -coeB + Math.Sqrt(Math.Pow(coeB, 2) - (4.0 * coeA * coeC)) / denominator;

                double negative_num = -coeB - Math.Sqrt(Math.Pow(coeB, 2) - (4.0 * coeA * coeC)) / denominator;

                Console.WriteLine($"The positive solution is {positive_num / denominator}");
                Console.WriteLine($"The negative solution is {negative_num / denominator}");
            }
            catch (Exception)
            {
                Console.WriteLine("\nEntry invalid. Please try again.");
                Quadratic();
            }
            finally
            {
                Console.WriteLine("\nThis program has finally terminated");
            }
        }
        public static int checkInput()
        {
            bool isValid = true;
            var userInput = int.Parse(Console.ReadLine());
            while (isValid = true)
            {
                if (userInput <= 0)
                {
                    isValid = false;
                    Console.WriteLine("Entry invalid. Please try again.");
                    userInput = int.Parse(Console.ReadLine());
                    continue;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return userInput;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ErrorsAndExceptions.Program.Main");
           
            Circle();
            Hemisphere();
            Quadratic();

        }
    }
}
