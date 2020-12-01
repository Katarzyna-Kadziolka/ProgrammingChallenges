using System;
using System.Diagnostics;

namespace Project_Euler {
    class Euler12 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int minNumberOfFactors = 500;
            int startNumber = 2;
            int triangularNumber = 1;
            int numberOfFactors;
            do {
                triangularNumber = MathHelper.CreateTriangularNumber(startNumber, triangularNumber);
                numberOfFactors = MathHelper.GetNumberOfFactors(triangularNumber);
                startNumber++;
            } while (numberOfFactors < minNumberOfFactors);

            Console.WriteLine(triangularNumber);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}