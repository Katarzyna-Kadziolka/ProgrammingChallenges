using System;
using System.Diagnostics;

namespace Project_Euler {
    class Euler9 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int GetMultiplyResult() {
                for (int i = 1; i < 333; i++) {
                    for (int j = 2; j < 500; j++) {
                        for (int k = 3; k < 998; k++) {
                            if (i + j + k == 1000) {
                                if (i * i + j * j == k * k) {
                                    return(i * j * k);
                                }
                            }
                        }
                    }
                }

                throw new InvalidOperationException();
            }

            int result = GetMultiplyResult();
            Console.WriteLine(result);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}