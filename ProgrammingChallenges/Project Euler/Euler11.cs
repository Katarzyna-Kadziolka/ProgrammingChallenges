using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Project_Euler {
    class Euler11 {
        public static void Calculate() {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int[,] array = new int[20, 20];
            string[] lines = File.ReadAllLines("./Euler11.txt");
            for (int i = 0; i < lines.Length; i++) {
                List<int> numberList = lines[i].Split(' ').Select(a => Convert.ToInt32(a)).ToList();
                for (int j = 0; j < numberList.Count; j++) {
                    array[i, j] = numberList[j];
                }
            }

            int horizontalProduct = GetHorizontalProduct(array);
            int verticalProduct = GetVerticalProduct(array);
            int diagonallyRightProduct = GetDiagonallyRightProduct(array);
            int diagonallyLeftProduct = GetDiagonallyLeftProduct(array);
            List<int> productsList = new List<int>()
                { horizontalProduct, verticalProduct, diagonallyRightProduct, diagonallyLeftProduct };

            Console.WriteLine(productsList.Max());

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static int GetHorizontalProduct(int[,] array) {
            int maxProduct = 0;
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++) {
                    if (j + 3 < array.GetLength(1)) {
                        int product = array[i, j] * array[i, j + 1] * array[i, j + 2] * array[i, j + 3];
                        if (product > maxProduct) {
                            maxProduct = product;
                        }
                    }
                }
            }

            return maxProduct;
        }

        private static int GetVerticalProduct(int[,] array) {
            int maxProduct = 0;
            for (int i = 0; i < array.GetLength(1); i++) {
                for (int j = 0; j < array.GetLength(0); j++) {
                    if (j + 3 < array.GetLength(0)) {
                        int product = array[i, j] * array[i, j + 1] * array[i, j + 2] * array[i, j + 3];
                        if (product > maxProduct) {
                            maxProduct = product;
                        }
                    }
                }
            }

            return maxProduct;
        }

        private static int GetDiagonallyRightProduct(int[,] array) {
            int maxProduct = 0;
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++) {
                    if (j + 3 < array.GetLength(1) && i + 3 < array.GetLength(0)) {
                        int product = array[i, j] * array[i + 1, j + 1] * array[i + 2, j + 2] * array[i + 3, j + 3];
                        if (product > maxProduct) {
                            maxProduct = product;
                        }
                    }
                }
            }

            return maxProduct;
        }

        private static int GetDiagonallyLeftProduct(int[,] array) {
            int maxProduct = 0;
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++) {
                    if (i + 3 < array.GetLength(0) && j + 3 < array.GetLength(1)) {
                        int product = array[i + 3, j] * array[i + 2, j + 1] * array[i + 1, j + 2] * array[i, j + 3];
                        if (product > maxProduct) {
                            maxProduct = product;
                        }
                    }
                }
            }

            return maxProduct;
        }
    }
}