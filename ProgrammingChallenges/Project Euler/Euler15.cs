using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Project_Euler {
    class Euler15 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int gridSize = 20;
            int n = gridSize + gridSize;
            int k = gridSize;

            BigInteger result = MathHelper.CalculateFactorial(n) / (MathHelper.CalculateFactorial(k) * MathHelper.CalculateFactorial(n - k));

            Console.WriteLine(result);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        
 
    }
}