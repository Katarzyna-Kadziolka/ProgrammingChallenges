using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Euler
{
    class Euler3
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long n = 600851475143;
            List<long> factors = new List<long>();

            while (n != 1)
            {
                for (long i = 2; i < n + 1; i++)
                {
                    if (n % i == 0)
                    {
                        factors.Add(i);
                        n = n / i;
                        break;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine(factors.Last());
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
