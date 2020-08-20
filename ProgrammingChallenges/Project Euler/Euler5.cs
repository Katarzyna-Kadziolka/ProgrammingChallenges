using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    class Euler5
    {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<int> factors = new List<int>();
            int largestDivisibleNumber = 20;
            for (int i = 2; i < largestDivisibleNumber + 1; i++) {
                List<int> componentFactors = MathHelper.BreakDownIntoPrimeFactors(i);
                factors = CheckListRepetitions(factors, componentFactors);
            }

            int result = MathHelper.GetProduct(factors);
            Console.WriteLine(result);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static List<int> CheckListRepetitions(List<int> factors, List<int> componentFactors) {
            for (int i = 0; i < componentFactors.Count; i++) {
                int number = componentFactors[i];
                int amountNumberInComponentFactors = componentFactors.Count(a => a == number);
                int amountNumberInFactors = factors.Count(a => a == number);
                if (amountNumberInFactors < amountNumberInComponentFactors) {
                    int difference = amountNumberInComponentFactors - amountNumberInFactors;
                    for (int j = 0; j < difference; j++) {
                        factors.Add(number);
                    }
                }
            }
            return factors;
        }
    }
}
