using System;
using System.Diagnostics;
using System.Linq;

namespace Project_Euler
{
    class Euler4
    {
        public static void Calculate()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();


            int palindromMax = 0;
            for (int i = 100; i < 1_000; i++)
            {
                for (int j = i; j < 1_000; j++)
                {
                    int result = i * j;
                    string resultString = result.ToString();
                    if (resultString == string.Concat(resultString.Reverse()))
                    {
                        if (result > palindromMax)
                        {
                            palindromMax = result;
                        }
                    }
                }
            }
            
            Console.WriteLine(palindromMax);

            stopwatch.Stop();
            
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
