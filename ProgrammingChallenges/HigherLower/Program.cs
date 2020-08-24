using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace HigherLower {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello! Please, choose a difficult level:\n" +
                              "1. Easy (1 - 10)\n" +
                              "2. Medium (1 - 100)\n" +
                              "3. Hard (1 - 1000)\n" +
                              "4. Clairvoyant (1 - 1000_000)");
            int difficultLevel = Convert.ToInt32(Console.ReadLine());
            
            while (difficultLevel != 1 && difficultLevel != 2 && difficultLevel != 3 && difficultLevel != 4) {
                Console.WriteLine("Please, choose avaible difficult level");
                difficultLevel = Convert.ToInt32(Console.ReadLine());
            }
            int attempt = 1;
            int number = GetRandomNumber(difficultLevel);
            Console.WriteLine("Game Start!\n" +
                              "Enter valid number:");
            int inputNumber = Convert.ToInt32((Console.ReadLine()));
            while (inputNumber != number) {
                if (inputNumber < number) {
                    Console.WriteLine("Higher");
                    attempt++;
                }
                else if (inputNumber > number) {
                    Console.WriteLine("Lower");
                    attempt++;
                }
                inputNumber = Convert.ToInt32((Console.ReadLine()));
            }

            Console.WriteLine("You won!\n" +
                              $"Attempts: {attempt}");
        }

        static private int GetRandomNumber(int difficultLevel) {
            int number = 0;
            if (difficultLevel == 1) {
                number = new Random().Next(1, 10); 
            }
            else if (difficultLevel == 2) {
                number = new Random().Next(1, 100);
            }
            else if (difficultLevel == 3) {
                number = new Random().Next(1, 1000);
            }
            else if (difficultLevel == 4) {
                number = new Random().Next(1, 1000);
            }
            else {
                Console.WriteLine("Please, choose avaible difficult level");
            }

            return number;
        }
    }
}