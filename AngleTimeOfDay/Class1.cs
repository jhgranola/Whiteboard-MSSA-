using System;

// Given two numbers, one representing the time in hours and one representing it in minutes, return the value of the angle created by the hands on a clock.
// Example: If the Time is 3:15, the return will be 0 degrees. If the time is 12:45, the return will be 90 degrees. Finally, if the time is 1:35, return 180 degrees.

namespace AngleTimeOfDay
{
    public class Class1
    {
        public static double GetHandAngle(int hr, int min)
        {
            double minAngle = 0;
            double hrAngle = 0; // I am initializing these variables now because there will be a compiler error if they are initialized within a loop.
            if (hr <= 12 && hr > 0)
            {
                hrAngle = (double)hr / 12.0 * 360; // This if/else statement ensures I recieve proper input for the hour and does the computing.
            }
            else
            {
                Console.WriteLine("Please use a valid input"); // This prompts the user to revise their input if it is invalid.
            }
            if (min <= 60 && min > 0)
            {
                minAngle = (double)min / 60 * 360;
            }
            else
            {
                Console.WriteLine("Please use a valid input");
            }
            double angleDifference = Math.Abs(hrAngle - minAngle); // Here I establish the angle difference as a variable and finds the absolute value.
            if (angleDifference > 180)
            {
                angleDifference -= 180; // Finally, I subtract 180 for cases where the difference is over 180. Otherwise 1245 would return 270 degrees instead of 90.
            }
            return angleDifference;
        }
    }
}
