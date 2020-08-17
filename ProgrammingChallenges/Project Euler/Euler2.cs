using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_Euler
{
    class Euler2
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
            int evenNumSum = evenNumbers.Sum();
            Console.WriteLine(evenNumSum);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
