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
    public class Nine
    {
        public int[,] Mas { get; set; }

        public Nine(int[,] mas)
        {
            Mas = mas;
        }
        public void Process(out int[,] res) 
        {
            int n = Mas.GetLength(0);
            int[] res1 = new int[n];  //массив для хранения сумм столбцов
            int summ1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    summ1 += Mas[j, i];   //суммируем элементы столбцов
                }
                res1[i] = summ1; //пишем сумму в массив
                summ1 = 0; //обнуляем переменную
            }

            

            res = Mas; 
        }

        //чтение многомерного массива из файла
        public static void ReadInputFromFile(string filename, char w, out int[,] res)
        {
                        
            string[] lines = File.ReadAllLines(filename).ToArray();
            //заводим массив
            int count = 1;
            foreach (char c in lines[1])
                if (c == w)
                {
                    count++;                    
                }
            int[,] arr = new int[lines.Length, count];
            // разбор в массив
            for (int i = 0; i < lines.Length; i++)
            {
                int[] row = lines[i].Split(new char[] { w }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < count; j++)
                {
                    arr[i, j] = row[j];
                }
            }
            res = arr;
        }
        


        // запись входных данных в файл
        public static void WriteInputIntoFile(string filename, int[,] input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.GetLength(0); i++)
            {                
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (j==input.GetLength(1) - 1)
                    {
                        sb.Append(input[i, j].ToString());
                    }
                    else sb.Append(input[i, j].ToString()+' ');                    
                }
                if (i != input.GetLength(0) - 1)
                {
                    sb.AppendLine();
                }                                
            }
            File.WriteAllText(filename, sb.ToString());
        }


        // запись выходных данных в файл
        // (отдельный метод, т.к. в общем случае
        //  входные данные могут по структуре толичаться от выходных данных)
        public static void WriteOutputIntoFile(string filename, IList<int> output)
        {
            string line = IOUtils.ArrayToStr(output);
            File.WriteAllLines(filename, new string[] { line });
        }
    }
}
