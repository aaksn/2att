using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
        
    }
}
