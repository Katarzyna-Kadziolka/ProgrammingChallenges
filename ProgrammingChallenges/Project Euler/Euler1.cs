using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_Euler {
    class Euler1 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<int> multiples = new List<int>();
            for (int i = 1; i < 1_000; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    multiples.Add(i);
                }
            }

            Console.WriteLine(multiples.Sum());
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}