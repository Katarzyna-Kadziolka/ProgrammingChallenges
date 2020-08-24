using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler12
    {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int minNumberOfFactors = 500;
            List<int> factors = new List<int>();
            int startNumber = 1;
            int triangularNumber = 0;
            do {
                factors.Clear();
                triangularNumber = MathHelper.CreateTriangularNumber(startNumber, triangularNumber);
                factors = MathHelper.BreakDownIntoPrimeFactors(triangularNumber);
                startNumber++;

            } while (factors.Count <minNumberOfFactors -2);

            Console.WriteLine(triangularNumber);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }


    }
}
