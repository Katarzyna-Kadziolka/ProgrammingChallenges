﻿using System;
using System.Text;
using Helpers;

namespace NameGenerator {
    public class Generator {
        public static string GenerateName(int wordLength) {
            StringBuilder sb = new StringBuilder();
            string consonants = "bcdfghjklmnpqrstvwxz";
            string vowel = "aeiouy";

            Random random = new Random();
            int start = random.Next(0, 2);
            for (int i = 0; i < wordLength; i++) {
                if (start == 0) {
                    if (i % 2 == 1) {
                        sb.Append(random.GetRandomChar(consonants));
                        if (random.Next(0, 3) == 0) {
                            sb.Append(random.GetRandomChar(consonants));
                        }
                    }
                    else {
                        sb.Append((random.GetRandomChar(vowel)));
                    }
                }
                else {
                    if (i % 2 == 1) {
                        sb.Append(random.GetRandomChar(consonants));
                        if (random.Next(0, 3) == 0) {
                            sb.Append(random.GetRandomChar(consonants));
                        }
                    }
                    else {
                        sb.Append(random.GetRandomChar(vowel));
                    }
                }

                if (sb.Length > wordLength) {
                    sb.Remove(sb.Length - (sb.Length - wordLength), sb.Length - wordLength);
                    break;
                }
            }

            return sb.ToString().Capitalize();
        }
    }
}