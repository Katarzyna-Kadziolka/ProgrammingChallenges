using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Euler
{
    class Euler7 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int expectedPrimeNumber = 10001;
            int currentPrimeNumber = 0;
            int number = 0;
            do {
                number++;
                if (MathHelper.IsPrime(number) == true) {
                    currentPrimeNumber++;
                } 

            } while (currentPrimeNumber < expectedPrimeNumber);

            Console.WriteLine(number);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
