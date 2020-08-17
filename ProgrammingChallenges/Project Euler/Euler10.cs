using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Euler
{
    class Euler10
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<long> primeNumbers = new List<long>();
            for (int i = 1; i < 2_000_000; i++)
            {
                if (MathHelper.IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }
            long primeNumbersSum = primeNumbers.Sum();
            Console.WriteLine(primeNumbersSum);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
