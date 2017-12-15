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

        public Ten(int[,] mas)
        {
            Mas = mas;
        }
        public void Process(out int[,] res, out int maxi)
        {
            int n = Mas.GetLength(0);
            double[] res1 = new double[n];  //массив для хранения информации о коэфицентах           
            for (int i = 0; i < n; i++)
            {
                res1[i] = (double) Mas[i, 0] / Mas[i, 1];
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

                if (((double) Mas[x, 0] / Mas[x, 1])==key)
                {                    
                    for (int j = 0; j < 3; j++)//заполнение массива
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
