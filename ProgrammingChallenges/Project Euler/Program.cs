using System;
using System.Collections.Generic;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> availableNumbersList = new List<Int32>() {1, 2, 3, 4, 9, 10};
            int number;
            System.Console.WriteLine("Avaible Euler's Problems:\n" +
                                     "1. Multiples of 3 and 5\n" +
                                     "2. Even Fibonacci numbers\n" +
                                     "3. Largest prime factor\n" +
                                     "4. Largest palindrome product\n" +
                                     "5. Smallest multiple\n" +
                                     "6. Sum square difference\n" +
                                     "7. 10001st prime\n" +
                                     "9. Special Pythagorean triplet\n" +
                                     "10. Summation of primes\n" +
                                     "11. Largest product in a grid\n" +
                                     "12. Highly divisible triangular number");

            Console.WriteLine("Please, choose the number of Euler's Problem: ");
            try {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) {
                Console.WriteLine("It wasn't a number");
                return;
            }

            if (number == 1) {
                Euler1.Calculate();
            }
            else if (number == 2) {
                Euler2.Calculate();
            }
            else if (number == 3) {
                Euler3.Calculate();
            }
            else if (number == 4) {
                Euler4.Calculate();
            }
            else if (number == 5) {
                Euler5.Calculate();
            }
            else if (number == 6) {
                Euler6.Calculate();
            }
            else if (number == 7) {
                Euler7.Calculate();
            }
            else if (number == 9) {
                Euler9.Calculate();
            }
            else if (number == 10) {
                Euler10.Calculate();
            }
            else if (number == 11) {
                Euler11.Calculate();
            }
            else if (number == 12) {
                Euler12.Calculate();
            }
            else
                Console.WriteLine("This number isn't avaible");
                
        }
    }
}
