using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Globalization;
using System.Diagnostics;


namespace Utils
{
    public class IOUtils
    {
        public static readonly string
            ExeName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName),
            ExeDir = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);


        public static void NumberFormatInit()
        {
            // чтобы вещественные числа разделялись точкой, а не запятой
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        public static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        // Функция ввода значения с консоли в диалогом режиме:
        //   функции передается название значения (переменной) в виде строки (string),
        //   функция возвращает введенное значение типа T;
        //   (string) -> T
        public static T ConsoleReadValue<T>(string varName)
        {
            while (true)
                try
                {
                    Console.Write("Введите {0}: ", varName);
                    return StrToValue<T>(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }

        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        // Функция конвертирует массив элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        public static string ArrayToStr<T>(IList<T> arr, string separator = ", ")
        {
            return arr == null ? "null" : string.Join(separator, arr);
        }

        // Функция ввода массива с консоли в диалогом режиме:
        //   функции передается название массива (переменной) в виде строки (string),
        //   функция возвращает введенное значение типа T[];
        //   (string) -> T[]
        public static T[] ConsoleReadArray<T>(string arrName)
        {
            while (true)
                try
                {
                    Console.WriteLine("Введите (через пробел или запятую) массив {0}: ", arrName);
                    Console.Write("  ");
                    return StrToArray<T>(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }
    }
}
