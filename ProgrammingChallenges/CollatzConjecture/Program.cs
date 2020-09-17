using System;
using System.Collections.Generic;
using System.Linq;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in the Collatz Sequence Generator!");
            int startNumber = 0;
            do {
                Console.WriteLine("Please, enter the starting number (it should be bigger than 1): ");
                do {
                    try {startNumber = Convert.ToInt32(Console.ReadLine()); }
                    catch (System.FormatException) {
                        Console.WriteLine("It's not a number!");
                    }
                } while (false);
                
            } while (startNumber == 0);
            List<long> collatzSequence = CollatzGenerator.CreateCollatzSequece(startNumber);
            List<string> collatzSequenceString = new List<string>();
            for (int i = 0; i < collatzSequence.Count; i++) {
                collatzSequenceString.Add(collatzSequence[i].ToString());
            }
            for (int i = 0; i < collatzSequenceString.Count - 1; i++) {
                collatzSequenceString[i] = collatzSequenceString[i] + ", ";
            }
            Console.WriteLine("Your Collatz Sequence: ");
            collatzSequenceString.ForEach(Console.Write);
        }
        
    }
}
