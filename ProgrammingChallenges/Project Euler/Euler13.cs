using System;
using System.Diagnostics;
using System.IO;
using System.Numerics;

namespace Project_Euler {
    class Euler13 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();
            string[] lines = File.ReadAllLines("./Euler13.txt");
            BigInteger numbersSum = 0;
            for (int i = 0; i < lines.Length; i++) {
                numbersSum = numbersSum + (BigInteger.Parse(lines[i]));
            }

            string s = numbersSum.ToString()[0..10];
            Console.WriteLine(s);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}