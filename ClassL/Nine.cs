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
    public class Nine2
    {
        public int[,] Mas { get; set; }

        public Nine2(int[,] mas)
        {
            if (mas.GetLength(0) == mas.GetLength(1))
            {
                Mas = mas;
            }
        }
        public void Process(out int[,] res, out int resmin)
        {
            int n = Mas.GetLength(0);
            int[] res1 = new int[n];  //массив для хранения сумм столбцов
            int summ1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    summ1 += Math.Abs(Mas[j, i]);   //суммируем элементы столбцов
                }
                res1[i] = summ1; //пишем сумму в массив
                summ1 = 0; //обнуляем переменную
            }

            int min = res1.Min();// находим минимальную сумму
            //заполнение нового массива
            int[,] result = new int[1, n];
            for (int j = 0; j < n; j++)
            {
                result[0, j] = res1[j];
            }
            resmin = min;
            res = result;
        }

    }
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
            int n1 = Mas.GetLength(1);
            int[] res1 = new int[n1];  //массив для хранения сумм столбцов
            int summ1 = 0;
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    summ1 += Mas[j, i];   //суммируем элементы столбцов
                }
                res1[i] = summ1; //пишем сумму в массив
                summ1 = 0; //обнуляем переменную
            }
            int min = Array.IndexOf(res1, res1.Min());// находим индекс колонки с минимальным элементом            
            // находим индекс последней колонки с максимальным элементом  
            int max = Array.IndexOf(res1, res1.Max()), nmax = res1[0];
            for (int i = 1; i < res1.Length; ++i)
                if (res1[i] >= nmax)
                {
                    max = i;
                    nmax = res1[i];
                }
            //заполнение нового массива
            int[,] result = new int[n, n1];
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n1; y++)
                {
                    result[x, y] = Mas[x, y];

                    if (y == min)
                    {
                        result[x, y] = Mas[x, max];
                    }
                    if (y == max)
                    {
                        result[x, y] = Mas[x, min];
                    }
                }
            }

            res = result;
        
    }
        //Работа с консолью
        public static void PrintHelp()
        {
            string
                help = string.Format(@"
Назначение: Первый столбец с минимальной суммой элементов меняет местами с последним столбцом с максимальной суммой элементов.
Использование: {0} параметры
Параметры:
  -i, --input-file=ФАЙЛ     входной файл (обязательный параметр)
  -o, --output-file=ФАЙЛ    выходной файл (обязательный параметр)
  -h, --help                показать справку
                    ".Trim(),
                    ConsoleAppUtils.ExeName
                );

            Console.WriteLine(help);
        }
        public static void ParseArgs(string[] args, out string inputFile, out string outputFile)
        {
            CommandLine cmdLine = new CommandLine(args);

            if (cmdLine["help", "h"] != null || args.Length > 0 && args[0] == "/?")
            {
                PrintHelp();
                Console.ReadKey();
            }

            inputFile = cmdLine["input-file", "i"];
            outputFile = cmdLine["output-file", "o"];

            if (
                inputFile == null || inputFile == "false" ||
                outputFile == null || outputFile == "false"
            )
                ConsoleAppUtils.PrintParamsErrorAndExit();

            if (!File.Exists(inputFile))
            {
                ConsoleAppUtils.ErrorWriteLine("Файл {0} не найден!", inputFile);
            }
        }
    }
}
