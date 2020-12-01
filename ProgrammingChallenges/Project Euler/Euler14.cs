using System;
using System.Diagnostics;

namespace Project_Euler {
    class Euler14 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long largestStartingNumber = GetLargestStartingNumberCollatzCount(1_000_000);


            Console.WriteLine(largestStartingNumber);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static long GetLargestStartingNumberCollatzCount(long maxNumber) {
            long currentNumber = 2;
            long maxLength = 0;
            long theLongestChainStarter = currentNumber;
            long[] cache = new long [maxNumber];
            for (long i = 2; i < maxNumber; i++) {
                long count = 1;
                currentNumber = i;
                while (currentNumber != 1 && currentNumber >= i) {
                    count++;
                    if (currentNumber % 2 == 0) {
                        currentNumber = currentNumber / 2;
                    }
                    else {
                        currentNumber = currentNumber * 3 + 1;
                    }
                }

                count = count + cache[currentNumber];
                cache[i] = count;

                if (count > maxLength) {
                    maxLength = count;
                    theLongestChainStarter = i;
                }
            }

            return theLongestChainStarter;
        }
    }
}