using System;
using System.Text;
using Helpers;

namespace NameGenerator {
    class Program {
        static void Main(string[] args) {
            int wordLength;
            Console.Write("Enter length of word: ");
            

            while (true) {
                try {
                    wordLength = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) {
                    Console.WriteLine("It wasn't a number");
                    return;
                }
                string name = Generator.GenerateName(wordLength);
                Console.WriteLine(name);
                Console.Write("Enter length of word: ");
            }
        }
    }

    
}
