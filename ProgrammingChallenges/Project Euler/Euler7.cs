using System;
using System.Diagnostics;

namespace Project_Euler {
    class Euler7 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int expectedPrimeNumber = 10001;
            int currentPrimeNumber = 0;
            int number = 0;
            do {
                number++;
                if (MathHelper.IsPrime(number)) {
                    currentPrimeNumber++;
                }
            } while (currentPrimeNumber < expectedPrimeNumber);

            Console.WriteLine(number);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}