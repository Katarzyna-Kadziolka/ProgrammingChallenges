using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace Project_Euler {
    class Euler16 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Console.WriteLine(BigInteger.Pow(2, 1000).ToString().Sum(n => Convert.ToInt16(n.ToString())));

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}