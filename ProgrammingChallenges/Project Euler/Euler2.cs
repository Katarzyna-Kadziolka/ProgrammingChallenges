using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Euler
{
    class Euler_2
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<int> fibonacciSequence = MathHelper.CreateFibonacciSequence(4_000_000);
            List<int> evenNumbers = new List<int>();
            
            for (int i = 0; i < fibonacciSequence.Count - 1; i++)
            {
                if (fibonacciSequence[i] % 2 != 0)
                {
                    evenNumbers.Add(fibonacciSequence[i]);
                }
            }
            int even_num_sum = evenNumbers.Sum();
            Console.WriteLine(even_num_sum);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
