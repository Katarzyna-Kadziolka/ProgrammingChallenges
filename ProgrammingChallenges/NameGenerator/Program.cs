using System;

namespace NameGenerator {
    class Program {
        static void Main() {
            Console.Write("Enter length of word: ");

            while (true) {
                int wordLength;
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