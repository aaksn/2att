using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Utils
{
    public class ArrayUtils
    {
        public static readonly Random rnd = new Random();


        // создание одномерного массива целых чисел, заполненных случайными числами
        // от minValue до maxValue-1 (верхняя граница не входит)
        public static int[] CreateRandomArray(int length, int minValue, int maxValue) {
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
                arr[i] = rnd.Next(minValue, maxValue);

            return arr;
        }

        public static int[] CreateRandomArray(int length, int maxValue) {
            return CreateRandomArray(length, 0, maxValue);
        }


        // создание двухмерного массива целых чисел, заполненных случайными числами
        // от minValue до maxValue-1 (верхняя граница не входит)
        public static int[,] CreateRandomArray2(int rowCount, int colCount, int minValue, int maxValue) {
            int[,] arr = new int[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
                for (int c = 0; c < colCount; c++)
                    arr[r, c] = rnd.Next(minValue, maxValue);

            return arr;
        }

        public static int[,] CreateRandomArray2(int rowCount, int colCount, int maxValue) {
            return CreateRandomArray2(rowCount, colCount, 0, maxValue);
        }
    }
}
