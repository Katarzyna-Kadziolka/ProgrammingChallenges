﻿using System;
using System.Collections.Generic;

namespace CollatzConjecture {
    class Program {
        static void Main() {
            Console.WriteLine("Welcome in the Collatz Sequence Generator!");
            int startNumber = 0;
            do {
                Console.WriteLine("Please, enter the starting number (it should be bigger than 1): ");
                try {
                    startNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) {
                    Console.WriteLine("It's not a number!");
                }
            } while (startNumber <= 0);

            List<long> collatzSequence = CollatzGenerator.CreateCollatzSequece(startNumber);
            Console.WriteLine("Your Collatz Sequence: ");
            collatzSequence.ForEach(l => Console.Write(l + "; "));
        }
    }
}