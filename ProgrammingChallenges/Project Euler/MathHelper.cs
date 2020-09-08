using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Project_Euler {
    class MathHelper {
        public static bool IsPrime(long num) {
            if (num <= 1) {
                return false;
            }

            if (num == 2) {
                return true;
            }

            double square = Math.Sqrt(num);
            for (int i = 2; i < square + 1; i++) {
                if (num % i == 0) {
                    return false;
                }
            }

            return true;
        }

        public static List<int> CreateFibonacciSequence(int maxNumber) {
            List<int> fibonacciSequence = new List<int>() { 1, 1 };
            int numberIndex = 0;
            while (true) {
                int newNumber = fibonacciSequence[numberIndex] + fibonacciSequence[numberIndex + 1];
                if (newNumber < maxNumber) {
                    fibonacciSequence.Add(newNumber);
                    numberIndex++;
                }
                else
                    break;
            }

            return fibonacciSequence;
        }

        public static List<int> BreakDownIntoPrimeFactors(int number) {
            List<int> primeFactors = new List<int>();
            while (number != 1) {
                for (int i = 2; i < number + 1; i++) {
                    if (number % i == 0) {
                        primeFactors.Add(i);
                        number = number / i;
                        break;
                    }
                }
            }
            return primeFactors;
        }

        public  static int GetProduct(List<int> factors ) {
            int result = 1;
            for (int i = 0; i < factors.Count; i++) {
                result = result * factors[i];
            }
            return result;
        }

        public static int CreateTriangularNumber(int numberToAdd, int oldTriangularNumber) {
            int triangularNumber = oldTriangularNumber + numberToAdd;

            return triangularNumber;
        }

        public static List<int> GetFactors(int number) {
            List<int> factors = new List<int>();
            for (int i = 1; i < number + 1; i++) {
                if (number % i == 0) {
                    factors.Add(i);
                }
            }

            return factors;
        }

        public static int GetNumberOfFactors(int number) {
            List<int> primeFactors = BreakDownIntoPrimeFactors(number);

            int numberOfFactors = primeFactors
                .GroupBy(a => a)
                .Select(a => new {Count = a.Count() })
                .Aggregate(1, (x, y) => x * (y.Count + 1));
            return numberOfFactors;
        }
    }
}