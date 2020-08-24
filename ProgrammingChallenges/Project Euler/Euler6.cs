using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    class Euler6
    {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int maxNumber = 100;
            int squereOfSum = GetSquareOfSum(maxNumber);
            int sumOfSquers = GetSumOfSquers(maxNumber);

            Console.WriteLine(squereOfSum - sumOfSquers);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static int GetSquareOfSum(int maxNumber) {
            int result = 0;
            for (int i = 1; i < maxNumber + 1; i++) {
                result = result + i;
            }
            result = result * result;
            return result;
        }

        private static int GetSumOfSquers(int maxNumber) {
            int result = 0;
            for (int i = 1; i < maxNumber + 1; i++) {
                result = result + i * i;
            }
            return result;
        }
    }
}
