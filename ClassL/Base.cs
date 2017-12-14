using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace ClassL
{
    public class UtilsW
    {
        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }
        public static T StrToValue<T>(string str)
        {
            
            return (T)Convert.ChangeType(str, typeof(T), CultureInfo.InvariantCulture);
        }
        //Преобразует список в строку с разделителем c
        public static string ListtoString<T>(List<T> list, char c)
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in list)
            {
                string j = Convert.ToString(item);
                sb.Append(j + " ");
            }
            return sb.ToString();
        }
        //Преобразует строку с разделителем c в список
        public static List<T> StringToList<T>(string value, char c)
        {
            var list = new List<T>();
            value += c;
            int position = 0;
            int start = 0;            
            do
            {
                position = value.IndexOf(c, start);
                if (position >= 0)
                {
                    list.Add(StrToValue<T>(value.Substring(start, position - start + 1).Trim()));
                    start = position + 1;
                }
            } while (position > 0);
            return list;
        }
        //Работа с файлами
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
                    if (j == input.GetLength(1) - 1)
                    {
                        sb.Append(input[i, j].ToString());
                    }
                    else sb.Append(input[i, j].ToString() + ' ');
                }
                if (i != input.GetLength(0) - 1)
                {
                    sb.AppendLine();
                }
            }
            File.WriteAllText(filename, sb.ToString());
        }

    }
}
