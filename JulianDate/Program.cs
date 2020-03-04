using System;

// This exercise is that if given the year, month, and the day, return the julian date.
namespace JulianDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JulianDate.Program.Main");
            
            DateTime dt = new DateTime(2020, 2, 23);
            int julian = dt.Year * 1000 + dt.DayOfYear;
            Console.WriteLine(julian);

            //  This can be modified to only include the day number by removing the "dt.Year * 1000 +" from the code. By omitting this portion, only the day nunmber is displayed.
            //  EX.
            //  DateTime dt = new DateTime(2020, 2, 23);
            //  int julian = dt.DayOfYear;
            //  Console.WriteLine(julian);
            //  
            //  This would return 54.
        }
    }
}
