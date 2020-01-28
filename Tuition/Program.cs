using System;

//This program will calculate tuition over a five year period
//Tuition will start at $6000 and increase by 2% each year
//The display will be as follows:
// For year n your tuition will be x
namespace Tuition
{
    class Program
    {
        public static void AnnualTuitionCost()
        {
            decimal tuition = 6000.00m;

            for (int year = 0; year < 5; year++)
            {
                Console.WriteLine($"\t\nFor Year {year + 1}, your tuition will be {tuition}");
                tuition *= 1.02m;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("tuition.Program.Main");
            AnnualTuitionCost();
        }
    }
}
