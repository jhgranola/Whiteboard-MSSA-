using System;

namespace MonteCarlo
{
    // This is a Monte Carlo Simulation program
    // that runs an infinite loop towards pi.
    class Program
    {
        public static Tuple<double, double> GetCoords(Random r)
        {
            double A = 0.0;
            double B = 0.0;

            return Tuple.Create(A, B);
        }

        public static double Radius(double X, double Y) => Math.Sqrt(X * X + Y * Y);

        public static void EstimatePi()
        {
            // Initialize Random
            Random r = new Random();
            int exponent = 1;

            while (true)
            {
                //Reset Counters
                exponent++;
                int iterations;
                int inCircleCount = 0;
                // Run through monte-carlo method
                for (iterations = 1; iterations < Math.Pow(10, exponent); iterations++)
                {
                    double X = r.NextDouble();
                    double Y = r.NextDouble();
                    double Z = Radius(X, Y);
                    // Alternative to the below staement using a Query Colon: inCircleCount += (Z <= 1) ? 1 : 0;
                    if (Z <= 1.0) inCircleCount++;
                }
                //Print Result
                Console.WriteLine((double)4.0 * (double)inCircleCount / (double)iterations);
            }
        }
        static void Main(string[] args)
        {
            EstimatePi();
            Console.WriteLine("pi.Program.Main()");
        }

    }
}
