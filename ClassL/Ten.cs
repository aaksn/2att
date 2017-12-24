using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassL;
using Utils;

namespace ClassL
{
    public class Ten
    {
        public int[,] Mas { get; set; }
        public int[] K_a { get; set; }  // массив с "а" коэффицентами

        public int[] K_b { get; set; }  // массив с "b" коэффицентами
        public Ten(int[,] mas)
        {
            Mas = mas;
            // Заполнение массивов с коэффицентами a, b
            int[] koeff_a = new int[mas.GetLength(0)], koeff_b = new int[mas.GetLength(0)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {                
                koeff_a[i] = Mas[i, 0];
                koeff_b[i] = Mas[i, 1];
            }
            K_a = koeff_a;
            K_b = koeff_b;
        }
        public void Process(out int[,] res, out int maxi)
        {
            int n = Mas.GetLength(0);
            double[] res1 = new double[n];  //массив для хранения информации о коэфицентах           
            for (int i = 0; i < n; i++)
            {
                res1[i] = (double) K_a[i] / K_b[i];
            }
            // Словарь с числами и их количеством
            Dictionary<double, int> repeats = new Dictionary<double, int>();

            foreach (var numb in res1)
            {
                if (repeats.ContainsKey(numb))
                {
                    repeats[numb] += 1;
                }
                else
                {
                    repeats[numb] = 1;
                }
            }
            int max = repeats.Values.Max();//максимальное количество повторяющихся значений
            double key = repeats.First(x => x.Value == max).Key;
            int[,] result = new int[max, 3];
            int k = 0;
            for (int x = 0; x < n; x++)
            {

                if (((double) K_a[x] / K_b[x]) == key)
                {                    
                    for (int j = 0; j < 3; j++) //заполнение массива
                    {
                        result[k, j] = Mas[x, j];
                    }
                    k++;
                }                
            }
            res = result;
            maxi = max;
        }        
    }
}
