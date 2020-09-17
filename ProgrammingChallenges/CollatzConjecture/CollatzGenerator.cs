using System;
using System.Collections.Generic;
using System.Text;

namespace CollatzConjecture
{
    class CollatzGenerator
    {
        public static List<long> CreateCollatzSequece(int startingNumber){
            List<long> collatzSequence = new List<long> ();
            CreateCollatz(collatzSequence, startingNumber);
            return collatzSequence;
            
        }
        private static void CreateCollatz (List<long> collatzSequence, long number) {
            collatzSequence.Add(number);
            if (number == 1) {
                return;
            }
            if (number % 2 == 0) {
                CreateCollatz (collatzSequence, number/2);
            }
            else {
                CreateCollatz (collatzSequence, number * 3 + 1);
            }

        }
        
    }
}
